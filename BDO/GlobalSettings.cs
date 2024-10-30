using BDO;
using System;
using System.Collections.Generic;
using System.Text;


namespace BDO
{
    public enum ServiceIdEnum
    {
        MOHE = 1,
        Kuwait_University = 2,
        PAAET = 3,
        PUC = 4,
        Disabled = 5,
        Departed = 6,
        KFSD = 7,
        CivilServiceCom = 8,
        KPC = 9,
        MOE = 10,
        MOI = 11,
        Manpower = 12,
        MOINewService = 13,
        PIFSS = 14,
        PACI = 15,

    }
    public enum RegistrationStatusEnm
    {
        //1. Account Opening; 2. Account updated 3. Account Submitted, 4 Delayed, 5. Exempted, 6. Exception
        Account_OP = 1,
        Account_Update = 2,
        Account_Submited = 3
    }
    public enum TrainingStatusEnm
    {
        Account_Active = 1,
        Account_Delayed = 2,
        Account_Excempted = 3,
        Account_Exception = 4,
        Account_StopService = 5,
        Account_Completed = 6,
        Account_OnProcess=7

    }

    public enum RequestDecisionTypeEnum
    {
		Delayed = 2,
		Excemption = 3,
		RequestForJoin = 4,
        Exception = 5,
        RequestForReMedical = 8,
		DocumentVerification = 9,

	}

	public enum RelationshipIdEnm
    {
        Father=7,
        Mother=8
    }


    public enum MedicalResultEnum {
        Fit_for_Admin=1,
        Fit_for_Field = 2,
        Unfit = 3,
    }

	public enum MedicalResultStatus
	{
		Finished=1 ,
        ReExam=2,
        Cancel=3
	}

	public enum RequestFromEnum
    {
      Personal=1 ,Medical=2,Training=3,System=4,ServiceApi=5
    }

    public enum RequestStatusEnum
    {
        Pending = 1, Approved = 2, Declined = 3
    }


    public enum FileConfig
    {
        PersonalCivilid = 1,
        Medical = 2,
        StatusChange = 3,
        LatePunishment=4
    }


}

public struct Age
{
    public readonly int Years;
    public readonly int Months;
    public readonly int Days;

    public readonly string AgeinString;

    public Age(int y, int m, int d) : this()
    {
		var isRtl = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft;

		Years = y;
        Months = m;
        Days = d;
        AgeinString = isRtl? $"{Years} سنة {Months} شهر {Days} يوم": $"{Years} Year {Months} Month {Days} Day";
    }

    

    public static Age CalculateAge(DateTime birthDate)
    {
        DateTime toDate = DateTime.Now;
        if (birthDate.Date > toDate.Date)
        {
            throw new ArgumentException("startDate cannot be higher then endDate", "startDate");
        }

        int years = toDate.Year - birthDate.Year;
        int months = 0;
        int days = 0;

        // Check if the last year, was a full year.
        if (toDate < birthDate.AddYears(years) && years != 0)
        {
            years--;
        }

        // Calculate the number of months.
        birthDate = birthDate.AddYears(years);

        if (birthDate.Year == toDate.Year)
        {
            months = toDate.Month - birthDate.Month;
        }
        else
        {
            months = (12 - birthDate.Month) + toDate.Month;
        }

        // Check if last month was a complete month.
        if (toDate < birthDate.AddMonths(months) && months != 0)
        {
            months--;
        }

        // Calculate the number of days.
        birthDate = birthDate.AddMonths(months);

        days = (toDate - birthDate).Days;

        return new Age(years, months, days);
    }
}



public static class ParseTrainingStatus
{
  public static  string GetTrainingStatus(int? trainingstatus, long? knsNo)
    {
        string strTrainingStatus = string.Empty;

        var isRtl = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft;

        switch (trainingstatus)
        {
            case null:
            case (int)TrainingStatusEnm.Account_Active:
                if (knsNo.HasValue) {
                    strTrainingStatus = isRtl ? "مجند" : "Trainee";
                }
                else
                {
                    strTrainingStatus = isRtl ? "مكلف" : "Recruit";
                }
                break;
            case (int)TrainingStatusEnm.Account_Delayed:
                strTrainingStatus = isRtl ? "تأجيل" : "Delay";
                break;
            case (int)TrainingStatusEnm.Account_Excempted:
                strTrainingStatus = isRtl ? "إعفاء" : "Exemption";
                break;
            case (int)TrainingStatusEnm.Account_Exception:
                strTrainingStatus = isRtl ? "إستثناء" : "Exception";
                break;
            case (int)TrainingStatusEnm.Account_StopService:
                strTrainingStatus = isRtl ? "وقف الخدمة" : "Stop Service";
                break;
            case (int)TrainingStatusEnm.Account_Completed:
                strTrainingStatus = isRtl ? "مجند انهى الأحتياط" : "Completed";
                break;
        }

        return strTrainingStatus;
    }
}