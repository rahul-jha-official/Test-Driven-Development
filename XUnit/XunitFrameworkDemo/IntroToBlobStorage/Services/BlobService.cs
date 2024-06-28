using IntroToBlobStorage.Interfaces;
using IntroToBlobStorage.Models;
using Newtonsoft.Json;
using System.Text;

namespace IntroToBlobStorage.Services;

public class BlobService<T> : IBlobService<T> where T : BlobFile, new()
{
    private readonly IBlobRepository _blobRepository;
    public BlobService(IBlobRepository blobRepository)
    {
        _blobRepository = blobRepository;
    }

    public async Task<bool> CheckIfBlobExistAsync(string folder, string fileName, string extension)
    {
        return await _blobRepository.CheckIfBlobExistAsync(folder, fileName, extension);
    }

    public async Task<string> AddBlobAsync(T blob, string folder, string fileName, string extension)
    {
        var serializedData = JsonConvert.SerializeObject(blob);
        var binaryDataFromSerialized = Encoding.UTF8.GetBytes(serializedData);
        return await _blobRepository.AddBlobAsync(binaryDataFromSerialized, folder, fileName, extension);
    }

    public async Task<T?> GetBlobAsync(string folder, string fileName, string extension, string version = "")
    {
        var binaryData = await _blobRepository.GetBlobAsync(folder, fileName, extension, version);
        var serializedDataFromBinary = Encoding.Default.GetString(binaryData);
        var blob = JsonConvert.DeserializeObject<T>(serializedDataFromBinary);
        return blob ?? new T();
    }
}
