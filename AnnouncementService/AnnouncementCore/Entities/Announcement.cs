﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementCore.Entities
{
    public class Announcement
    {
        public long ID { set; get; }
        public long OwnerID { set; get; }
        public bool IsSold { set; get; }
        public long CarID { set; get; }
        public string Description { set; get; } = string.Empty;
        public double Price { set; get; }
    }
}
