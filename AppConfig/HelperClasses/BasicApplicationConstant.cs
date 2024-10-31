using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BDO.Core.Base;
using CLL.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json.Linq;

namespace AppConfig.HelperClasses
{
    public class BasicApplicationConstant
    {
        public static IStringLocalizerFactory Factory { get; set; }

        private readonly LocalizeService _sharedLocalizer;

        public BasicApplicationConstant(LocalizeService sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }

        public enum basicbuttons
        {
            Edit = 1,
            Delete = 2,
            View = 3
        }

        public enum DocumentTypeEnum
        {
            Mudakkara = 1,
            Kitab = 2,
            Circular = 3,
        }

        // Gen Batch Candidate Type
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GenBatchCandidateType()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "Kuwaiti";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "Non-Kuwaiti";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "Bedun";
            objitem.Value = "3";
            optisonS.Add(objitem);
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        // Gen Batch Military Type
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GenBatchMilitaryType()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "ضباط صف / Warrant Officer";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "أفراد / Soldier";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "جندي مهني / Professionals"; 
            objitem.Value = "3";
            optisonS.Add(objitem);
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        // Gen Batch Gender
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GenBatchGender()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "ذكر / Male";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "أنثى / Female";
            objitem.Value = "2";
            optisonS.Add(objitem);
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        //Cnf Notification Template Type
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> CnfNotificationTemplateType()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "رسالة نصية / SMS";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "العنوان التلقائي / Paci";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "البريد الالكتروني / Email";
            objitem.Value = "3";
            optisonS.Add(objitem);
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }


        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> IDTypeSelection(long? id=null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "بطاقة مراجعة / Security ID"; 
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "البطاقة المدنية / Civil ID";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "ضمان صحي / Health Insurance";
            objitem.Value = "3";
            optisonS.Add(objitem);

            if (id != null)
            {
                foreach (var item in optisonS)
                {
                    if (long.Parse(item.Value) == id)
                    {
                        item.Selected = true;
                    }
                }
            }

            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }
        //public enum MaritalStatusEnum
        //{
        //    Unmarried = 1,
        //    Married = 2,
        //    Widowed = 3,
        //    Divorced = 4,
        //}

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> MaritialStatusSelectionddl(long? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text =MaritalStatusEnum.Unmarried.ToString();
            objitem.Value = ((long)MaritalStatusEnum.Unmarried).ToString();
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = MaritalStatusEnum.Married.ToString();
            objitem.Value = ((long)MaritalStatusEnum.Married).ToString();
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (long.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;


            return myEnumerable;
        }
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> BooleanSelectionddl(bool? Value=null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "نعم / Yes";
            objitem.Value = "True";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لا / No";
            objitem.Value = "False";
            optisonS.Add(objitem);

            if (Value!=null) {
                foreach (var item in optisonS)
                {
                    if (bool.Parse( item.Value) == Value) {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;


            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> BrotherRelationSelectionddl(long? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "شقيق / Brother";
            objitem.Value = ((long)RelationshipEnum.Brother).ToString();
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير شقيق جهة الأب / Brother from Father side";
            objitem.Value = ((long)RelationshipEnum.PaternalBrother).ToString();
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير شقيق جهة الأم / Brother from Mother side";
            objitem.Value = ((long)RelationshipEnum.MaternalBrother).ToString();
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (long.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;


            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> SisterRelationSelectionddl(long? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "شقيقة / Sister";
            objitem.Value = ((long)RelationshipEnum.Sister).ToString();
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير شقيقة جهة الأب / Sister from Father Side";
            objitem.Value = ((long)RelationshipEnum.PaternalSister).ToString();
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير شقيقة جهة الأم / Sister from Mother Side";
            objitem.Value = ((long)RelationshipEnum.MaternalSister).ToString();
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (long.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;


            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> DeathBooleanSelectionddl(bool? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "حي / Alive";
            objitem.Value = "True";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "متوفي / Dead";
            objitem.Value = "False";
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (bool.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }

            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> ApplicantReviewAuditPassed(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "ناجح / Passed";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "فشل / Failed";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "التراجع  / Rollback";
            objitem.Value = "3";
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }

            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> ddlApplicantReviewAuditPassed(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "ناجح / Passed";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "فشل / Failed";
            objitem.Value = "2";
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }

            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> CentralAgencySyResultStatus(bool? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "نعم / Ok";
            objitem.Value = "True";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "ليس بخير / Not Ok";
            objitem.Value = "False";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (bool.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerSecurityStatus(bool? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "جاهز للأمن / Ready for Security";
            objitem.Value = "False";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "إلى الأمام للأمن / Forwarded for Security";
            objitem.Value = "True";
            optisonS.Add(objitem);
            
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (bool.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> SecurityExaminationResultSearchStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "موافقة / Agree";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "عدم موافقة / Not Agree";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "تدقيق / Hold";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "إعادة الاختبار / Re-Test";
            objitem.Value = "5";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> SecurityExaminationResultStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "موافقة / Agree";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "عدم موافقة / Not Agree";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "تدقيق / Hold";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "التراجع  / Rollback";
            objitem.Value = "4";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> SecurityExaminationReTestResultStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "موافقة / Agree";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "عدم موافقة / Not Agree";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "تدقيق / Hold";
            objitem.Value = "3";
            optisonS.Add(objitem);
            
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerReTestApprovalStatus(bool? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "غير معتمد / Not Approved";
            objitem.Value = "False";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "موافقة / Approved";
            objitem.Value = "True";
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (bool.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerUnitStatus(bool? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "الاستعداد لامتحان الوحدة / Ready for Unit";
            objitem.Value = "False";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "إلى الأمام للوحدة / Forwarded for Unit";
            objitem.Value = "True";
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (bool.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> UnitClearanceResultSearchStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "ناجح / Passed";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "فشل / Failed";
            objitem.Value = "2";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> UnitClearanceResultStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "ناجح / Passed";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "فشل / Failed";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "التراجع  / Rollback";
            objitem.Value = "3";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerMedicalStatus(bool? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "طبي جاهز / Ready for Medical"; //"غير شقيق جهة الأم / Brother from Mother side";
            objitem.Value = "False";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "إرسال إلى الطبية / Forwarded for Medical";
            objitem.Value = "True";
            optisonS.Add(objitem);

            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (bool.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GeneralMedicalExaminationResultSearchStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لائق / Fit";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير لائق / Unfit";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "تدقيق / Hold";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غائب / Absent";
            objitem.Value = "4";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لم يكتمل / Incomplete";
            objitem.Value = "5";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> GeneralMedicalExaminationResultStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لائق / Fit";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير لائق / Unfit";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "تدقيق / Hold";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غائب / Absent";
            objitem.Value = "4";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لم يكتمل / Incomplete";
            objitem.Value = "5";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "التراجع / Rollback";
            objitem.Value = "6";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> PsychologyExaminationResultStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لائق / Fit";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير لائق / Unfit";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "تدقيق / Hold";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غائب / Absent";
            objitem.Value = "4";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لم يكتمل / Incomplete";
            objitem.Value = "5";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> FinalExaminationResultStatus(int? Value = null)
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "انتظار / Waiting";
            objitem.Value = "0";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "ناجح / Passed";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "فشل / Failed";
            objitem.Value = "2";
            optisonS.Add(objitem);
            if (Value != null)
            {
                foreach (var item in optisonS)
                {
                    if (int.Parse(item.Value) == Value)
                    {
                        item.Selected = true;
                    }
                }
            }
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> NotificationStatus()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "إجمالي المرسلة / Sent";
            objitem.Value = "True";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "لم يتم إرسال الإجمالي / Not Sent";
            objitem.Value = "False";
            optisonS.Add(objitem);
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerResultReportParam()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "يالمتطوعين الذين تم فتح ملف لهم";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "بالمتطوعين الذين لم يتم فتح ملف لهم";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "بالمتطوعين الذين التحقوا";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "بالمتطوعين الذين لم يلتحقوا";
            objitem.Value = "4";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "بالمتطوعين الذين تم فتح ملف لهم حسب مكان صدور الشهادة";
            objitem.Value = "5";
            optisonS.Add(objitem);
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerResultReportNatSelect()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "الجميع";
            objitem.Value = "null";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "كويتي";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير كويتي";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "مقيم بصوره غير قانونيه";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "جنسيات اخرى";
            objitem.Value = "4";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير كويتي";
            objitem.Value = "5";
            optisonS.Add(objitem);
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerResultReportResultList()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem.Text = "الجميع";
            objitem.Value = "null";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "غير مستثني";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "مستثني";
            objitem.Value = "9";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> VolunteerClearanceTypeList()
        {
            IList<SelectListItem> optisonS = new List<SelectListItem>();
            SelectListItem objitem = new SelectListItem();
            objitem = new SelectListItem();
            objitem.Text = "امن / Security";
            objitem.Value = "1";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "طبي / Medical";
            objitem.Value = "2";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            objitem.Text = "الوحدة / Unit";
            objitem.Value = "3";
            optisonS.Add(objitem);
            objitem = new SelectListItem();
            IEnumerable<SelectListItem> myEnumerable = optisonS;
            return myEnumerable;
        }

    }
}
