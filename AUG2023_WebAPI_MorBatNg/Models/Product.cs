﻿using System;
using System.Collections.Generic;

namespace AUG2023_WebAPI_MorBatNg.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Qty { get; set; }
        public string Category { get; set; } = null!;
    }
}
