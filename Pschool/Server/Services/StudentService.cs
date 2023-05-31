using Microsoft.EntityFrameworkCore;
using Pschool.Server.Models;
using Pschool.Shared.DTOs;

namespace Pschool.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationContext context;

        public StudentService(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<StudentDto> Delete(int id)
        {
            var student= context.Students.FirstOrDefault(x => x.Id == id);
            if (student == null) throw new ArgumentNullException(nameof(student));
            var res = student.toStudentDto();
            context.Students.Remove(student);
            await context.SaveChangesAsync();
            return res;
        }

        public async Task<List<StudentDto>> GetAllStudents()
        {
            var students = (await context.Students.ToListAsync()).Select(p => p.toStudentDto()).ToList();
            return students;
        }

        public async Task<StudentDto> GetSudent(int id)
        {
            var student=await context.Students.FirstOrDefaultAsync(s => s.Id == id);
            return student.toStudentDto();
        }

        public async Task<StudentDto> Add(StudentDto student)
        {
            if (student == null) throw new ArgumentNullException(nameof(student));
            var newStudent = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                ParentId = student.ParentId
            };
            context.Students.Add(newStudent);
            await context.SaveChangesAsync();
            return student;
        }

        public async Task<StudentDto> Edit(StudentDto student)
        {
            if(student == null) throw new ArgumentNullException(nameof(student));
            if (!context.Students.Any(s => s.Id == student.Id)) throw new ArgumentException();
            var newStudent = new Student()
            {
                Id= student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                ParentId = student.ParentId
            };
            context.Update(newStudent);
            await context.SaveChangesAsync();
            return student;
        }
    }
}
