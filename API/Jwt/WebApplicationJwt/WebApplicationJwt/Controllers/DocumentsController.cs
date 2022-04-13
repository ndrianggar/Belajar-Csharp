﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using WebApplicationJwt.DbContext;
using WebApplicationJwt.Models;

namespace WebApplicationJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment; // tambahkan ini

        public DocumentsController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: api/Documents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Document>>> GetDocuments()
        {
            return await _context.Documents.ToListAsync();
        }

        // GET: api/Documents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Document>> GetDocument(int id)
        {
            var document = await _context.Documents.FindAsync(id);

            if (document == null)
            {
                return NotFound();
            }

            return document;
        }

        // PUT: api/Documents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocument(int id, Document document)
        {
            if (id != document.DocumentId)
            {
                return BadRequest();
            }

            _context.Entry(document).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Documents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Document>> PostDocument(Document document)
        {
            _context.Documents.Add(document);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocument", new { id = document.DocumentId }, document);
        }

        [HttpPost]
        [Route("upload")]
        public async Task<ActionResult> Upload(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var rootPath = Path.Combine(_environment.ContentRootPath, "Resources", "Documents");

            if (!Directory.Exists(rootPath))
                Directory.CreateDirectory(rootPath);

            foreach (var file in files)
            {
                var filePath = Path.Combine(rootPath, file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    var document = new Document
                    {
                        FileName = file.FileName,
                        ContentType = file.ContentType,
                        FileSize = file.Length
                    };

                    await file.CopyToAsync(stream);

                    _context.Documents.Add(document);
                    await _context.SaveChangesAsync();
                }

            }

            return Ok(new { count = files.Count, size });
        }
    
        [HttpPost]
        [Route("download/{id}")]
        public async Task<ActionResult> Download(int id)
        {
            var provider = new FileExtensionContentTypeProvider();

            var document = await _context.Documents.FindAsync(id);

            if (document == null)
                return NotFound();


            var file = Path.Combine(_environment.ContentRootPath, "Resource", "Documents", document.FileName);

            string contentType;
            if (!provider.TryGetContentType(file, out contentType))
            {
                contentType = "application/octet-stream";
            }
            byte[] fileBytes;
            if (System.IO.File.Exists(file))
            {
                fileBytes = System.IO.File.ReadAllBytes(file);
            }
            else
            {
                return NotFound();
            }

            return File(fileBytes, contentType, document.FileName);
        }


        // DELETE: api/Documents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocument(int id)
        {
            var document = await _context.Documents.FindAsync(id);
            if (document == null)
            {
                return NotFound();
            }

            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocumentExists(int id)
        {
            return _context.Documents.Any(e => e.DocumentId == id);
        }
    }
}
