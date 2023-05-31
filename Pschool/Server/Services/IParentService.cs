using Pschool.Shared.DTOs;

namespace Pschool.Services
{
    public interface IParentService
    {
        Task<List<ParentDto>> GetAllParents();
        Task<ParentDto> GetParent(int id);
        Task<ParentDto> Add(ParentDto parent);
        Task<ParentDto> Edit(ParentDto parent);
        Task<ParentDto> Delete(int id);
    }
}
