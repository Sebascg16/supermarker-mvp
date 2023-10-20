using Microsoft.Identity.Client;
using Supermarket__mvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket__mvp.Presenters.Common
{
    internal class ModelDataValidation
    {
        public void validate(object model)
        {
          
                string errorMessage = "";
                List<ValidationResult> validationResults = new List<ValidationResult>();
                ValidationContext validationContext = new ValidationContext(model);
                bool isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);

                if (isValid == false)
                {
                    foreach (var item in validationResults)
                    {
                        errorMessage += item.ErrorMessage + "\n";
                    }
                    throw new Exception(errorMessage);
                }


        }   
    }
}
