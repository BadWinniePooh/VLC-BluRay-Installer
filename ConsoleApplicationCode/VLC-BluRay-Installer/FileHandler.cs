namespace VLC_BluRay_Installer;

internal class FileHandler
{
    private static string sourcePath = @".\Data";
    internal void Copy(string fileName, string targetPath)
    {
        string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
        string destFile = System.IO.Path.Combine(targetPath, fileName);

        System.IO.Directory.CreateDirectory(targetPath);

        System.IO.File.Copy(sourceFile, destFile, true);
    }
}

