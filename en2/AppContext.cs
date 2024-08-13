using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en2
{
    public class AppContext :Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Doctor> Doctors { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Treatment> Treatments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Treatment>()
                .HasOne(t => t.Doctor)
                .WithMany(d => d.Treatments)
                .HasForeignKey(t => t.DoctorId);
        }
    }

}
