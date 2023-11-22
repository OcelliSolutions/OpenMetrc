namespace OpenMetrc.Scraper;
internal static class DirectoryService
{

    // Create any missing folders in a path.
    internal static void CreateFoldersIfMissing(string path)
    {
        var folderExists = Directory.Exists(path);
        if (!folderExists)
        {
            Directory.CreateDirectory(path);
        }
    }
}
