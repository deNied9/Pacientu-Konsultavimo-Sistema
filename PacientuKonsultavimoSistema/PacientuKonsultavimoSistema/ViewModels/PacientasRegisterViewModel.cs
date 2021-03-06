﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacientuKonsultavimoSistema.Models
{
    public class PacientasRegisterViewModel
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName{ get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime year { get; set; }
        [Required]
        public string idCode { get; set; }
        public string number { get; set; }
        [Required]
        public string sex { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string livingPlace { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Compare("password", ErrorMessage = "Slaptažodis nesutampa.")]
        public string confirmPassword { get; set; }
    }
}
