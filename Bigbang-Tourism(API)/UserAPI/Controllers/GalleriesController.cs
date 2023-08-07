using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using UserAPI.DB;
using UserAPI.Repository.Interface;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleriesController : ControllerBase
    {

        private readonly IGalleryService _context;

        public GalleriesController(IGalleryService context)
        {
            _context = context;
        }

        // GET: api/Galleries
        [HttpGet]
        public async Task<List<Gallery>> GetGallery()
        {
            return await _context.GetGallery();
        }



        // POST: api/Galleries
        [HttpPost]
        public async Task<Gallery> PostGallery([FromForm] Gallery gallery, IFormFile imageFile)
        {
            return await _context.PostGallery(gallery, imageFile);
        }

        // DELETE: api/Galleries/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteGallery(int id)
        {
            return await _context.DeleteGallery(id);
        }
    }
}