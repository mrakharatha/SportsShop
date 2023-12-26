using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace SportsShop.Application.Helpers
{
  

    public static class FileUploader 
    {
	    public static string Upload(this IFormFile file, string path, string oldPath=null)
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

	    private static void DeleteFile(string path)
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