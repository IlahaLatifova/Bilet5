using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Extensions
{
    public static class FileExtensions
    {
        public static bool IsTrueContent(this IFormFile formFile)
        {
            if (formFile.ContentType.Contains("image"))
            {
                return true;
            }
            return false;
        }

        public static bool IsValidLength(this IFormFile formFile)
        {
            if (formFile.Length <= 2 * 1024 * 1024)
            {
                return true;
            }
            return false;
        }
        public static string CreateUrl(this IFormFile formFile, string env, string folderPath)
        {
            string imageUrl = " ";
            if (formFile.FileName.Length >= 100)
            {
                imageUrl = $"{Guid.NewGuid().ToString()}{formFile.FileName.Substring(formFile.FileName.Length - 64, 64)}";
            }
            else
            {
                imageUrl = $"{Guid.NewGuid().ToString()}{formFile.FileName}";
            }
            string imagePath = Path.Combine(env, folderPath, imageUrl);
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Create))
            {
                formFile.CopyTo(fileStream);
            }
            return imageUrl;
        }
        public static void DeleteExistFile(string env, string folderPath, string imageUrl)
        {
            string imagePath = Path.Combine(env, folderPath, imageUrl);
            if (File.Exists(imagePath)) 
            { 
                File.Delete(imagePath); 
            }
        }
    }
}