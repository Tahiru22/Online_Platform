﻿namespace Online_Platform.Infrastructure.Configurations
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    public static class FormFileExtensions
    {
        public static async Task<byte[]> ToByteArrayAsync(this IFormFile formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                await formFile.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
