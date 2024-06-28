using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using IntroToBlobStorage.Interfaces;

namespace IntroToBlobStorage.Services;

public class ContainerService : IContainerService
{
    private readonly BlobServiceClient _blobClient;
    public ContainerService(BlobServiceClient blobClient)
    {
        _blobClient = blobClient;
    }
    public async Task CreateContainerAsync(string containerName)
    {
        var client = _blobClient.GetBlobContainerClient(containerName);
        await client.CreateIfNotExistsAsync(PublicAccessType.BlobContainer);
    }

    public async Task DeleteContainerAsync(string containerName)
    {
        var client = _blobClient.GetBlobContainerClient(containerName);
        await client.DeleteIfExistsAsync();
    }

    public async Task<IEnumerable<string>> GetContainersAsync()
    {
        var containers = new List<BlobContainerItem>();
        await foreach (var item in _blobClient.GetBlobContainersAsync())
        {
            containers.Add(item);
        }
        return containers
                    .Select(e => e.Name)
                    .ToList();
    }
}
