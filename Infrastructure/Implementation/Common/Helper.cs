using Infrastructure.Abstraction.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Infrastructure.Implementation.Common
{
    public class Helper : IHelper
    {
        public void CopyFilestoRequistionLocation(string RequisitionId)
        {
            var folderName = Path.Combine("Resources", "Images"); 
            var Imagepath = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            string[] filePaths = Directory.GetFiles(Imagepath);
            foreach (var file in filePaths)
            {
                string filename = Path.GetFileName(file);

                //Do your job with "file"  
                string Directorypath = Imagepath + "\\" + RequisitionId;
                string filepath = Imagepath + "\\" + RequisitionId + "\\" + filename;

                if (!Directory.Exists(Directorypath))
                    Directory.CreateDirectory(Directorypath);
                else
                {
                    string[] insidefilePath = Directory.GetFiles(Directorypath);
                    //folder is created, check for file initials and delete accordingly
                    if (filename.Contains("kmStart"))
                    {
                        //check inside directory path for file name starting with kmStart anddelete it 
                        foreach (var insidefile in insidefilePath)
                        {
                            if (Path.GetFileName(insidefile).Contains("kmStart"))
                            {
                                File.Delete(insidefile.ToString());
                                break;
                            }
                        }
                    }
                    else
                    {
                        //check inside directory path for file name starting with kmEnd anddelete it 
                        foreach (var insidefile in insidefilePath)
                        {
                            if (Path.GetFileName(insidefile).Contains("kmEnd"))
                            {
                                File.Delete(insidefile.ToString());
                                break;
                            }
                        }
                    }
                }

                if (!File.Exists(filepath))
                {
                    File.Copy(file, filepath);
                }
                //delete file 
                File.Delete(file.ToString());
            }
        }
        public  DateTime ConvertStringToDate(string str)
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


        public Boolean ConvertStringToDateCheckDate(string str)
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
            catch {
                return false;
            }
        }

        public DateTime ConvertStringToDateTime(string str)
        {
            if (str.ToLower().Contains('-'))
            {
                return DateTime.ParseExact(str, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            }
            else if (str.ToLower().Contains('.'))
            {
                return DateTime.ParseExact(str, "dd.MM.yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            }

            else
            {
                return DateTime.ParseExact(str, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            }
        }

        public DateTime ConvertStringToDateTimeWhoutSecond(string str)
        {
            if (str.ToLower().Contains('-'))
            {
                return DateTime.ParseExact(str, "dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture);
            }
            else if (str.ToLower().Contains('.'))
            {
                return DateTime.ParseExact(str, "dd.MM.yyyy hh:mm tt", CultureInfo.InvariantCulture);
            }

            else
            {
                return DateTime.ParseExact(str, "dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
            }
        }

        public object DefaultValueModal(object obj)
        {

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {

                prop.SetValue(obj, Convert.ChangeType(getvalidatorDataType(prop.PropertyType.Name), prop.PropertyType), null);

            }
            return obj;
        }

    public  object getvalidatorDataType(string str)
        {
            if (str == "Int32")
            {
                return 0;
            }
            else if (str == "Int64")
            {
                return 0;
            }
            else if (str == "String")
            {
                return "test";
            }
            else if (str == "Boolean")
            {
                return false;
            }
            else if (str == "Decimal")
            {
                return 0m;
            }
            else if (str == "DateTime")
            {
                return DBNull.Value;
            }

            else
            {
                return "";
            }

        }



        public  string TimeSlotTime(string propertyValue)
        {
            try
            {

                if (!String.IsNullOrWhiteSpace(propertyValue))
                {

                    var Start = propertyValue.Substring(0, 2);
                    var EndTime = propertyValue.Substring(2);


                    DateTime tsStart = DateTime.ParseExact("01-05-2022 " + Start + ":00:00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime tsEnd = DateTime.ParseExact("01-05-2022 " + EndTime + ":00:00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    return tsStart.ToString("HHmm") + "-" + tsEnd.ToString("HHmm");

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
    }
}
