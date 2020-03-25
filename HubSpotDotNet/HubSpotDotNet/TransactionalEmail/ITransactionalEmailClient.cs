using HubSpotDotNet.TransactionalEmail.Models;
using System.Threading.Tasks;

namespace HubSpotDotNet.TransactionalEmail
{
    public interface ITransactionalEmailClient : IHubSpotBaseClient
    {
        bool SendSingleEmail(SendSingleEmailRequestModel model);
        Task<bool> SendSingleEmailAsync(SendSingleEmailRequestModel model);

    }
}
