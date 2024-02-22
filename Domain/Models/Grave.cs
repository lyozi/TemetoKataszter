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
        public int Row { get; set; }
        public int Number { get; set; }
        public int Type { get; set; }
    }
}
