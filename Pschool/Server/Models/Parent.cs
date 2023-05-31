using Pschool.Shared.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Pschool.Server.Models
{
    public class Parent : ICloneable
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Set first name please.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Set last name please.")]
        public string LastName { get; set; } = string.Empty;
        public string? Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Set email please.")]
        public string Email { get; set; } = string.Empty;
        public string? HomeAddress { get; set; } = string.Empty;
        public string? Phone1 { get; set; } = string.Empty;
        public string? WorkPhone { get; set; } = string.Empty;
        public string? HomePhone { get; set; } = string.Empty;
        public virtual List<Student> Students { get; set; } = new List<Student>();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public ParentDto toParentDto()
        {
            var dto = new ParentDto()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Username = this.Username,
                Email = this.Email,
                HomeAddress = this.HomeAddress,
                Phone1 = this.Phone1,
                WorkPhone = this.WorkPhone,
                HomePhone = this.HomePhone,
                StudentNumber = this.Students.Count()
            };
            return dto;
        }
    }
}
