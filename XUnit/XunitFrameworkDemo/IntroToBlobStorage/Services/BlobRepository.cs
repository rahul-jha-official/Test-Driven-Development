using Azure.Storage.Blobs.Models;
using IntroToBlobStorage.Interfaces;

namespace IntroToBlobStorage.Services;

public class BlobRepository : IBlobRepository
{
    private readonly IBlobClientFacade _clientWrapper;
    public BlobRepository(IBlobClientFacade clientWrapper)
    {
        _clientWrapper = clientWrapper;
    }

    public async Task<bool> CheckIfBlobExistAsync(string folder, string fileName, string extension)
    {
        return await _clientWrapper.CheckAsync(folder, fileName, extension);
    }

    public async Task<string> AddBlobAsync(byte[] bytes, string folder, string fileName, string extension)
    {
        using (var stream = new MemoryStream(bytes))
        {
            var headers = new BlobHttpHeaders
            {
                ContentType = GetContentTypeFromExtension(extension)
            };

            var blobContentInfo = await _clientWrapper.UploadAsync(stream, headers, folder, fileName, extension);

            return blobContentInfo.Value.VersionId;
        }
    }

    public async Task<byte[]> GetBlobAsync(string folder, string fileName, string extension, string version = "")
    {
        var blob = await _clientWrapper.DownloadAsync(folder, fileName, extension, version);
        return blob.Value.Content.ToArray();
    }

    private static string GetContentTypeFromExtension(string extension)
    {
        return extension switch
        {
            "json" => "application/json",
            "txt" => "text/plain",
            _ => throw new NotImplementedException("Extension is not defined.")
        };
    }
}
