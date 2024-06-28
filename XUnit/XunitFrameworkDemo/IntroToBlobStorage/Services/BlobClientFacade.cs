using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using IntroToBlobStorage.Interfaces;

namespace IntroToBlobStorage.Services;

public class BlobClientFacade : IBlobClientFacade
{
    private readonly BlobContainerClient _blobContainerClient;

    public BlobClientFacade(BlobContainerClient blobContainerClient)
    {
        _blobContainerClient = blobContainerClient;
    }

    public async Task<Response<bool>> CheckAsync(string folder, string fileName, string extension)
    {
        var blobClient = _blobContainerClient.GetBlockBlobClient(GetPath(folder, fileName, extension));
        return await blobClient.ExistsAsync();
    }

    public async Task<Response<BlobContentInfo>> UploadAsync(MemoryStream stream, BlobHttpHeaders headers, string folder, string fileName, string extension)
    {
        var blobClient = _blobContainerClient.GetBlockBlobClient(GetPath(folder, fileName, extension));
        return await blobClient.UploadAsync(stream, headers);
    }

    public async Task<Response<BlobDownloadResult>> DownloadAsync(string folder, string fileName, string extension, string version = "")
    {
        var blobClient = _blobContainerClient.GetBlockBlobClient(GetPath(folder, fileName, extension));
        if (string.IsNullOrWhiteSpace(version))
        {
            return await DownloadAsync(blobClient);
        }
        return await DownloadAsync(blobClient, version);
    }

    private static async Task<Response<BlobDownloadResult>> DownloadAsync(BlockBlobClient client, string version)
    {
        var versionedClient = client.WithVersion(version);
        return await versionedClient.DownloadContentAsync();
    }

    private static async Task<Response<BlobDownloadResult>> DownloadAsync(BlockBlobClient client)
    {
        return await client.DownloadContentAsync();
    }

    private static string GetPath(string folder, string fileName, string extension)
    {
        return $"{folder}/{fileName}.{extension}";
    }
}
