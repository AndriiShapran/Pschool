using Pschool.Shared.DTOs;

namespace Pschool.Server.Models
{
    public class Noti
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public int? ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }
        public bool IsAaaaaa { get; set; }
        public NotiDto toNotiDto()
        {
            var dto = new NotiDto()
            {
                Id = this.Id,
                Header = this.Header,
                Body = this.Body,
                ParentId = this.ParentId,
                StudentId = this.StudentId,
                IsAaaaaa = this.IsAaaaaa,
            };
            if(ParentId != null)
            {
                dto.RelatedObject=this.Parent.FirstName+" "+this.Parent.LastName;
            }
            else
            {
                if (StudentId != null)
                {
                    dto.RelatedObject = this.Student.FirstName + " " + this.Student.LastName;
                }
                else
                {
                    dto.RelatedObject=string.Empty;
                }
            }
            return dto;
        }
    }
}
