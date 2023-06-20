using NUnit.Framework;
using Moq;
using Infrastructure.Abstraction.Repository;
using Core.Context;
using System.Collections.Generic;
using Core.Models;
using System.Threading.Tasks;
using System.Linq;

using Infrastructure.Implementation.Repository;
using Microsoft.EntityFrameworkCore;
using CRM.Core.LeadManagement.Models.DTO;
using Serilog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Infrastructure.Abstraction.Common;

namespace CRM.Services.LeadManagement.Test
{
    [TestFixture]
    public class SMRLeadControllerTest
    {
        ApplicationDapperContext applicationDapperContext;
       
        private ILogger Logger = Log.Logger;
       
        public IUnitOfWork MockUnitOfWork;

        public Mock<IUnitOfWork> mockUnitOfWork;
       
        private IConfiguration _configuration;
        IHelper _iHelper;
        [SetUp]
        public void Setup()
        {
            //Arrange
          

        }


        [Test(Description = "Get All SMRLead")]
        public void TestGetAllSMRLead()
        {
            //Arrange
           
        }

    }
}
