using AnnouncementCore.Entities;
using AnnouncementCore.Interfaces;
using AnnouncementCore.Models;
using AnnouncementInfrastructure.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementInfrastructure.Repository
{
    public class AnnouncementEFRepository : IAnnouncementRepository
    {
        private protected readonly AnnouncementContext _context = null!;
        private protected readonly IMapper mapper;

        public AnnouncementEFRepository (AnnouncementContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        public async Task AddAnnouncementAsync(Announcement announcement)
        {
            await _context.Announcements.AddAsync(announcement);
            _context.SaveChanges();
        }

        public async Task DeleteAnnouncementAsync(long ID)
        {
            Announcement announcementForDelete = await _context.Announcements.FindAsync(ID);
            if (announcementForDelete != null)
            {
                _context.Announcements.Remove(announcementForDelete);
                await _context.SaveChangesAsync();
            }
            else 
            {
                //Throw Exeption?
            }
        }

        public async Task<List<Announcement>> GetAllAsync(PaginationSettingModel paginationSettiongsModel)
        {
            return await _context.Announcements
                .OrderBy(p=>p.ID)
                .Skip((paginationSettiongsModel.PageNumber - 1) * paginationSettiongsModel.PageSize)
                .Take(paginationSettiongsModel.PageSize)
                .ToListAsync();
        }

        public async Task<Announcement> GetByIDAnnouncementAsync(long ID)
        {
            return await _context.Announcements.FirstOrDefaultAsync(o=>o.ID==ID);
        }

        public async Task<List<Announcement>> GetForAccountAnnouncementAsync(PaginationSettingModel paginationSettiongsModel, long ID)
        {
            return await _context.Announcements
                .OrderBy(p=>p.ID)
                .Where(a=>a.OwnerID==ID)
                .Skip((paginationSettiongsModel.PageNumber - 1) * paginationSettiongsModel.PageSize)
                .Take(paginationSettiongsModel.PageSize)
                .ToListAsync();
        }

        public async Task UpdateAnnouncementAsync(Announcement announcement)
        {
            Announcement UpdatedAnnouncement = await _context.Announcements.FindAsync(announcement.ID);
            if (UpdatedAnnouncement == null)
            {
                throw new KeyNotFoundException();
            }
            UpdatedAnnouncement = announcement;
            await _context.SaveChangesAsync();
        }
    }
}
