using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace APBD_11.Models
{
    [Table("Prescription_Medicament")]
    public class PrescriptionMedicamentModel
    {
        [Key]
        public MedicamentModel IdMedicament { get; set; }
        [Key]
        public PrescriptionModel IdPrescription { get; set; }
        public int Dose { get; set; }
        [Required]
        [MaxLength(100)]
        public string Details { get; set; }
    }
}
