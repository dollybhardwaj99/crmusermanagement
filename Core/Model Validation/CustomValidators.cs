using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Core.Model_Validation;
using System.Collections;

namespace Core.Models
{

    public class RequiredInt64 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                var Value = value.ToString();

                if (Convert.ToInt64(Value) == 0)
                    return new ValidationResult("This field is required");
                else
                    return ValidationResult.Success;
            }
            catch
            {
                return new ValidationResult("This field is required");
            }

        }
    }

    public class RequiredInt32 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                var Value = value.ToString();

                if (Convert.ToInt32(Value) == 0)
                    return new ValidationResult("This field is required");
                else
                    return ValidationResult.Success;
            }
            catch
            {
                return new ValidationResult("This field is required");
            }

        }
    }


    public class RequiredDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                var Value = value.ToString();
                if (Value.ToUpper() == "STRING")
                {
                    return new ValidationResult("Invalid Date format");
                }
                else if (value.ToString().Length == 0)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    if (ModelValidationHelper.ConvertStringToDateCheckDate(Value))
                    {
                        return ValidationResult.Success;
                    }

                    else
                    {
                        return new ValidationResult("Invalid date format");
                    }
                }
            }
            catch
            {
                return new ValidationResult("Invalid date format");
            }

        }
    }



    public class RequiredDateMust : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                var Value = value.ToString();
                if (Value.ToUpper() == "STRING" || Value.ToUpper().Length==0)
                {
                    return new ValidationResult("Invalid Date format");
                }
                else if (value.ToString().Length == 0)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    if (ModelValidationHelper.ConvertStringToDateCheckDate(Value))
                    {
                        return ValidationResult.Success;
                    }

                    else
                    {
                        return new ValidationResult("Invalid date format");
                    }
                }
            }
            catch
            {
                return new ValidationResult("Invalid date format");
            }

        }
    }



    public class RequiredDateTime : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                var Value = value.ToString();
                if (Value.ToUpper() == "STRING")
                {
                    return new ValidationResult("Invalid date time  format dd/MM/yyyy hh:mm:ss tt");
                }
                else if (value.ToString().Length == 0)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    if (ModelValidationHelper.ConvertStringToDateCheckDateTime(Value))
                    {
                        return ValidationResult.Success;
                    }

                    else
                    {
                        return new ValidationResult("Invalid date time  format dd/MM/yyyy hh:mm:ss tt");
                    }
                }
            }
            catch
            {
                return new ValidationResult("Invalid date time  format dd/MM/yyyy hh:mm:ss tt");
            }

        }

    }
    public class RequiredDateTimeWithoutSecond : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            { 
                var Value = value.ToString();
                if (Value.ToUpper() == "STRING")
                {
                    return new ValidationResult("Invalid date time  format dd/MM/yyyy hh:mm tt");
                }
                else if (value.ToString().Length == 0)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    if (ModelValidationHelper.ConvertStringToDateCheckDateTimeWithoutSecond(Value))
                    {
                        return ValidationResult.Success;
                    }

                    else
                    {
                        return new ValidationResult("Invalid date time  format dd/MM/yyyy hh:mm tt");
                    }
                }
            }
            catch
            {
                return new ValidationResult("Invalid date time  format dd/MM/yyyy hh:mm tt");
            }

        }



    }

    public class RequiredTimeSpan : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                var Value = value.ToString();
                if (Value.ToUpper() == "STRING")
                {
                    return new ValidationResult("Invalid date time  format hh:mm tt");
                }
                else if (value.ToString().Length == 0)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    if (ModelValidationHelper.ConvertStringToDateCheckTimeSpanWithoutSecond(Value))
                    {
                        return ValidationResult.Success;
                    }

                    else
                    {
                        return new ValidationResult("Invalid date time  format  hh:mm tt");
                    }
                }
            }
            catch
            {
                return new ValidationResult("Invalid date time  format  hh:mm tt");
            }

        }

    }


    public class RequiredDrive : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                var Value = value.ToString();
                if (Value.ToUpper() == "STRING")
                {
                    return new ValidationResult("Invalid date time  format hh:mm tt");
                }
                else if (value.ToString().Length == 0)
                {
                    return ValidationResult.Success;

                }
                else
                {
                    if (ModelValidationHelper.ConvertStringToDateCheckTimeSpanWithoutSecond(Value))
                    {
                        return ValidationResult.Success;
                    }

                    else
                    {
                        return new ValidationResult("Invalid date time  format  hh:mm tt");
                    }
                }
            }
            catch
            {
                return new ValidationResult("Invalid date time  format  hh:mm tt");
            }

        }

    }




    public class RequiredCustomList : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                var list = value as IEnumerable;
                if (list != null && list.GetEnumerator().MoveNext())
                {
                  return  ValidationResult.Success;
                } else
                {
                    return new ValidationResult("Invalid object");
                }

              
            }
            catch 
            {
                return  new  ValidationResult("Invalid object");
            }
        }
    }

    public class RequiredCustomObject : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                
                if (value != null )
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Invalid object");
                }


            }
            catch
            {
                return new ValidationResult("Invalid object");
            }
        }
    }

   
}