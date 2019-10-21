using HubSpotDotNet.Contacts.Models;
using System.Threading.Tasks;

namespace HubSpotDotNet.Contacts
{
    public interface IContactsClient : IHubSpotBaseClient
    {
        bool CreateANewContact(CreateANewContactRequestModel model);
        Task<bool> CreateANewContactAsync(CreateANewContactRequestModel model);


        bool UpdateAnExistingContact(UpdateAnExistingContactRequestModel model);
        Task<bool> UpdateAnExistingContactAsync(UpdateAnExistingContactRequestModel model);



        bool UpdateAnExistingContactByEmail(UpdateAnExistingContactByEmailRequestModel model);
        Task<bool> UpdateAnExistingContactByEmailAsync(UpdateAnExistingContactByEmailRequestModel model);


        bool CreateOrUpdateAContact(CreateOrUpdateAContactRequestModel model);
        Task<bool> CreateOrUpdateAContactAsync(CreateOrUpdateAContactRequestModel model);




    }
}
