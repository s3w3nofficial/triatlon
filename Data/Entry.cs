using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace triatlon.Data
{
    public class Entry 
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Time> Times { get; set; }
    }
}