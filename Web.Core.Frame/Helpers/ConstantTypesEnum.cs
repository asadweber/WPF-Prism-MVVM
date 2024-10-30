using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Web.Core.Frame.UseCases;

namespace Web.Core.Frame.Helpers
{
	public static class ConstantTypesEnum
	{
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

		public enum ProfileStatus
		{
			[Display(Name = "فعال")]
			Active = 1,
			[Display(Name = "مؤجل")]
			Delayed = 2,
			[Display(Name = "معفي")]
			Exempted = 3,
			[Display(Name = "مستثنى")]
			Exception = 4
		}
		public enum BatchDetailStatus
		{
			[Display(Name = "فعال")]
			Active = 1,
			[Display(Name = "محذوف")]
			Delayed = 2
		}

		public enum APIServiceStatusvalue
		{
			[Display(Name = "فعال")]
			Active = 1,
			
			[Display(Name = "مؤجل")]
			Delayed = 2,
			
			[Display(Name = "معفي")]
            Exempted = 3
		}
		public enum BatchDetailPreviouslyInvited
		{
			[Display(Name = "نعم")]
			Yes = 1,
			[Display(Name = "لا")]
			No = 0
		}

		public enum DecisionApproval
		{
			[Display(Name = "قيد الانتظار")]
			Pending = 0,
			[Display(Name = "موافق")]
			Approved = 1,
			[Display(Name = "مرفوض")]
			Declined = 6,
			[Display(Name = "التحاق")]
			Join = 4,
			[Display(Name = "إعادة فحص طبي")]
			MedicalReExam = 8
		}

		public static string GetDisplayName(long? value, Type type)
		{
			string displayValue = "";
			try
			{
				foreach (var enumName in Enum.GetNames(type))
				{
					if (((int)Enum.Parse(type, enumName, true)) == value)
					{
						var field = type.GetField(enumName);
						var display = ((System.ComponentModel.DataAnnotations.DisplayAttribute[])field.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.DisplayAttribute), false)).FirstOrDefault();
						if (display != null)
						{
							displayValue = display.Name;
						}
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
			return displayValue;
		}

		internal static List<KAFParamsListGeneric> ToSelectList<T>(Type type)
		{
			List<KAFParamsListGeneric> obj = new List<KAFParamsListGeneric>();
			foreach (var enumName in Enum.GetNames(type))
			{
				var idValue = ((int)Enum.Parse(type, enumName, true)).ToString();
				var displayValue = enumName;

				// get the corresponding enum field using reflection
				var field = type.GetField(enumName);
				var display = ((System.ComponentModel.DataAnnotations.DisplayAttribute[])field.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.DisplayAttribute), false)).FirstOrDefault();
				if (display != null)
				{
					displayValue = display.Name;
				}
				obj.Add(new KAFParamsListGeneric()
				{
					paramname = displayValue,
					paramvalue = idValue
				});
			}
			return obj;
		}
	}
}
