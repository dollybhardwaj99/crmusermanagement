using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Core.Environment
{

   

    public class MarutiEnvironment
    {
        private  readonly IConfiguration _configuration;

       

        public MarutiEnvironment(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public  string BookingandAppointmentAPIEndPoint
        {
            get => _configuration.GetSection("MarutiBookingandAppointmentAPIEndPoint").Value;
        }

        public string  CustomerAPIEndPoint
        {
            get => _configuration.GetSection("MarutiCustomerAPIEndPoint").Value;
        }
        public string MarutiVehicleAPIEndPoint
        {
            get => _configuration.GetSection("MarutiVehicleAPIEndPoint").Value;
        }
        public string MarutiAPIxapikey
        {
            get => _configuration.GetSection("MarutiAPIxapikey").Value;
        }

        public string MarutiAPIUserAgent
        {
            get => _configuration.GetSection("MarutiAPIUserAgent").Value;
        }
        public string TCSDialerEndPoint
        {
            get => _configuration.GetSection("TCSDialerEndPoint").Value;
        }
        public string TCSBodyUrlEndPoint
        {
            get => _configuration.GetSection("TCSBodyUrlEndPoint").Value;
        }

        public string TCSAuthorizationToken
        {
            get => _configuration.GetSection("TCSAuthorizationToken").Value;
        }
        public string TCSFromNumber
        {
            get => _configuration.GetSection("TCSFromNumber").Value;
        }


        public string MarutiNewAppointmentBookAPI
        {
            get => _configuration.GetSection("MarutiNewAppointmentBookAPI").Value;
        }
        public string MarutiAPIxapikeyNewAppointmentBookAPI
        {
            get => _configuration.GetSection("MarutiAPIxapikeyNewAppointmentBookAPI").Value;
        }




    }
}
