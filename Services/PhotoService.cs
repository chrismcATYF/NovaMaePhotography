using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NovaMaePhotography.Models;
using NovaMaePhotography.Services;
using NovaMaePhotography.Services.Interfaces;

namespace NovaMaePhotography.Services
{
    public class PhotoService : IPhoto
    {
        protected readonly ApplicationDbContext _context;

        public PhotoService()
        {
            _context = new ApplicationDbContext();
        }

        public List<Photos> GetAllPhotos()
        {
            return _context.Photos.ToList();
        }

        public Photos GetPhoto(int id)
        {
            return _context.Photos.FirstOrDefault(a => a.Id == id);
        }
    }
}