using Pschool.Shared.DTOs;

namespace Pschool.Services
{
    public interface IStudentService
    {
        Task<List<StudentDto>> GetAllStudents();
        Task<StudentDto> GetSudent(int id);
        Task<StudentDto> Add(StudentDto student);
        Task<StudentDto> Edit(StudentDto student);
        Task<StudentDto> Delete(int id);
    }
}
