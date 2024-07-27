using DataLayer.GenericRepository;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class StudentContext : DbContext, IDisposable
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Students_DB;User Id=sa;Password=asadasad;Trusted_Connection=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> Student { get; set; }
        private IStudentRepository _studentRepository;

        public IStudentRepository studentRepository
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository(this);
                }
                return _studentRepository;
            }
        }

        public DbSet<StudentCrime> StudentCrime { get; set; }

        private GenericRepository<StudentCrime> _studentCrimeRepository;

        public GenericRepository<StudentCrime> studentCrimeRepository
        {
            get
            {
                if (_studentCrimeRepository == null)
                {
                    _studentCrimeRepository = new GenericRepository<StudentCrime>(this);
                }

                return _studentCrimeRepository;
            }
        }
        public DbSet<StudentLate> StudentLate { get; set; }

        private GenericRepository<StudentLate> _studentLateRepository;

        public GenericRepository<StudentLate> studentLateRepository
        {
            get
            {
                if (_studentLateRepository == null)
                {
                    _studentLateRepository = new GenericRepository<StudentLate>(this);
                }

                return _studentLateRepository;
            }
        }

        public void Save()
        {
            this.SaveChanges();
        }

        public void Disposing()
        {
            base.Dispose();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

