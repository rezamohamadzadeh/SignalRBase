using System;
using System.ComponentModel.DataAnnotations;

namespace SignalRBase.Models
{
    public class NotificationDto
    {
        public NotificationDto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }


        public string Url { get; set; }
    }
}
