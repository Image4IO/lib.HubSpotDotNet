using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HubSpotDotNet.Contacts
{
    public class ContactsClient : HubSpotBaseClient, IContactsClient
    {
        public ContactsClient(HttpClient client) : base(client)
        {
        }

        public void Tets()
        {
            var a = _client.BaseAddress;
        }
    }
}
