using MediatR;
using Orion.Application.CommonAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Application.CommonAppLayer.UseCases.FileStorageUseCases.UploadImages
{
    public class UploadImagesCommand : IRequest<UrlsDto>
    {
        public ICollection<FileDto> Files { get; set; } = new List<FileDto>();
    }
}
