using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using UserAPI.DB;
using UserAPI.Repository.Interface;

namespace UserAPI.Repository.Service
{
 
        public class GalleryService : IGalleryService
        {
            private readonly UserContext _context;
            private readonly IWebHostEnvironment _webHostEnvironment;

            public GalleryService(UserContext context, IWebHostEnvironment webHostEnvironment)
            {
                _context = context;
                _webHostEnvironment = webHostEnvironment;
            }

            public async Task<List<Gallery>> GetGallery()
            {
                return await _context.Gallery.ToListAsync();
            }

            public async Task<Gallery> PostGallery([FromForm] Gallery gallery, IFormFile imageFile)
            {

                if (imageFile == null || imageFile.Length == 0)
                {
                    throw new ArgumentException("Invalid file");
                }

                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);
                try
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    gallery.ImageURL = fileName;
                    _context.Gallery.Add(gallery);
                    await _context.SaveChangesAsync();
                    return gallery;
                }
                catch (Exception ex)
                {
                    // Rethrow the exception with additional information
                    throw new Exception("Error occurred while posting the room.", ex);
                }
            }

            public async Task<string> DeleteGallery(int id)
            {
                var gallery = await _context.Gallery.FindAsync(id);
                if (gallery == null)
                {
                    return null;
                }

                _context.Gallery.Remove(gallery);
                await _context.SaveChangesAsync();

                return "Image Deleted Successfully!!!";
            }



        }
    
}
