using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HelpDeskLogsoft.Models
{
    public enum LogType
    {
        Info,
        Warning,
        Error
    }

    public class SystemLog
    {
        [Key]
        public int Id { get; set; }

        public LogType Type { get; set; } = LogType.Info;

        [Required]
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("RelatedUser")]
        public int? RelatedUserId { get; set; }
        public virtual User? RelatedUser { get; set; }
    }

}
