using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;

namespace Jalmid_Media.Helpers.Extension
{
    namespace Innowave.Helpers.Extension
    {
        public static class Extension
        {
            public static bool CheckImage(this IFormFile file)
            {
                return file.ContentType.Contains("image");
            }

            public static bool CheckImageSize(this IFormFile file, int size)
            {
                return file.Length / 1024 > size;
            }

            public static string SaveImage(this IFormFile file, IWebHostEnvironment _env, string folder)
            {
                string fileName = Guid.NewGuid() + file.FileName;
                string path = Path.Combine(_env.WebRootPath, folder, fileName);


                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return fileName;
            }



        }
    }
}
