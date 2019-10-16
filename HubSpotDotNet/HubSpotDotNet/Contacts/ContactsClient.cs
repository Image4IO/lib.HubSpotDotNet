using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HubSpotDotNet.Contacts
{
    public class ContactsClient : HubSpotBaseClient, IContactsClient
    {
        public ContactsClient(HttpClient client, string apiKey) : base(client, apiKey)
        {
        }

        public void Tets()
        {
            var a = _client.BaseAddress;
        }
        
    }
}
