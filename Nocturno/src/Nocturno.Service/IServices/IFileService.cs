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
        Task UploadFileAsync(ICollection<IFormFile> files);

        IEnumerable<File> GetAllFiles();
    }
}