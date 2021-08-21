using MediatR;
using Orion.Application.CommonAppLayer.DTOs;
using Orion.Application.CommonAppLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Application.CommonAppLayer.UseCases.FileStorageUseCases.UploadImages
{
    public class UploadImagesCommandHandler : IRequestHandler<UploadImagesCommand, UrlsDto>
    {
        private readonly IFileStorageService _fileStorageService;

        public UploadImagesCommandHandler(IFileStorageService fileStorageService)
        {
            _fileStorageService = fileStorageService;
        }

        public async Task<UrlsDto> Handle(UploadImagesCommand request, CancellationToken cancellationToken)
        {
            var urls = await _fileStorageService.UploadAsync(request.Files);
            return urls;
        }
    }
}
