using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace HelpDeskLogsoft.Models
{
    public class Email
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string MessageId { get; set; } // Unikalne ID wiadomości (np. z nagłówka e-maila)

        [Required]
        [StringLength(255)]
        public string Sender { get; set; } // Adres e-mail nadawcy

        [Required]
        public List<string> Recipients { get; set; } = new List<string>(); // Lista odbiorców

        [Required]
        [StringLength(255)]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; } // Treść wiadomości (może być HTML)

        public DateTime? ReceivedAt { get; set; } // Data odbioru wiadomości (dla e-maili przychodzących)
        public DateTime? SentAt { get; set; } // Data wysłania (dla e-maili wychodzących)

        public virtual List<Attachment> Attachments { get; set; } = new List<Attachment>();

        [ForeignKey("LinkedTicket")]
        public int? LinkedTicketId { get; set; } // Opcjonalnie powiązanie z ticketem
        public virtual Ticket? LinkedTicket { get; set; }
    }

}
