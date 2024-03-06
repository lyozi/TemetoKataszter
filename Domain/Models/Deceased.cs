﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Deceased
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfDeath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Message>? MessageList { get; set; }
    }
}
