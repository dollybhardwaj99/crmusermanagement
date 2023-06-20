using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.LeadManagement.Models.Parameters
{
    public  class SubmitFinanceAppointmentParameter
    {
        [RequiredInt64]
        public long LeadId { get; set; }
        [RequiredInt64]
        public long LeadCREID { get; set; }
        [RequiredInt32]
        public int SMRCallResultDispostionID { get; set; } = 0;
        [RequiredInt32]
        public int SMRCallDispostionID { get; set; }
        public string CCERemark { get; set; } = "";
        public string CustomerVOC { get; set; } = "";
        public int OdometerReading { get; set; } = 0;
        public string CustomerFollowUpNumber { get; set; }
        [RequiredDateTimeWithoutSecond]
        public string SMRAppointmentDate { get; set; }
        public string ServiceAdvisorName { get; set; }
        public string ServiceAdvisorNumber { get; set; }

        public string DriverName { get; set; }
        public string DriverNumber { get; set; }
        public string WorkShopName { get; set; }
        public decimal PartDiscountPercentage { get; set; }
        public decimal PartDiscountAmount { get; set; }
        public decimal LabourDiscountPercentage { get; set; }
        public decimal LabourDiscountAmount { get; set; }
        public bool IsPickUp { get; set; } = false;
        public string PickUpPoint { get; set; }
        public string ServicePoint { get; set; }
        public string DropPoint { get; set; }
        [RequiredTimeSpan]
        public string PreferredPickUpTime { get; set; }
        [RequiredTimeSpan]
        public string PreferredDropTime { get; set; }
        [RequiredInt32]
        public int SMRAppointmentTypeId { get; set; }
        [Required]
        public string slotCode { get; set; }
        [Required]
        public string slotTimeCode { get; set; }
        [Required]
        public string regNo { get; set; }
        public string MMSvehicleNo { get; set; }
        [Required]
        public string currentSaCode { get; set; }
        public int pickUpTypeId { get; set; }
        public string pickUpLoc { get; set; }
        public string dropLoc { get; set; }
        public string pickUpRemarks { get; set; }
        public string remarkNonPrevSa { get; set; }
        public string demandJobs { get; set; }
        public string dropDriver { get; set; }


    }

    public class SubmitGlobalSMRAppointmentParameter
    {
        [RequiredInt64]
        public long LeadCREID { get; set; }
        [RequiredInt32]
        public int SMRCallResultDispostionID { get; set; } = 0;
        [RequiredInt32]
        public int SMRCallDispostionID { get; set; }
        public string CCERemark { get; set; } = "";
        public string CustomerVOC { get; set; } = "";
        public int OdometerReading { get; set; } = 0;
        public string CustomerFollowUpNumber { get; set; }
        [RequiredDateTimeWithoutSecond]
        public string SMRAppointmentDate { get; set; }
        public string ServiceAdvisorName { get; set; }
        public string ServiceAdvisorNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverNumber { get; set; }
        public string WorkShopName { get; set; }
        public decimal PartDiscountPercentage { get; set; }
        public decimal PartDiscountAmount { get; set; }
        public decimal LabourDiscountPercentage { get; set; }
        public decimal LabourDiscountAmount { get; set; }
        public bool IsPickUp { get; set; } = false;
        public string PickUpPoint { get; set; }
        public string ServicePoint { get; set; }
        public string DropPoint { get; set; }
        [RequiredTimeSpan]
        public string PreferredPickUpTime { get; set; }
        [RequiredTimeSpan]
        public string PreferredDropTime { get; set; }
        [RequiredInt32]
        public int SMRAppointmentTypeId { get; set; }
        [Required]
        public string slotCode { get; set; }
        [Required]
        public string slotTimeCode { get; set; }
        [Required]
        public string regNo { get; set; }
        public string MMSvehicleNo { get; set; }
        [Required]
        public string currentSaCode { get; set; }
        public int pickUpTypeId { get; set; }
        public string pickUpLoc { get; set; }
        public string dropLoc { get; set; }
        public string pickUpRemarks { get; set; }
        public string remarkNonPrevSa { get; set; }
        public string demandJobs { get; set; }
        public string dropDriver { get; set; }

        public long LSVOCID { get; set; }
        public int LCustomerCategoryId { get; set; }
        public string LCustomerName { get; set; }
        public string LVIN { get; set; }
        public string LVehicleModel { get; set; }
        public int LSMRServiceTypeID { get; set; }
        public int LDealerID { get; set; }
        public int LVehicleTypeID { get; set; }
        public string ServiceDueWorkshopName { get; set; }
        [RequiredDate]
        public string LastServiceDate { get; set; }
        public int LastServiceTypeID { get; set; }
        public string LastServiceWorkShop { get; set; }
        public string LastServiceAdvisorName { get; set; }
        public int LChannelId { get; set; }
        public int LFuelTypeId { get; set; }
        public int LLastodometerreading { get; set; }
        public int LLastBillAmount { get; set; }
        [RequiredDate]
        public string LDeliveryDate { get; set; }
        public string LPreferdWorkShopName { get; set; }
        public int LLeadCSMID { get; set; }
        public string LPinCode { get; set; }
        public string LYearOfManufacturing { get; set; }
        [RequiredDate]
        public string LVehicleSaleDate { get; set; }
        public string LMobileSmr { get; set; }
        public string LMobileSrv { get; set; }


    }

    public class SubmitGlobalSMRAppointmentRequestParameter
    {
        [RequiredInt64]
        public long LeadCREID { get; set; }
        [RequiredInt32]
        public int SMRCallResultDispostionID { get; set; } = 0;
        [RequiredInt32]
        public int SMRCallDispostionID { get; set; }
        public string CCERemark { get; set; } = "";
        public string CustomerVOC { get; set; } = "";
        public int OdometerReading { get; set; } = 0;
        public string CustomerFollowUpNumber { get; set; }
        [RequiredDateTimeWithoutSecond]
        public string SMRAppointmentDate { get; set; }
        public string ServiceAdvisorName { get; set; }
        public string ServiceAdvisorNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverNumber { get; set; }
        public string WorkShopName { get; set; }
        public decimal PartDiscountPercentage { get; set; }
        public decimal PartDiscountAmount { get; set; }
        public decimal LabourDiscountPercentage { get; set; }
        public decimal LabourDiscountAmount { get; set; }
        public bool IsPickUp { get; set; } = false;
        public string PickUpPoint { get; set; }
        public string ServicePoint { get; set; }
        public string DropPoint { get; set; }
        [RequiredTimeSpan]
        public string PreferredPickUpTime { get; set; }
        [RequiredTimeSpan]
        public string PreferredDropTime { get; set; }
        [RequiredInt32]
        public int SMRAppointmentTypeId { get; set; }
        [Required]
        public string slotCode { get; set; }
        [Required]
        public string slotTimeCode { get; set; }
        [Required]
        public string regNo { get; set; }
        public string MMSvehicleNo { get; set; }
        [Required]
        public string currentSaCode { get; set; }
        public int pickUpTypeId { get; set; }
        public string pickUpLoc { get; set; }
        public string dropLoc { get; set; }
        public string pickUpRemarks { get; set; }
        public string remarkNonPrevSa { get; set; }
        public string demandJobs { get; set; }
        public string dropDriver { get; set; }

        public long LSVOCID { get; set; }
        public int LCustomerCategoryId { get; set; }
        public string LCustomerName { get; set; }
        public string LVIN { get; set; }
        public string LVehicleModel { get; set; }
        public int LSMRServiceTypeID { get; set; }
        public int LDealerID { get; set; }
        public int LVehicleTypeID { get; set; }
        public string ServiceDueWorkshopName { get; set; }
        [RequiredDate]
        public string LastServiceDate { get; set; }
        public int LastServiceTypeID { get; set; }
        public string LastServiceWorkShop { get; set; }
        public string LastServiceAdvisorName { get; set; }
        public string LChannelId { get; set; }
        public int LFuelTypeId { get; set; }
        public int LLastodometerreading { get; set; }
        public int LLastBillAmount { get; set; }
        [RequiredDate]
        public string LDeliveryDate { get; set; }
        public string LPreferdWorkShopName { get; set; }
        public int LLeadCSMID { get; set; }
        public string LPinCode { get; set; }
        public string LYearOfManufacturing { get; set; }
        [RequiredDate]
        public string LVehicleSaleDate { get; set; }
        public string LMobileSmr { get; set; }
        public string LMobileSrv { get; set; }


    }


}




