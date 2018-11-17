using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevHack5.Models
{
    public class Review
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public int Stars { get; set; }

        public DateTime Date { get; set; }
    }
}
