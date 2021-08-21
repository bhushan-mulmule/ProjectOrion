using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Orion.Application.CommonAppLayer.DTOs;
using Orion.Application.CommonAppLayer.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orion.ThirdPartyServices.AzureServices
{
    public class BlobStorageService : IFileStorageService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public BlobStorageService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<UrlsDto> UploadAsync(ICollection<FileDto> files)
        {
            if (files == null || files.Count == 0)
            {
                return null;
            }

            var containerClient = _blobServiceClient.GetBlobContainerClient("publicuploads");


            var urls = new List<string>();


            foreach (var file in files)
            {
                var blobClient = containerClient.GetBlobClient(file.GetPathWithFileName());

                await blobClient.UploadAsync(file.Content, new BlobHttpHeaders { ContentType = file.ContentType });

                urls.Add(blobClient.Uri.ToString());
            }

            return new UrlsDto(urls);
        }
    }
}
