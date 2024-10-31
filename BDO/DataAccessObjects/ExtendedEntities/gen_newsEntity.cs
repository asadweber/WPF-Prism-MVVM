using System;
using System.Runtime.Serialization;
using System.Data;
using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using KAF.BusinessDataObjects;

namespace BDO.Core.DataAccessObjects.Models
{

    public partial class gen_newsEntity 
    {
        //private IFormFile imagefile1;
        //private List<IFormFile> imagefile2;
        private gen_newsgalleryEntity _gen_newsgallery;
        private List<gen_newsgalleryEntity> _gen_newsgalleryList;
        private List<cor_foldercontentsEntity> fileList;

        [DataMember] 
        public List<cor_foldercontentsEntity> imagefiles { get => fileList; set => fileList = value; }

        //[DataMember]
        //public IFormFile imagefile { get => imagefile1; set => imagefile1 = value; }

        //[DataMember]
        //public List<IFormFile> imagefiles { get => imagefile2; set => imagefile2 = value; }

        [DataMember]
        public gen_newsgalleryEntity gen_newsgallery { get => _gen_newsgallery; set => _gen_newsgallery = value; }

        [DataMember]
        public List<gen_newsgalleryEntity> gen_newsgalleryList { get => _gen_newsgalleryList; set => _gen_newsgalleryList = value; }


    }
}
