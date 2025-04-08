using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;


namespace HelpDeskLogsoft.Models
{

    public class TicketMessage
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Ticket")]
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }

        [ForeignKey("Sender")]
        public int SenderId { get; set; }
        public virtual User Sender { get; set; }

        //TODO: czym się różnic required od [Required]
        public required string Message { get; set; }

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        public virtual List<Attachment> Attachments { get; set; } = new List<Attachment>();
    }
}