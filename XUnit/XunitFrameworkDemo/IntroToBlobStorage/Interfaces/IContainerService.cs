namespace IntroToBlobStorage.Interfaces;

public interface IContainerService
{
    Task<IEnumerable<string>> GetContainersAsync();
    Task CreateContainerAsync(string containerName);
    Task DeleteContainerAsync(string containerName);
}
