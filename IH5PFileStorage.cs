using System.IO;

namespace H5P
{
    public interface IH5PFileStorage
    {
        /// <summary>
        /// Saves the given content data.
        /// </summary>
        /// <param name="filePath">The path where the file should be saved.</param>
        /// <param name="data">The data to be saved.</param>
        void SaveFile(string filePath, Stream data);

        /// <summary>
        /// Reads the content of the file at the given path.
        /// </summary>
        /// <param name="filePath">The path of the file to be read.</param>
        /// <returns>A stream containing the file data.</returns>
        Stream ReadFile(string filePath);

        /// <summary>
        /// Deletes the file at the given path.
        /// </summary>
        /// <param name="filePath">The path of the file to be deleted.</param>
        void DeleteFile(string filePath);

        /// <summary>
        /// Checks if a file exists at the given path.
        /// </summary>
        /// <param name="filePath">The path to check for the file.</param>
        /// <returns>True if the file exists, otherwise false.</returns>
        bool FileExists(string filePath);

        /// <summary>
        /// Moves a file from one path to another.
        /// </summary>
        /// <param name="sourceFilePath">The current path of the file.</param>
        /// <param name="destinationFilePath">The new path of the file.</param>
        void MoveFile(string sourceFilePath, string destinationFilePath);

        /// <summary>
        /// Copies a file from one path to another.
        /// </summary>
        /// <param name="sourceFilePath">The current path of the file.</param>
        /// <param name="destinationFilePath">The new path of the file.</param>
        void CopyFile(string sourceFilePath, string destinationFilePath);
    }
}