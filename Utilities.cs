using System;
using System.Globalization;

namespace SMT_Web_Form
{
    public class Utilities
    {
        public string GetConnectionString()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/SMT Web Form");
            string ConnString = rootWebConfig.ConnectionStrings.ConnectionStrings["Conn_String"].ConnectionString;
            return ConnString;

        }

        public string VerifyDate(string strDateToVerify)
        {
            string strDateVerify;
            strDateVerify = string.Empty;

            string[] strSplitRes = strDateToVerify.Split('-');
            string strMonth, strYear;
            int intDate, intMonth;

            if (strSplitRes.GetUpperBound(0)==2)
            {
                intDate = Convert.ToInt32(strSplitRes[0]);
                strYear = strSplitRes[2];
                strMonth = strSplitRes[1];

                if (intDate>=1 && intDate<=31)
                {
                    if (strYear.Length==4 || strYear.Length==2)
                    {
                        try
                        {
                            intMonth = DateTime.ParseExact(strMonth, "MMM", CultureInfo.CurrentCulture).Month;
                            if (intMonth != 0)
                            {
                                strDateVerify = "Date Verified";
                            }

                        }
                        catch
                        {
                            intMonth = DateTime.ParseExact(strMonth, "MMMM", CultureInfo.CurrentCulture).Month;
                            if (intMonth != 0)
                            {
                                strDateVerify = "Date Verified";
                            }
                            else
                            {
                                strDateVerify = "Invalid Month - Please Enter Date in valid Format (21-Jan-2017 or 21-January-2017)";
                            }

                        }
                        
                        
                    }
                    else
                    {
                        strDateVerify = "Please Enter Year as either 2017 or 17";
                    }
                }
                else
                {
                    strDateVerify = "Please Enter a date between 1 and 31";
                }

            }
            else
            {
                strDateVerify = "Please Enter Date in valid Format (21-Jan-2017 or 21-January-2017). Please also include the '-' ";
            }



            return strDateVerify;

        }
    }
    

}