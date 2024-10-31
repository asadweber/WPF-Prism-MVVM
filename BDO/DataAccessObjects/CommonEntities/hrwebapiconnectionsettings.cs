
namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class hrwebapiconnectionsettings
    {
        public string DefaultConnection { get; set; }
        public string apiusername { get; set; }
        public string apipassword { get; set; }
        public bool isRequired { get; set; }
        public bool isAdCheckRequired { get; set; }

        public string LDAPURL { get; set; }
        
    }
}
