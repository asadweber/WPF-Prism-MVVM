using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BDO.Core.DataAccessObjects.Models
{
    public partial class cnf_notificationtempletEntity : BaseEntity
    {

        protected void LoadFromReader(IDataReader reader, int e)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("NotificationTemplateID"))) _notificationtemplateid = reader.GetInt64(reader.GetOrdinal("NotificationTemplateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateShortName"))) _templateshortname = reader.GetString(reader.GetOrdinal("TemplateShortName"));
                if (!reader.IsDBNull(reader.GetOrdinal("TemplateMSG"))) _templatemsg = reader.GetString(reader.GetOrdinal("TemplateMSG"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
    }
}