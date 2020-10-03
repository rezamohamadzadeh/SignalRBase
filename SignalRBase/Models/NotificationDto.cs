using System;
using System.ComponentModel.DataAnnotations;

namespace SignalRBase.Models
{
    public class NotificationDto
    {        
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public string Sender { get; set; }

        public string Url { get; set; }
    }
}
