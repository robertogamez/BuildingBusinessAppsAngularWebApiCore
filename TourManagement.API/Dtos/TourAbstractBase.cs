﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourManagement.API.Dtos
{
    public abstract class TourAbstractBase : IValidatableObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "required|Title is required.")]
        [MaxLength(200, ErrorMessage = "maxlength|Title is too long.")]
        public virtual string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!(StartDate < EndDate))
            {
                yield return new ValidationResult("startDateBeforeEndDate|The start should be smaller tnah the end date",
                    new[] { "Tour" });
            }
        }
    }
}
