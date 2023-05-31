using Pschool.Shared.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Pschool.Server.Models
{
    public class Student : ICloneable
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Set first name please.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Set last name please.")]
        public string LastName { get; set; } = string.Empty;
        public int ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public StudentDto toStudentDto()
        {
            var dto = new StudentDto()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                ParentId = this.ParentId,
                parentName=this.Parent.FirstName+" "+this.Parent.LastName
            };
            return dto;
        }
    }
}
