using Microsoft.AspNet.Http;
using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface IFileService
    {
        void DeleteFile(string name);

        IEnumerable<File> GetAllFiles();

        Task UploadFileAsync(ICollection<IFormFile> files);
    }
}