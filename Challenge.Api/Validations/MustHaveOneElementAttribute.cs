using System;
using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.Validations
{
    public class MustHaveOneElementAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var array = value as Array;
            if (array != null)
            {
                return array.Length > 0;
            }
            return false;
        }
    }
}