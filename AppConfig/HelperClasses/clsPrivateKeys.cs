using AppConfig.EncryptionHandler;
using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace AppConfig.HelperClasses 
{
    public class clsPrivateKeys
    {
        /// <summary>
        /// Encode Parameter with url
        /// </summary>
        /// <param name="Controller"></param>
        /// <param name="Action"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public string EncodeUrlParams(string Controller, string Action, params string[] param)
        {
            string RequestParam = "";
            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }
            EncryptionHelper objEnc = new EncryptionHelper();
            return Controller + "/" + Action + "?params=" + System.Web.HttpUtility.UrlEncode(System.Text.Encoding.UTF8.GetBytes(objEnc.Encrypt(RequestParam, true, _pk)));
        }


        /// <summary>
        /// Encode Parameter with url
        /// </summary>
        /// <param name="Controller"></param>
        /// <param name="Action"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public string EncodeUrlOnlyParams( params string[] param)
        {
            string RequestParam = "";
            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }
            EncryptionHelper objEnc = new EncryptionHelper();
            return System.Web.HttpUtility.UrlEncode(System.Text.Encoding.UTF8.GetBytes(objEnc.Encrypt(RequestParam, true, _pk)));
        }

        /// <summary>
        ///  Decode Url Params With URI 
        /// </summary>
        /// <param name="ParamName"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public string DecodeOnlyUrlParams(string ParamName, string value)
        {
            EncryptionHelper objEnc = new EncryptionHelper();
            string result = string.Empty;
            //var uri = new Uri(url);
            //var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            //var val = query.Get("params");

            if (string.IsNullOrEmpty(value)) { return string.Empty; }

            System.Collections.Specialized.NameValueCollection paramList = System.Web.HttpUtility.ParseQueryString(objEnc.Decrypt(System.Text.Encoding.UTF8.GetString(System.Web.HttpUtility.UrlDecodeToBytes(value)), true, _pk));

            foreach (string parmId in paramList.Keys)
            {
                string[] values = paramList.GetValues(parmId);
                if (values != null)
                    foreach (string parmvalue in values)
                    {
                        if (parmId.ToLower() == ParamName.ToLower())
                        {
                            if (parmvalue == "")
                            {
                                return string.Empty;
                            }
                            else
                            {
                                return parmvalue;
                            }
                        }
                    }
            }

            if (result == "") { return string.Empty; }

            return result;
        }

        /// <summary>
        /// Encode Parameter with out url
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string EncodeParams(params string[] param)
        {
            string RequestParam = "";

            for (int i = 0; i <= param.Length - 1; i++)
            {
                if (i % 2 == 0)
                    RequestParam = RequestParam + param[i] + "=";
                else
                    if (i == param.Length - 1)
                    RequestParam = RequestParam + param[i];
                else
                    RequestParam = RequestParam + param[i] + "&";
            }
            EncryptionHelper objEnc = new EncryptionHelper();
            return "?params=" + System.Web.HttpUtility.UrlEncode(System.Text.Encoding.UTF8.GetBytes(objEnc.Encrypt(RequestParam, true, _pk)));
        }

        /// <summary>
        /// Decode Url Params Without URI 
        /// </summary>
        /// <param name="ParamName"></param>
        /// <param name="ParamValue"></param>
        /// <returns></returns>
        public string DecodeUrlParamsWithoutURI(string ParamName, string ParamValue)
        {
            EncryptionHelper objEnc = new EncryptionHelper();
            string result = string.Empty;
            if (string.IsNullOrEmpty(ParamValue)) { return string.Empty; }
            //System.Collections.Specialized.NameValueCollection paramList = System.Web.HttpUtility.ParseQueryString(objEnc.Decrypt(System.Text.Encoding.UTF8.GetString(System.Web.HttpUtility.UrlDecodeToBytes(ParamValue)), true, _pk));

            System.Collections.Specialized.NameValueCollection paramList = System.Web.HttpUtility.ParseQueryString(objEnc.Decrypt(ParamValue, true, _pk));
            foreach (string parmId in paramList.Keys)
            {
                string[] values = paramList.GetValues(parmId);
                if (values != null)
                    foreach (string parmvalue in values)
                    {
                        if (parmId.ToLower() == ParamName.ToLower())
                        {
                            if (parmvalue == "")
                            {
                                return string.Empty;
                            }
                            else
                            {
                                return parmvalue;
                            }
                        }
                    }
            }
            if (result == "") { return string.Empty; }
            return result;
        }


        /// <summary>
        ///  Decode Url Params With URI 
        /// </summary>
        /// <param name="ParamName"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public string DecodeUrlParamsWithURI(string ParamName, string url)
        {
            EncryptionHelper objEnc = new EncryptionHelper();
            string result = string.Empty;
            var uri = new Uri(url);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            var val = query.Get("params");

            if (string.IsNullOrEmpty(val)) { return string.Empty; }
            System.Collections.Specialized.NameValueCollection paramList = System.Web.HttpUtility.ParseQueryString(objEnc.Decrypt(System.Text.Encoding.UTF8.GetString(System.Web.HttpUtility.UrlDecodeToBytes(val)), true, _pk));

            foreach (string parmId in paramList.Keys)
            {
                string[] values = paramList.GetValues(parmId);
                if (values != null)
                    foreach (string parmvalue in values)
                    {
                        if (parmId.ToLower() == ParamName.ToLower())
                        {
                            if (parmvalue == "")
                            {
                                return string.Empty;
                            }
                            else
                            {
                                return parmvalue;
                            }
                        }
                    }
            }

            if (result == "") { return string.Empty; }

            return result;
        }

        public string GetSesTokKeyForPublicSite(string sessionid, string domainname)
        {
            string strEn = string.Empty;

            AppConfig.HelperClasses.transactioncodeGen objTrans = new transactioncodeGen();
            string token = objTrans.GetRandomAlphaNumericStringForTransactionActivity(sessionid + "_" + domainname + "_", DateTime.Now);

            objTrans.Dispose();
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(string));
            ser.WriteObject(ms, token);
            EncryptionHelper obje = new EncryptionHelper();
            clsPrivateKeys objS = new clsPrivateKeys();
            byte[] json = ms.ToArray();
            ms.Close();
            string encString = Encoding.UTF8.GetString(json, 0, json.Length);
            strEn = obje.Encrypt(encString, true, objS.GetKeys());

            return strEn;
        }

        public Object DeSerializeAnObject(string XmlOfAnObject, Type ObjectType)
        {
            try
            {
                try
                {

                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(ObjectType);
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(XmlOfAnObject));
                    Object obj = (Object)serializer.ReadObject(ms);
                    return obj;

                }
                catch (Exception ex)
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string getPublicKey()
        {
            string publickey = string.Empty;
            publickey = @"<BitStrength>4448</BitStrength><RSAKeyValue><Modulus>wYICuPiqsj90MMtTcJXzxGyNolSCaA+otaz09Dm1TXRLwh7Q7jLV8W7Jy8a25nkU/0SDM3bD9KgrNNgxRZnIB6H2RpZg+8AhdUJ8O1ifHgtdmIQPfBu28hdyGimMzWzBIlssAcMTfdPbtpvEBRegtuoIXbCChaLpnlI/INGkxu3+zBSGYC9JvuXaYRCP8Kd/W1bEN169HLb3SKEI1k5co43ituS517NwimFzjNUpA99A6KHPaddavQsDe6VCR78qpSOYMHObq3ge8u5rcGD9XGtHvTW211UjtzqiIghNIm9g//Tb64NtP+eGpSN/2X5FgzMUEi2Bpa9HiDjJXaR0M+8iu/a38JAkO3PF8Xols3cnsPvZ/OOPyaOI7D0H34zYEH0QVR/JcICm/CNPPpeHc6ilO6hpwa/Jg+5wGELpDvKSl/UMrbLZp0wysE130BY3uDaHgv6Mbjs0Co/2652JF8sxOjYVMtC/HeWBMm1MkIX8JCUi2GCz32hFYEQO6oX+yrKvBebfPZsReR8JBHdCDaUunAYbZHqkTK+7s7Lw5avoaJcW1szerXebYO+Ma6O4eCTBqkvOGdImHsu8/FBCLaiBM9BnzpVFCvuPij8y7h71KVJDRzP7HRAUbauQ8X94EYmOSJzplcsrb5h3KrTx41yDoo9Dz+cjLXa68ha+HG56b1BvldxkqAHYqZn2Kurf2UuZZ9XTES7x2UwxU90p7z24tIHVuHrCge6isw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            return publickey;
        }

        public string getPrivateKey()
        {
            string privatekey = string.Empty;
            privatekey = @"<BitStrength>4448</BitStrength><RSAKeyValue><Modulus>wYICuPiqsj90MMtTcJXzxGyNolSCaA+otaz09Dm1TXRLwh7Q7jLV8W7Jy8a25nkU/0SDM3bD9KgrNNgxRZnIB6H2RpZg+8AhdUJ8O1ifHgtdmIQPfBu28hdyGimMzWzBIlssAcMTfdPbtpvEBRegtuoIXbCChaLpnlI/INGkxu3+zBSGYC9JvuXaYRCP8Kd/W1bEN169HLb3SKEI1k5co43ituS517NwimFzjNUpA99A6KHPaddavQsDe6VCR78qpSOYMHObq3ge8u5rcGD9XGtHvTW211UjtzqiIghNIm9g//Tb64NtP+eGpSN/2X5FgzMUEi2Bpa9HiDjJXaR0M+8iu/a38JAkO3PF8Xols3cnsPvZ/OOPyaOI7D0H34zYEH0QVR/JcICm/CNPPpeHc6ilO6hpwa/Jg+5wGELpDvKSl/UMrbLZp0wysE130BY3uDaHgv6Mbjs0Co/2652JF8sxOjYVMtC/HeWBMm1MkIX8JCUi2GCz32hFYEQO6oX+yrKvBebfPZsReR8JBHdCDaUunAYbZHqkTK+7s7Lw5avoaJcW1szerXebYO+Ma6O4eCTBqkvOGdImHsu8/FBCLaiBM9BnzpVFCvuPij8y7h71KVJDRzP7HRAUbauQ8X94EYmOSJzplcsrb5h3KrTx41yDoo9Dz+cjLXa68ha+HG56b1BvldxkqAHYqZn2Kurf2UuZZ9XTES7x2UwxU90p7z24tIHVuHrCge6isw==</Modulus><Exponent>AQAB</Exponent><P>5ufNUyWc85IsQ+yZRf8fnyl7/XOxYknGbt4Ig7uUPIN1MHrrD/UQBVyp4sXohuHg42nIdF3PQ3Lt+uCqr/lfrIeE0VN4cH5/ykmiI/S8USuKEj06p+q2JuYzKMap+suUPMt+5J0G6hge7mml8jvIMJEzHWrmaIX5sEwe+v/NX3beLF5pVIrLPK3vLewQcLR2OceP8udmDwRl3VCaD+bbrheYapGcrc1wOdPwa8MuZxGJR/N+ohpEcz2+A5FtituO7DpNbDeBfcPSFD4rOfbwNjR5qaiGRdHRx8/ygK4kLObC3Cn1+Eo9Az4h/S/TxkSsR43CEYjP+eZvt9msQ+DCR61YAV9pb0sw2yZer5g8BDCqT9xmnnE=</P><Q>1om9nwoqkoxMJOwibYmfaaTnQDSRTRqTdepDoob0JMZqoFhcC0nirIxcknay63X/0rm09UJsB8rGRkLiV6xetZ+o3v6EQszzcOpPMKGfk20a1pWe3dGV6KpuJzXmnxk3JFcvb3ka0W54+10thljAk6nKz0TripcXsPDFXpCl7aEehJtI7u5apmRDy65flHDP5odAxU+20rk0VwBGSJBWPKtgojvkRV/7q/Dx+kdzQYy4nM6AzbsBieGvkiUKIdvI/c8LLPGORlSkXC7QobDqVry8fF1sBauH0WpXBlMWQHGKU4/zNAveoskd3r6825+O53hlQIqp4NT+N3poiJVOF16Gvsu9oMYny+vhXbhErtd79JB9rWM=</Q><DP>EUHNxKMRAdsw17q9EdApatnM3HpjDXd6DxslA8NnJsakYYUuQDkOg3gTclFcOYh0KErlolzIesACLTfRSemXTuup74MPg0jRACtUpN9Lm71nSkmtMpOGHY4i0K9YUNgaMhj7WNarh59Z4HOg5WO2aHrRmSc+JR2uNZDa1+N6U+IsZKCBusHMwrI1J/d2mxXBqDvT9FF6/TBU9J9rhDi6vl4hFAXh8dNiyc+fLk6eDzHuUqROGItiBkLdCqM5zqDuI5WP58CWOvIBp2WmEWT1OvfdB+MCdgFibk6KTze0mG5+rbmtGmth9/YS0Dtc1nqXbZmYoXraIFEqlFD+YOxRWM4Jv8CDvr+d3SMW/ISiJ6YDdIiCWuE=</DP><DQ>RWswdkO93smS4eeehD8h2/dF9JqN4ZsV1/PDitWMLlIdsmCk9+oidJ6+XY4W+uWlr7Pzf+DMQAE3AwklYCUgSDivVeiZN1xF8WV/1kaV8gg9xO2JCFGG5lAvcHSaeSSZmSK08KcJLHdIol1WG8CgH6ezPjoY1TFqsxBVbPH1Ht0hmNr+UIHDx09uOHvl5YxTWU6ugKn4iFrxOq2WEGjT3rG9hQFILcKPFuXSBqAUBUPZgLO5Ldiy+MCUJP/jNW1+rdHO1e4bkVpWDJYBYDB0wzgy7TL1fygvvG1iV2OPMa8LiVps4Yxtr9LP3YFubspEXVWxvZ6gtWV2FNGA/aECMcGebCJU667ytaNPuxmi78g+DbarU+0=</DQ><InverseQ>exKMTvyjKkyOvscHH1SwYi0qM60NlOhhBqgpUcAiKM53bLyLMX2ciQYh0ofx+CrVvDyPBtpYzh9YDmC+0Fp+jRGFulGfiCEE5dNZGKk9C6HXlvjpHfdTYqtpfKigf9s1Enej6FVBVPgLzJnC5+MTQz62itHdHPDlDA9ky0wljdo1QltXLgyoHYCLFVg6NYaGh2wwv+yZ21Ajad43FJUPIOTOdI+Comb51DshHScd/DBftfg1E/TOom28QwF+wr6jRbnF51bZfamCibR3AUTxusQYB/uDfSa8JIK/mJeRudo1JGBjPlJ3UzWPt9PLTGs+1ZT7Hst3fm3rvskEVSDGT/C37xTdPh2YmYdg+I0IdC8D3C7l55I=</InverseQ><D>GwmUYc3048Tz8iFmvjNlhQt52rWeJvYRJ5lL/JfXmkPmlfACV1XpCLvnHD7erWM7qNMk1dsBVDzvFIokkEoFZfOeWoyGboaQ5jZs70nZqbQC1t2U4E1rCXZ3LeqiTs2kSq2cf36HSayBZYlsIR4FCam3k4enJQ73P3TUdzxznowAbvlrMSNKVY7+LVPIGOL+a3+7GNV27P0vnglKF8+JKB0aEV3yDY536g3lvEbIXU8jXZ3GQk6h0goo6WzUzvuJ9Nr9V7+/f3zgLidcAa67l98xfeF0c6/ktqRNpR2t0WLolbrbw5Nwf15VNNu58GSxR7yqUEPleoX8I69zi08AIYWHP+YgG0+4kEoD3VKo0+OROyxlb+0Jm9+LqDdu8tBtHcg5tCDMqZocbmjTTQYRpYnd/+cW5866O8yVkWug2P6dt3bUlqsu5SrOcx1m9ukTMABi6kId5iGgRvjkmQtwKKb3KjnBUrlPTtsUvpO0VzjXSQx6+jXiApakfSxApJTOgOT+UWbJtVrJmgrYRaW5fNGEswJHKu7qQa1C0EOHLAYYr9tLoJdoIAeHc/+Ic5rGyUnIvSgf2LGq1O3zNqI3uzf68Y0jj5gGuwvnTj0H5KJp6L1cDiu8gxm+8n4maCjX1Ykq7UVa9nAP+owKTEWYJL+PZudYtAthtcKQq4CxA7yozup9zhTtTnkfFvjTfIdjf+mBR0LEjD2BQ4jSld23/zK+cNGrzCFyIHR6YQ==</D></RSAKeyValue>";
            return privatekey;
        }


        private const string _pk = "35VkiSLfPV9t51/omcCEqg==";
        public string GetKeys()
        {
            try
            {
                return _pk;
            }
            catch (Exception ex)
            {
                throw new Exception("wrong domain.");
            }
        }

    }
}
