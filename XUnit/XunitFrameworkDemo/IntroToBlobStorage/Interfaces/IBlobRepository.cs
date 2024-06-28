namespace IntroToBlobStorage.Interfaces;

public interface IBlobRepository
{
    Task<bool> CheckIfBlobExistAsync(string folder, string fileName, string extension);
    Task<string> AddBlobAsync(byte[] bytes, string folder, string fileName, string extension);
    Task<byte[]> GetBlobAsync(string folder, string fileName, string extension, string version = "");
}
