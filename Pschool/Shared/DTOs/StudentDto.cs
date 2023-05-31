using System.ComponentModel.DataAnnotations;

namespace Pschool.Shared.DTOs
{
    public class StudentDto:ICloneable
    {
        public StudentDto()
        {
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Set first name please.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Set last name please.")]
        public string LastName { get; set; } = string.Empty;
        public string parentName { get; set; } = string.Empty;
        public int ParentId { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
