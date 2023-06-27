using Core.Context;
using CRM.Core.LeadManagement.Models.DTO;
using CRM.Core.LeadManagement.Models.DTO.MASTERDTO;
using CRM.Core.LeadManagement.Models.Parameters;
using CRM.Core.LeadManagement.Models.Parameters.MASTERParmeter;
using CRM.Infrastructure.LeadManagement.Abstraction.Repository;
using Dapper;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.LeadManagement.Implementation.Repository
{
    public  class MasterRepository :IMasterRepository
    {


        private ApplicationDapperContext _context;

        public MasterRepository(ApplicationDapperContext dapContext)
        {
            this._context = dapContext;
        }



        public async Task<IEnumerable<MasterDTO>> GetStudentDetailsMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_student",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }


        public async Task<IEnumerable<MasterDTO>> GetStudentDetailsIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_studentID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        
    }
        
        public async Task<IEnumerable<MasterDTO>> GetclasssubjectMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                

               var data = connection.Query<MasterDTO>("Sp_classsubject",
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

        public async Task<IEnumerable<MasterDTO>> GetclasssubjectIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_classsubjectID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        public async Task<IEnumerable<MasterDTO>> GetbookMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {


                var data = connection.Query<MasterDTO>("Sp_bookMaster",
                      commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterDTO>> GetbookIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_bookmasterID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        public async Task<IEnumerable<MasterDTO>> GetclassMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {


                var data = connection.Query<MasterDTO>("Sp_classMaster",
                       commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }

       
        public async Task<IEnumerable<MasterDTO>> GetclassIDMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_classmasterid",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        public async Task<IEnumerable<MasterDTO>> GetclassIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_classID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        
        public async Task<IEnumerable<MasterDTO>> GetexamMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {


                var data = connection.Query<MasterDTO>("Sp_exammaster",
                       commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterDTO>> GetexamIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_exammasterID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        public async Task<IEnumerable<MasterDTO>> GethouseMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {


                var data = connection.Query<MasterDTO>("Sp_houseMaster",
                       commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterDTO>> GethouseIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_housemasterID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        public async Task<IEnumerable<MasterDTO>> GetschoolMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {


                var data = connection.Query<MasterDTO>("Sp_schoolMaster",
                       commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterDTO>> GetschoolIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_schoolmasterID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        public async Task<IEnumerable<MasterDTO>> GetsessionMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {


                var data = connection.Query<MasterDTO>("Sp_sessionmaster",
                       commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }
        public async Task<IEnumerable<MasterDTO>> GetsessionIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_sessionmasterID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
        public async Task<updatedto> PutclassMaster(updateclassmaster parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                

              var  data = connection.Query<updatedto>("Sp_updateClassMaster",
                    param: new { parameter.id, parameter.FFFFF  },
                     commandType: CommandType.StoredProcedure).FirstOrDefault();
                return data;
            }
           

        }


        public async Task<IEnumerable<MasterDTO>> GetstudentMaster()
        {
            using (var connection = _context.CreateConnectionFinance())
            {


                var data = connection.Query<MasterDTO>("Sp_studentmaster",
                       commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }



        public async Task<IEnumerable<MasterDTOMessage>> submitExammaster(SubmitExammasterparmeter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTOMessage> data = new List<MasterDTOMessage>();

                data = connection.Query<MasterDTOMessage>("sp_insertExammaster",
                    param: new { parameter.Sessionid, parameter.Examname },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }
    


        public async Task<IEnumerable<MasterDTO>> GetstudentIdMaster(MasterIDparameter parameter)
        {
            using (var connection = _context.CreateConnectionFinance())
            {
                List<MasterDTO> data = new List<MasterDTO>();

                data = connection.Query<MasterDTO>("Sp_studentID",
                    param: new { parameter.id },
                     commandType: CommandType.StoredProcedure).ToList();
                return data;
            }

        }

       
    }
}
