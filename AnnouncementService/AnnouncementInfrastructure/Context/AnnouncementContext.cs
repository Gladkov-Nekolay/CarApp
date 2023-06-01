using AnnouncementCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementInfrastructure.Context
{
    public class AnnouncementContext: DbContext
    {
        public AnnouncementContext(DbContextOptions<AnnouncementContext> options) : base(options)
        {
        } 
        public DbSet<Announcement> Announcements { get; set; }

    }
}
