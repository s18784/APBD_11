using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_11.Models
{
    public class MyDbContext : DbContext 
    {

        public DbSet<DoctorModel> Doctors { get; set; }

        MyDbContext() { }

        MyDbContext(DbContextOptions o)
        :base(o){

        }
    }
}
