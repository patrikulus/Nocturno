using Microsoft.AspNet.FileProviders;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Net.Http.Headers;
using Nocturno.Data.Context;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using File = Nocturno.Data.Models.File;

namespace Nocturno.Service.Services
{
    public class FileService : IFileService
    {
        private readonly IDbContext _db;
        private readonly IHostingEnvironment _environment;
        private const string UploadsPath = "uploads";

        public FileService(IDbContext db, IHostingEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        private string GetFileExtension(string fileName)
        {
            var parts = fileName.Split('.');
            return parts.Last();
        }

        public async Task UploadFileAsync(ICollection<IFormFile> files)
        {
            var uploads = Path.Combine(_environment.WebRootPath, UploadsPath);
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    await file.SaveAsAsync(Path.Combine(uploads, fileName));
                }
            }
        }

        public void DeleteFile(string name)
        {
            var content = _environment.WebRootFileProvider.GetDirectoryContents(UploadsPath);
            var firstOrDefault = content.FirstOrDefault(x => x.Name == name);
            if (firstOrDefault != null)
            {
                var path = Path.Combine(UploadsPath, name);
                System.IO.File.Delete(path);
            }

        }

        public IEnumerable<File> GetAllFiles()
        {
            List<File> files = new List<File>();
            var content = _environment.WebRootFileProvider.GetDirectoryContents(UploadsPath);
            var types = _db.FileTypes.AsQueryable();
            foreach (var directoryContent in content)
            {
                string extension = GetFileExtension(directoryContent.Name);
                string icon = types.FirstOrDefault(x => x.Extension == extension) != null
                    ? types.FirstOrDefault(x => x.Extension == extension).Icon
                    : "file-o";
                var file = new File
                {
                    Name = directoryContent.Name,
                    Icon = icon,
                    SizeInKiloBytes = directoryContent.Length / 1024,
                    DateModified = directoryContent.LastModified.DateTime
                };
                files.Add(file);
            }

            return files;
        }
    }
}