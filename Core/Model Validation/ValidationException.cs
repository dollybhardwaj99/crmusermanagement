using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Model_Validation
{
    public class ValidationException : Exception
    {
        public ValidationResult validationResult { get; set; }

        public ValidationException(ValidationResult validationResult) : base(validationResult?.ErrorMessage)
        {
            this.validationResult = validationResult;
        }


    }
}
