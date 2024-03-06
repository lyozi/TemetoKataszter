﻿using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace WebAPI.DTOs
{
    public class DeceasedsMessagesDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfDeath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Message> MessageList { get; set; } = new List<Message>();
        public short NrOfFlowers { get; set; }
        public short NrOfWreaths { get; set; }
        public short NrOfCandles { get; set; }

        public static DeceasedsMessagesDTO FromDeceased(Deceased deceased)
        {
            var nrOfWreaths = deceased.MessageList.Count(m => m.ItemType == 1);
            var nrOfFlowers = deceased.MessageList.Count(m => m.ItemType == 2);
            var nrOfCandles = deceased.MessageList.Count(m => m.ItemType == 3);

            return new DeceasedsMessagesDTO
            {
                Id = deceased.Id,
                Name = deceased.Name,
                DateOfDeath = deceased.DateOfDeath,
                DateOfBirth = deceased.DateOfBirth,
                MessageList = deceased.MessageList,
                NrOfFlowers = (short)nrOfFlowers,
                NrOfWreaths = (short)nrOfWreaths,
                NrOfCandles = (short)nrOfCandles
            };
        }
    }
}
