using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orion.API.Controllers.SeedWork;
using Orion.Application.CommonAppLayer.DTOs;
using Orion.Application.CommonAppLayer.UseCases.FileStorageUseCases.UploadImages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : OrionBaseController
    {
        [HttpPost("Images")]
        public async Task<IActionResult> UploadImages(IList<IFormFile> formFiles)
        {
            var uploadImagesCommand = new UploadImagesCommand();

            foreach (var formFile in formFiles)
            {
                var file = new FileDto
                {
                    Content = formFile.OpenReadStream(),
                    Name = formFile.FileName,
                    ContentType = formFile.ContentType,
                };
                uploadImagesCommand.Files.Add(file);
            }

            var response = await Mediator.Send(uploadImagesCommand);

            return Ok(response);
        }
    }
}
