using Microsoft.EntityFrameworkCore;
using Pschool.Shared.DTOs;

namespace Pschool.Services
{
    public class NotiService : INotiService
    {
        private readonly ApplicationContext context;

        public NotiService(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<List<NotiDto>> GetAllNotis()
        {
            var notis = (await context.Notis.ToListAsync()).Select(p => p.toNotiDto()).ToList();
            return notis;
        }
    }
}
