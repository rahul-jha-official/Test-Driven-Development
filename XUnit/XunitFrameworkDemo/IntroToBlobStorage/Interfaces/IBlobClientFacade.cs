using Azure;
using Azure.Storage.Blobs.Models;

namespace IntroToBlobStorage.Interfaces;

public interface IBlobClientFacade
{
    Task<Response<bool>> CheckAsync(string folder, string fileName, string extension);
    Task<Response<BlobContentInfo>> UploadAsync(MemoryStream stream, BlobHttpHeaders headers, string folder, string fileName, string extension);
    Task<Response<BlobDownloadResult>> DownloadAsync(string folder, string fileName, string extension, string version = "");
}
