using HubSpotDotNet.Contacts.Models;
using System.Threading.Tasks;

namespace HubSpotDotNet.Contacts
{
    public interface IContactsClient : IHubSpotBaseClient
    {
        bool CreateANewContact(CreateANewContactRequestModel model);
        Task<bool> CreateANewContactAsync(CreateANewContactRequestModel model);
    }
}
