using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasings.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasings.Models
{
    public class PropertyViewModel : Property
    {
        public int OwnerId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Tipo Propiedad")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a property type.")]
        public int PropertyTypeId { get; set; }

        public IEnumerable<SelectListItem> PropertyTypes { get; set; }
    }
}
