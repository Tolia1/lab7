using Microsoft.AspNetCore.Mvc;
using lab7.Models;

namespace lab7.Controllers
{
    public class FileController : Controller
    {
        public IActionResult DownloadFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DownloadFile(FileData fileData)
        {
            if (ModelState.IsValid)
            {
                string content = $"UserName: {fileData.UserName}\nUserSurname: {fileData.UserSurname}";

                byte[] fileBytes = System.Text.Encoding.UTF8.GetBytes(content);

                return File(fileBytes, "text/plain", fileData.Filename + ".txt");
            }
            return View("DownloadFile", fileData);
        }
    }
}