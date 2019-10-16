using HubSpotDotNet.Forms.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotDotNet.Forms
{
    public interface IFormsClient : IHubSpotBaseClient
    {
        SubmitDataToAFormModel SubmitDataToAForm();
        Task<SubmitDataToAFormModel> SubmitDataToAFormAsync();
    }
}
