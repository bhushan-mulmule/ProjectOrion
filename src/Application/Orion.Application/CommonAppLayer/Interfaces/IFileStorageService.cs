using Orion.Application.CommonAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Application.CommonAppLayer.Interfaces
{
    public interface IFileStorageService
    {
        Task<UrlsDto> UploadAsync(ICollection<FileDto> files);
    }
}
