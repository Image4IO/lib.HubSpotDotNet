using HubSpotDotNet.Contacts.Models;
using HubSpotDotNet.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System;

namespace HubSpotDotNet.Contacts
{
    public class ContactsClient : HubSpotBaseClient, IContactsClient
    {
        public ContactsClient(HttpClient client, string apiKey) : base(client, apiKey)
        {
        }

        public bool CreateANewContact(CreateANewContactRequestModel model) => CreateANewContactAsync(model).GetAwaiter().GetResult();

        public async Task<bool> CreateANewContactAsync(CreateANewContactRequestModel model)
        {

            string json = JsonConvert.SerializeObject(new ContactBaseModel
            {
                Properties = model.GetListOfProperties()
            });
            StringContent stringContent = new StringContent(json, Encoding.Default, "application/json");


            var result = await _client.PostAsync("contacts/v1/contact?hapikey=" + APIKey, stringContent);
            var jsonResponse = await result.Content.ReadAsStringAsync();


            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                var response = JsonConvert.DeserializeObject<BaseModel>(jsonResponse);
                if (response?.ValidationResults?.Where(v => v.isValid == false).Count() > 0)
                {
                    throw new ValidationException(response.ValidationResults.Where(v => v.isValid == false).First().message);
                }
                else if(response != null && response.Message != null)
                {
                    throw new Exception(response.Message);
                }
                else
                {
                    throw new Exception("Unkown Error");
                }
            }
        }

        public bool CreateOrUpdateAContact(CreateOrUpdateAContactRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateOrUpdateAContactAsync(CreateOrUpdateAContactRequestModel model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAnExistingContact(UpdateAnExistingContactRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAnExistingContactAsync(UpdateAnExistingContactRequestModel model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAnExistingContactByEmail(UpdateAnExistingContactByEmailRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAnExistingContactByEmailAsync(UpdateAnExistingContactByEmailRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
