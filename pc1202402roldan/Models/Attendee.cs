using System;
namespace pc1202402roldan.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string AttendeeName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}