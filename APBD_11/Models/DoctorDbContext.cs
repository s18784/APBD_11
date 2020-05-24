using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_11.Models
{
    public class DoctorDbContext : DbContext 
    {

        public DbSet<DoctorModel> Doctors { get; set; }

        public DbSet<MedicamentModel> Medicaments { get; set; }

        public DbSet<PatientModel> Patients { get; set; }

        public DbSet<PrescriptionModel> Prescriptions { get; set; }

        public DoctorDbContext() { }

        public DoctorDbContext(DbContextOptions o)
        :base(o){

        }
    }
}
