using HubSpotDotNet.Models;
using System.Threading.Tasks;

namespace HubSpotDotNet
{
    public interface IHubSpot
    {
        GetAccountDetailsModel GetAccountDetails();
        Task<GetAccountDetailsModel> GetAccountDetailsAsync();

        CheckDailyApiUsageModel CheckDailyApiUsage();
        Task<CheckDailyApiUsageModel> CheckDailyApiUsageAsync();
    }
}
