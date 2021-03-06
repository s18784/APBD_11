﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_11.Models
{
    public class PatientModel
    {

        [Key]
        public int IdPatient{ get; set; }
        [MaxLength(100)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(100)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(100)]
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Birthdate { get; set; }
    }
}
