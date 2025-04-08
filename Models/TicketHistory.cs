using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskLogsoft.Models
{

    public class TicketHistory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Ticket")]
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }

        [Required]
        public string Action { get; set; } // Opis zmiany (np. "Zmiana statusu na Closed")

        [ForeignKey("PerformedBy")]
        public int PerformedById { get; set; }
        public virtual User PerformedBy { get; set; } // Kto wykonał akcję

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }

}
