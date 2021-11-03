using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Tblpizzalist
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
