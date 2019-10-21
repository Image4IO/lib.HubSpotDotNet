using HubSpotDotNet.Enums;
using System.Collections.Generic;
using System.Linq;

namespace HubSpotDotNet.Contacts.Models
{
    public class CreateANewContactRequestModel : ContactBaseModel
    {
        public CreateANewContactRequestModel()
        {
            Properties = new List<Property>();
        }

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Website { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public LifecycleStage LifecycleStage { get; set; }

        public List<Property> GetListOfProperties()
        {
            var listOfObject = this.GetType()
                         .GetProperties();

            var temp = new List<Property>();

            foreach (var o in listOfObject)
            {
                if (o.PropertyType.Name == "String" && o.GetValue(this) != null)
                {
                    temp.Add(new Property
                    {
                        PropertyName = o.Name.ToLower(),
                        Value = (string)o.GetValue(this)
                    });
                }
                else if (o.PropertyType.Name == "LifecycleStage")
                {
                    temp.Add(new Property
                    {
                        PropertyName = o.Name.ToLower(),
                        Value = ((LifecycleStage)o.GetValue(this)).ToString("g").ToLower()
                    });
                }
            }

            return Properties.Concat(temp).ToList();
        }
    }


}
