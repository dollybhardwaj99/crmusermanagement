using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Abstraction.Common
{
    public interface IHelper
    {
        void CopyFilestoRequistionLocation(string RequistionID);

        public DateTime ConvertStringToDate(string str);

        public Boolean ConvertStringToDateCheckDate(string str);

        public DateTime ConvertStringToDateTime(string str);

        public DateTime ConvertStringToDateTimeWhoutSecond(string str);

         object getvalidatorDataType(string str);
        object DefaultValueModal(object obj);
        public string TimeSlotTime(string propertyValue);




    }
}
