using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyLeasings.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}
