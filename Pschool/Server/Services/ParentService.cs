using Microsoft.EntityFrameworkCore;
using Pschool.Server.Models;
using Pschool.Shared.DTOs;

namespace Pschool.Services
{
    public class ParentService : IParentService
    {
        private readonly ApplicationContext context;

        public ParentService(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<ParentDto> Delete(int id)
        {
            var parent = context.Parents.FirstOrDefault(x => x.Id == id);
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            context.Parents.Remove(parent);
            await context.SaveChangesAsync();
            return parent.toParentDto();
        }

        public async Task<List<ParentDto>> GetAllParents()
        {
            var parents = (await context.Parents.ToListAsync()).Select(p => p.toParentDto()).ToList();
            return parents;
        }

        public async Task<ParentDto> GetParent(int id)
        {
            var parent = await context.Parents.FirstOrDefaultAsync(p => p.Id == id);
            return parent.toParentDto();
        }

        public async Task<ParentDto> Add(ParentDto parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            var newParent = new Parent()
            {
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                Username = parent.Username,
                Email = parent.Email,
                Phone1 = parent.Phone1,
                WorkPhone = parent.WorkPhone,
                HomePhone = parent.HomePhone,
                HomeAddress = parent.HomeAddress,
            };
            context.Parents.Add(newParent);
            await context.SaveChangesAsync();
            return parent;
        }

        public async Task<ParentDto> Edit(ParentDto parent)
        {
            if (parent == null) throw new ArgumentNullException(nameof(parent));
            if (!context.Parents.Any(p => p.Id == parent.Id)) throw new ArgumentException();
            var newParent = new Parent()
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                Username = parent.Username,
                Email = parent.Email,
                Phone1 = parent.Phone1,
                WorkPhone = parent.WorkPhone,
                HomePhone = parent.HomePhone,
                HomeAddress = parent.HomeAddress,
            };
            context.Update(newParent);
            await context.SaveChangesAsync();
            return parent;
        }
    }
}
