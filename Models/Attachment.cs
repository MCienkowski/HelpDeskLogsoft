using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskLogsoft.Models
{


    public class Attachment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; } // Nazwa pliku

        [Required]
        public string FilePath { get; set; } // Ścieżka do pliku (lokalnie lub w chmurze)

        [Required]
        [StringLength(100)]
        public string MimeType { get; set; } // Typ MIME (np. "image/png", "application/pdf")

        [ForeignKey("UploadedBy")]
        public int UploadedById { get; set; }
        public virtual User UploadedBy { get; set; } // Kto dodał plik

        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        // Powiązania z e-mailami i ticketami (opcjonalne)
        [ForeignKey("RelatedTicketMessage")]
        public int? RelatedTicketMessageId { get; set; }
        public virtual TicketMessage? RelatedTicketMessage { get; set; }

        [ForeignKey("RelatedEmail")]
        public int? RelatedEmailId { get; set; }
        public virtual Email? RelatedEmail { get; set; }
    }

}
