using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BDO.Core.DataAccessObjects.CommonEntities
{
    public class ContactUsModel
    {

        public int Id { get; set; }

        [DataMember]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "_fullname", ResourceType = typeof(CLL.LLClasses._Common))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "_fullnameRequired")]
        public string fullname { get; set; }

        [Display(Name = "_email", ResourceType = typeof(CLL.LLClasses._Common))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "_emailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "_emailRequired")]
        public string email { get; set; }

        [StringLength(250, MinimumLength = 3)]
        [Display(Name = "_subject", ResourceType = typeof(CLL.LLClasses._Common))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "_subjectRequired")]
        public string subject { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(550, MinimumLength = 20)]
        [Display(Name = "_message", ResourceType = typeof(CLL.LLClasses._Common))]
        [Required(ErrorMessageResourceType = typeof(CLL.LLClasses._Common), ErrorMessageResourceName = "_messageRequired")]
        public string message { get; set; }


    }
}
