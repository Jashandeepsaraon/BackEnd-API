﻿using System.ComponentModel.DataAnnotations;

namespace WebAPIBudget.Models
{
    public class CreateEditHouseholdBindingModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}