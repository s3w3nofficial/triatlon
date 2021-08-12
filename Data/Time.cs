using System;
using System.ComponentModel.DataAnnotations;

namespace triatlon.Data 
{
    public class Time 
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Value { get; set; }
    }
}