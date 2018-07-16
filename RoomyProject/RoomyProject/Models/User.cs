using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoomyProject.Models
{
    public class User
    {
        [Required(ErrorMessage ="Le champ nom est obligatoire")]
        [Display(Name="Nom")]
        public string Lastname { get; set; }

        [Display(Name = "Prenom")]
        public string Firstname { get; set; }

        [Display(Name = "Mail")]
        public string Mail { get; set; }

        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ConfirmedPassword")]
        [DataType(DataType.Password)]
        public string ConfirmedPassword { get; set; }
    }
}