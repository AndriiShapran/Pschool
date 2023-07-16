using Pschool.Shared.DTOs;
namespace Pschool.Services
{
    public interface INotiService
    {
        Task<List<NotiDto>> GetAllNotis();
    }
}
