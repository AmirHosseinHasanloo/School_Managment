using DataLayer.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IStudentRepository : IDisposable
    {
        Task<IEnumerable<Student>> getAll();
        Task<IEnumerable<StudentCrime>> getCrimesByStudentId(int studentId);
        string GetCrimeByStudentId(int studentId);
        bool EditCrime(int crimeId,string crime);
        Task<bool> AddStudent(Student student);
        bool Delete(int id);
        Task<DataLayer.Models.Student> GetStudent(int id);
        bool EditStudent(Student student);
        Task<IEnumerable<Student>> Filter(string parameter);
        Task<IEnumerable<Student>> BestStudents();
        Task<IEnumerable<Student>> BadStudents();
    }
}
