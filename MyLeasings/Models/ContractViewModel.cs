using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasings.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasings.Models
{
    public class ContractViewModel : Contract
    {
        public int OwnerId { get; set; }

        public int PropertyId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Arrendatario")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a lessee.")]
        public int LesseeId { get; set; }

        public IEnumerable<SelectListItem> Lessees { get; set; }
    }
}
