using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Enum
{
    public enum RequisitionTypeEnums
    {
       Vehicle=1,
       Fuel=2,
       Generator = 3
    }

    public enum FuelTypeEnums
    {
        Petrol = 1,
        Diesel = 2,
        CNG = 3,
        LPG = 4,
        Electric = 5
    }

    public enum VehicleTypeEnums
    {
        New = 1,
        Old = 2,
        Demo=3,
        OfficeUse=4
    }

    public enum ApprovalStatusEnums
    {
        Draft = 1,
        Approve= 2,
        Reject = 3,
        Reopen = 4,
        Close = 5
    }

    public enum ProcessType
    {
        SMR,
        MI,
        PSF
    }
    public enum RoleType
    {
        CCM=1,
        CRE=2
    }

}
