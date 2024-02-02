using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;

namespace SportsShop.Application.Services
{
    public class GlobalService : IGlobalService
    {
        public List<SelectListItem> GetStatus()
        {
            return new List<SelectListItem>()
            {
                new ()
                {
                    Value = true.ToString(),
                    Text = "فعال",
                },
                new ()
                {
                    Value = false.ToString(),
                    Text = "غیر فعال",
                },
            };

        }


        public string Upload(IFormFile file, string path, string oldPath = null)
        {
            if (file == null || !file.IsImage())
                return oldPath;

            DeleteFile(oldPath);

            var folderName = $"{Directory.GetCurrentDirectory()}\\wwwroot\\Images\\{path}";

            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            string extension = Path.GetExtension(file.FileName);
            var fileName = $"{Guid.NewGuid() + extension}";

            var filePath = Path.Combine(folderName, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(stream);

            return $"\\Images\\{path}\\{fileName}";
        }

        private void DeleteFile(string path)
        {
            if (path == null)
                return;

            var folderName = $"{Directory.GetCurrentDirectory()}\\wwwroot";
            var filePath = folderName + path;

            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}