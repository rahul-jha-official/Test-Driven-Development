namespace IntroToBlobStorage.Interfaces;

public interface IBlobService<T>
{
    Task<bool> CheckIfBlobExistAsync(string folder, string fileName, string extension);
    Task<string> AddBlobAsync(T blob, string folder, string fileName, string extension);
    Task<T?> GetBlobAsync(string folder, string fileName, string extension, string version = "");
}
