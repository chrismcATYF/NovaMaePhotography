using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovaMaePhotography.Models;

namespace NovaMaePhotography.Services.Interfaces
{
    public interface IPhoto
    {
        List<Photos> GetAllPhotos();
        Photos GetPhoto(int id);

    }
}
