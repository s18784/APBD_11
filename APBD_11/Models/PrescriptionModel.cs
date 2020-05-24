using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_11.Models
{
    public class PrescriptionModel
    {
        [Key]
        public int IdPrescription { get; set; }
        [Column(TypeName = "Date")]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime DueDate { get; set; }
        [Required]
        public PatientModel Patient { get; set; }
        [Required]
        public DoctorModel Doctor { get; set; }


    }
}
