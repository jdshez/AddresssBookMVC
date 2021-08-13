﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AddresssBookMVC.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}
