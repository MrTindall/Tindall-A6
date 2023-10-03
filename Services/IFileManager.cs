namespace ApplicationTemplate.Services;

//A4 Assignment

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>

public interface IFileManager
{
    void ReadFile(string path);
    void WriteFile(string path);
}
