
using System.ComponentModel.DataAnnotations;

namespace Pschool.Shared.DTOs
{
    public class NotiDto : ICloneable
    {
        public NotiDto() { }
        public int Id { get; set; }
        public string? Header { get; set; } = string.Empty;
        public string? Body { get; set; } = string.Empty;
        public int? ParentId { get; set; } = 0;
        public int? StudentId { get; set; } = 0;
        public bool IsAaaaaa { get; set; }=false;
        public string? RelatedObject { get; set; } = string.Empty;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
