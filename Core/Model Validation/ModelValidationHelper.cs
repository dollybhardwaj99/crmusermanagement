
using CRM.Core.LeadManagement.Models.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Core.Model_Validation
{
    public static class ModelValidationHelper
    {

        public static void ValidateNullCheck(params (object propertyName, string message)[] args)
        {
            string errorMessage = ValidationConstants.InvalidRequestMessage;
            if (args == null)
            {
                throw new ArgumentNullException(errorMessage);
            }

            foreach (var (propertyName, message) in args)
            {
                if (propertyName == null)
                {
                    string errMessage =
                        string.IsNullOrEmpty(message) ? errorMessage : message;
                    throw new ValidationException(new ValidationResult(errMessage, new List<string>() { }));
                }
                else if (propertyName is string)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(propertyName)))
                    {
                        string errMessage =
                            string.IsNullOrEmpty(message) ? errorMessage : message;
                        throw new ValidationException(new ValidationResult(errMessage, new List<string>() { }));
                    }
                }
            }
        }

        /// <summary>
        /// Checks for Regular Expression and Null
        /// </summary>
        /// <param name="propertyValuePairs"></param>
        public static void Validate(params (string propertyName, string propertyValue, string message)[] propertyValuePairs)
        {
            string propertyName;
            string propertyValue;
            string errorMessage = ValidationConstants.InvalidRequestMessage;

            foreach (var propertyValuePair in propertyValuePairs)
            {
                propertyName = propertyValuePair.propertyName;
                propertyValue = propertyValuePair.propertyValue;

                if (string.IsNullOrEmpty(propertyValue))
                {
                    string errMessage =
                        string.IsNullOrEmpty(propertyValuePair.message) ? errorMessage : propertyValuePair.message;
                    throw new ValidationException(new ValidationResult(errMessage, new List<string>() { }));
                }
                if (!Regex.IsMatch(propertyValue, propertyName))
                {
                    string errMessage =
                        string.IsNullOrEmpty(propertyValuePair.message) ? errorMessage : propertyValuePair.message;
                    throw new ValidationException(new ValidationResult(errMessage, new List<string>() { }));
                }
            }
        }

        public static void ValidateOptional(params (string propertyName, string propertyValue, string message)[] propertyValuePairs)
        {
            string propertyName;
            string propertyValue;
            string errorMessage = ValidationConstants.InvalidRequestMessage;

            foreach (var propertyValuePair in propertyValuePairs)
            {
                propertyName = propertyValuePair.propertyName;
                propertyValue = propertyValuePair.propertyValue;

                if (!string.IsNullOrEmpty(propertyValue))
                {
                    if (!Regex.IsMatch(propertyValue, propertyName))
                    {
                        string errMessage =
                            string.IsNullOrEmpty(propertyValuePair.message) ? errorMessage : propertyValuePair.message;
                        throw new ValidationException(new ValidationResult(errMessage, new List<string>() { }));
                    }
                }
            }
        }


        public static string TimeSlotTime(string propertyValue)
        {
            try
            {

                if (!String.IsNullOrWhiteSpace(propertyValue))
                {

                    var Start = propertyValue.Substring(0, 2);
                    var EndTime = propertyValue.Substring(2);


                    DateTime tsStart = DateTime.ParseExact("01-05-2022 " + Start + ":00:00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime tsEnd = DateTime.ParseExact("01-05-2022 " + EndTime + ":00:00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    return tsStart.ToString("hh") + "-" + tsEnd.ToString("hh tt");

                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }

        }

        public static string TimeSlotTimeTime(string propertyValue)
        {
            try
            {

                if (!String.IsNullOrWhiteSpace(propertyValue))
                {

                    var Start = propertyValue.Split('-')[0].Substring(0, 2) + ":" + propertyValue.Split('-')[0].Substring(2);
                    var EndTime = propertyValue.Split('-')[1].Substring(0, 2) + ":" + propertyValue.Split('-')[1].Substring(2);


                    DateTime tsStart = DateTime.ParseExact("01-05-2022 " + Start + ":00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime tsEnd = DateTime.ParseExact("01-05-2022 " + EndTime + ":00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    return tsStart.ToString("hh:mm tt") + "-" + tsEnd.ToString("hh:mm tt");

                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }

        }


        public static double IGSTRateSet(double? IGSTRate,double? CGSTRate,double? SGSTRate )
        {
            try
            {
                IGSTRate = ConvertDouble(IGSTRate);
                CGSTRate = ConvertDouble(CGSTRate);
                SGSTRate = ConvertDouble(SGSTRate) >0 ? SGSTRate : 0;

                if (IGSTRate==0)
                {
                    IGSTRate = CGSTRate + SGSTRate;
                }

                return IGSTRate.Value;


            }
            catch
            {
                return 0;
            }

        }

        public static decimal GSTAmount( double? GSTRate,string Qunatity,double? Rate)
        {
            try
            {
              var   Rates = ConvertDecimal(Rate);
                if (Rates > 0 && ConvertDecimal(Qunatity) > 0 && ConvertDecimal(GSTRate)>0)
                {
                    var  Total= Rates * ConvertDecimal(Qunatity);
                    if (Total > 0)
                    {
                        string Val= ((Total * ConvertDecimal( GSTRate)) / 100.00m).ToString();
                        var RetunValue = Math.Round(Convert.ToDecimal(Val),0);
                        return RetunValue;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }


            }
            catch
            {
                return 0;
            }

        }


        public static decimal GSTAmountWithTotal(double? GSTRate, string Qunatity, double? Rate)
        {

            try
            {
                var Rates = ConvertDecimal(Rate);
                if (Rates > 0 && ConvertDecimal(Qunatity) > 0 && ConvertDecimal(GSTRate) > 0)
                {
                    var Total = Rates * ConvertDecimal(Qunatity);
                    if (Total > 0)
                    {
                        string Val = ((Total+(Total * ConvertDecimal(GSTRate)) / 100.00m)).ToString();
                        var RetunValue = Math.Round(Convert.ToDecimal(Val), 0);
                        return RetunValue;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }


            }
            catch
            {
                return 0;
            }


        }




        public static string GetservicePattern(string soldDate, string BillDate, string serviceType)
        {
            string ReturnResponce = "";
            try
            {

                if (!String.IsNullOrWhiteSpace(soldDate) && !String.IsNullOrWhiteSpace(BillDate) && !String.IsNullOrWhiteSpace(serviceType))
                {




                    DateTime SoldDate = DateTime.Parse(soldDate);

                    if (serviceType.ToUpper().Contains("FREE") && serviceType.Contains("1"))
                    {

                        if (DateTime.Parse(BillDate) <= SoldDate.AddDays(30).Date)
                        {
                            ReturnResponce = "OnTime";

                        }
                        else
                        {
                            ReturnResponce = "Late";
                        }
                    }
                    else
                        if (serviceType.ToUpper().Contains("FREE") && serviceType.Contains("2"))
                    {

                        if (DateTime.Parse(BillDate) <= SoldDate.AddDays(180).Date)
                        {
                            ReturnResponce = "OnTime";

                        }
                        else
                        {
                            ReturnResponce = "Late";
                        }
                    }
                    else
                        if (serviceType.ToUpper().Contains("FREE") && serviceType.Contains("3"))
                    {

                        if (DateTime.Parse(BillDate) <= SoldDate.AddDays(365).Date)
                        {
                            ReturnResponce = "OnTime";

                        }
                        else
                        {
                            ReturnResponce = "Late";
                        }
                    }
                    else
                        if (serviceType.ToUpper().Contains("PAID"))
                    {

                        if (DateTime.Parse(BillDate) <= SoldDate.AddDays(370).Date)
                        {
                            ReturnResponce = "OnTime";

                        }
                        else
                        {
                            ReturnResponce = "Late";
                        }

                    }

                }
              
            }
            catch
            {
              
            }
            return ReturnResponce;
        }




        public static void ValidateDateCompareSmallLarze(string FirstDate, string secondDate, string message)
        {

            string errorMessage = message.Length > 0 ? message : "Invalid From Date  to date ";

            if (FirstDate.Length > 0 || secondDate.Length > 0)
            {
                if (ConvertStringToDate(FirstDate) > ConvertStringToDate(secondDate))
                {
                    throw new ValidationException(new ValidationResult(errorMessage, new List<string>() { }));
                }
            }


        }

        public static void ValidateAppointmentParameter(SubmitFinanceAppointmentParameter RequestParameter)
        {
            string ErrorMessage = "";
            if (RequestParameter.pickUpTypeId > 0)
            {
                ErrorMessage+= RequestParameter.DriverName.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + " Driver name required" : " Driver name required") : "";
                ErrorMessage += RequestParameter.DriverNumber.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + "Driver number required" : "Driver number required") : "";
                ErrorMessage += RequestParameter.PickUpPoint.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + "Pickup point required" : "Pickup point required") : "";
                ErrorMessage += RequestParameter.PreferredPickUpTime.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + "Preferred pickup time required" : "Preferred pickup time required") : "";
                ErrorMessage += RequestParameter.PreferredDropTime.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + "Preferred drop time required" : "Preferred drop time required") : "";
                ErrorMessage += RequestParameter.pickUpLoc.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + "pickup Loc required" : "pickup Loc required") : "";
                ErrorMessage += RequestParameter.dropLoc.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + " drop loc time required" : "drop loc time required") : "";
                ErrorMessage += RequestParameter.dropDriver.Length == 0 ? (ErrorMessage.Length > 0 ? "| " + "drop Driver required" : "drop Driver required") : "";

            }

            if (ErrorMessage.Length > 0)
            {
                throw new ValidationException(new ValidationResult(ErrorMessage, new List<string>() { }));
            }
            



        }


        public static void ValidateNumber64(Int64 Number, string propertyName)
        {


            string errorMessage = "Invalid " + propertyName + " Please input valid value";

            if (Number == 0)
            {

                throw new ValidationException(new ValidationResult(errorMessage, new List<string>() { }));

            }




        }


        public static void ValidateNumberint(int Number, string propertyName)
        {


            string errorMessage = "Invalid " + propertyName + " Please input valid value";

            if (Number == 0)
            {

                throw new ValidationException(new ValidationResult(errorMessage, new List<string>() { }));

            }


        }

        public static DateTime ConvertStringToDate(string str)
        {
            if (str.ToLower().Contains('-'))
            {
                return DateTime.ParseExact(str, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            }
            else if (str.ToLower().Contains('.'))
            {
                return DateTime.ParseExact(str, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }

            else
            {
                return DateTime.ParseExact(str, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }

        public static Boolean ConvertStringToDateCheckDate(string str)
        {
            try
            {
                if (str.ToLower().Contains('-'))
                {
                    DateTime.ParseExact(str, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                }
                else if (str.ToLower().Contains('.'))
                {
                    DateTime.ParseExact(str, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                }

                else
                {
                    DateTime.ParseExact(str, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }




        public static Boolean ConvertStringToDateCheckDateTime(string str)
        {
            try
            {
                if (str.ToLower().Contains('-'))
                {

                    DateTime.ParseExact(str, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

                }
                else if (str.ToLower().Contains('.'))
                {
                    DateTime.ParseExact(str, "dd.MM.yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                }

                else
                {
                    DateTime.ParseExact(str, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static Boolean ConvertStringToDateCheckDateTimeWithoutSecond(string str)
        {
            try
            {
                if (str.ToLower().Contains('-'))
                {

                    DateTime.ParseExact(str, "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture);

                }
                else if (str.ToLower().Contains('.'))
                {
                    DateTime.ParseExact(str, "dd.MM.yyyy hh:mm tt", CultureInfo.InvariantCulture);
                }

                else
                {
                    DateTime.ParseExact(str, "dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static Boolean ConvertStringToDateCheckTimeSpanWithoutSecond(string str)
        {
            try
            {
                if (str.ToLower().Contains('-'))
                {

                    DateTime.ParseExact(str, "hh:mm tt", CultureInfo.InvariantCulture);

                }
                else if (str.ToLower().Contains('.'))
                {
                    DateTime.ParseExact(str, "hh:mm tt", CultureInfo.InvariantCulture);
                }

                else
                {
                    DateTime.ParseExact(str, "hh:mm tt", CultureInfo.InvariantCulture);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }




        public static double ConvertDouble(object str)
        {
            try
            {
                return Convert.ToDouble(str);
            }
            catch
            {
                return 0;
            }
        }
        public static decimal ConvertDecimal(object str)
        {
            try
            {
                return Convert.ToDecimal(str);
            }
            catch
            {
                return 0m;
            }
        }

        public static string   ConvertString(object str)
        {
            try
            {
                return str.ToString();
            }
            catch
            {
                return "" ;
            }
        }

        public static int ConvertInt(object str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                return 0;
            }
        }


        public static int ConvertIntTime(object str)
        {
            try
            {
                return Convert.ToInt32(str.ToString().Split('-')[0]);
            }
            catch
            {
                return 0;
            }
        }





        public static bool ConvertBoolean(object str)
        {
            try
            {
                return Convert.ToBoolean(str);
            }
            catch
            {
                return false;
            }
        }



    }
}
