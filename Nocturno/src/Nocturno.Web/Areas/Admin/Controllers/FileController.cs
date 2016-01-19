using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Microsoft.Net.Http.Headers;
using Nocturno.Data.Context;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using File = Nocturno.Data.Models.File;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class FileController : Controller
    {
        private IFileService _fileService;
        private IHostingEnvironment _environment;

        public FileController(IFileService fileService, IHostingEnvironment environment)
        {
            _fileService = fileService;
            _environment = environment;
        }

        // GET: File
        public IActionResult Index()
        {
            var content = _environment.WebRootFileProvider.GetDirectoryContents("uploads");
            return View(_fileService.GetAllFiles());
        }

        [HttpPost]
        public async Task<IActionResult> Index(ICollection<IFormFile> files)
        {
            await _fileService.UploadFileAsync(files);
            return View(_fileService.GetAllFiles());
        }

        //// GET: File/Details/5
        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    File file = _fileService.GetAllFiles().Single(m => m.Id == id);
        //    if (file == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    string text = "Ala ma kota";
        //    var chars = text.ToCharArray().OrderBy(x => (int)x);
        //    foreach (var charr in chars)
        //    {
        //        Console.WriteLine(charr.ToString());
        //    }
        //    {
        //    }

        //    return View(file);
        //}

        //// GET: File/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: File/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(File file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Files.Add(file);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(file);
        //}

        //// GET: File/Edit/5
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    File file = _context.Files.Single(m => m.Id == id);
        //    if (file == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(file);
        //}

        //// POST: File/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(File file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(file);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(file);
        //}

        //// GET: File/Delete/5
        //[ActionName("Delete")]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    File file = _context.Files.Single(m => m.Id == id);
        //    if (file == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(file);
        //}

        //// POST: File/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    File file = _context.Files.Single(m => m.Id == id);
        //    _context.Files.Remove(file);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}