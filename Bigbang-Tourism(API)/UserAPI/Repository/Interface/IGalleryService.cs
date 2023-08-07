using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;

namespace UserAPI.Repository.Interface
{
    public interface IGalleryService
    {
        public Task<List<Gallery>> GetGallery();

        public Task<Gallery> PostGallery([FromForm] Gallery gallery, IFormFile imageFile);
        public Task<string> DeleteGallery(int id);


    }
}
