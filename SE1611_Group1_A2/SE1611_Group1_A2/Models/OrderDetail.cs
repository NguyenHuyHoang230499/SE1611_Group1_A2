﻿using System;
using System.Collections.Generic;

namespace SE1611_Group1_A2.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int AlbumId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
