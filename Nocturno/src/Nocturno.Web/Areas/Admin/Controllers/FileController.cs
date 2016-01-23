using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Nocturno.Service.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FileController : Controller
    {
        private readonly IFileService _fileService;
        private IHostingEnvironment _environment;

        public FileController(IFileService fileService, IHostingEnvironment environment)
        {
            _fileService = fileService;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_fileService.GetAllFiles());
        }

        [HttpPost]
        public async Task<IActionResult> Index(ICollection<IFormFile> files)
        {
            await _fileService.UploadFileAsync(files);
            return View(_fileService.GetAllFiles());
        }

        public IActionResult Delete(string id)
        {
            return View("Delete", id);
        }

        public IActionResult DeleteConfirmed(string id)
        {
            _fileService.DeleteFile(id);
            return View("Index", _fileService.GetAllFiles());
        }
    }
}