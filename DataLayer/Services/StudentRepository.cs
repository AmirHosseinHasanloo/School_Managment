using DataLayer.Repositories;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
namespace DataLayer.Services
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public async Task<bool> AddStudent(Student student)
        {
            try
            {
                _context.Student.Add(student);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<IEnumerable<Student>> BadStudents()
        {
            return await _context.Student
                 .Include(s => s.StudentCrimes).Where(s => s.StudentCrimes.Count() != 0).ToListAsync();
        }

        public async Task<IEnumerable<Student>> BestStudents()
        {
            return await _context.Student
                  .Include(s => s.StudentCrimes)
                  .Where(s => s.StudentCrimes.Count() == 0).ToListAsync();
        }

        public bool Delete(int id)
        {
            var find = _context.Student.Find(id);

            if (find != null)
            {
                _context.Remove(find);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public bool EditCrime(int crimeId, string crime)
        {
            DataLayer.Models.StudentCrime Studentcrime =
                _context.StudentCrime.Single(s => s.Id == crimeId);

            if (Studentcrime != null)
            {
                Studentcrime.Crime = crime;
                return true;
            }

            return false;
        }

        public bool EditStudent(Student student)
        {
            try
            {
                _context.Entry(student).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Student>> Filter(string parameter)
        {
            return await _context.Student
                 .Where(s => s.LastName.Contains(parameter)
                 || s.NationalityCode.Contains(parameter)).ToListAsync();
        }

        public async Task<IEnumerable<Student>> getAll()
        {
            return await _context.Student.ToListAsync();
        }

        public string GetCrimeByStudentId(int studentId)
        {
            return _context.StudentCrime.Single(s => s.StudentId == studentId).Crime;
        }

        public async Task<IEnumerable<StudentCrime>> getCrimesByStudentId(int studentId)
        {
            return await _context.StudentCrime.Where(s => s.StudentId == studentId).ToListAsync();
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _context.Student.SingleAsync(s => s.Id == id);
        }
    }
}
