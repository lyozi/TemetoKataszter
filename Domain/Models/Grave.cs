using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Grave
    {
        public long Id { get; set; }
        public short Row { get; set; }
        public short Number { get; set; }
        public short Type { get; set; }

        // public byte[] Image { get; set; } = new byte[0];

        public ICollection<Deceased>? DeceasedList { get; set; }
    }
}