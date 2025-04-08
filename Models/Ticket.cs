using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace HelpDeskLogsoft.Models
{
    public enum TicketStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed,
        //TODO: wystawiona faktura
    }

    public enum TicketPriority
    {
        Low,
        Medium,
        High,
        Critical
    }

    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public required string Subject { get; set; }

        public string? Description { get; set; }

        public required TicketStatus Status { get; set; } = TicketStatus.Open;

        public required TicketPriority Priority { get; set; } = TicketPriority.Medium;

        public decimal Hours { get; set; }

        [ForeignKey("CreatedBy")]
        public required User CreatedBy { get; set; }

        [ForeignKey("AssignedTo")]
        public virtual User? AssignedTo { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public virtual List<TicketMessage> Messages { get; set; } = new List<TicketMessage>();
        public virtual List<Attachment> Attachments { get; set; } = new List<Attachment>();
        public virtual List<TicketHistory> History { get; set; } = new List<TicketHistory>();
    }

}
