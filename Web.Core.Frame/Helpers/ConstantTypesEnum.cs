using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Web.Core.Frame.Helpers
{
    public static class ConstantTypesEnum
    {
        public enum ServiceInfoTypeEnum
        {
            Service_reinstatement_request = 1
        }
        public enum ServiceStatusTypeEnum
        {
            New = 1,
            Pending = 2,
            Approved = 3,
            Rejected = 4,
        }


        public enum SelectionTypeEnum
        {
            Self = 1,
            Delegate = 2,
            Sharing = 3,
            Secretary = 4,
        }

        public enum SelectionActionEnum
        {
            NewMemo,

            EditMemo,
            EditKitab,
            NewKitab,

            EditCircular,

            NewCircular,
            ReplyMemo,
            ReplyKitab,


            ForwordMemo,
            ForwardKitab,
            ConvertToKitab,
            ConvertToMemo,
        }

        public enum DocumentTypeEnum
        {
            Memo = 1,
            Kitab = 2,
            Circular = 3,
        }

        public enum DistributiontypeEnum
        {
            To = 1,
            CC = 2
        }

        //[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v11.0.0.0)")]
        public enum EntityState
        {
            _0 = 0,

            _1 = 1,

            _2 = 2,

            _3 = 3,
        }
    }
}
