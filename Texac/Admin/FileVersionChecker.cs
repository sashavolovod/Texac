using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace Texac.Admin
{
    public class FileVersionChecker
    {
        public static List<FileInfo> GetFileVersions(string workingDirectory = null)
        {
            var result = new List<FileInfo>();

            // Если каталог не указан, используем текущий рабочий каталог
            string directory = workingDirectory ?? Directory.GetCurrentDirectory();

            try
            {
                // Получаем все файлы
                string[] allFiles = Directory.GetFiles(directory, "*.*", SearchOption.TopDirectoryOnly);

                // Проверяем каждый файл
                foreach (string filePath in allFiles)
                {
                    string extension = Path.GetExtension(filePath).ToLower();
                    if (extension == ".exe" || extension == ".dll")
                    {
                        try
                        {
                            var versionInfo = FileVersionInfo.GetVersionInfo(filePath);
                            result.Add(new FileInfo
                            {
                                FileName = Path.GetFileName(filePath),
                                FileVersion = versionInfo.FileVersion,
                                ProductVersion = versionInfo.ProductVersion,
                                CompanyName = versionInfo.CompanyName,
                                FileDescription = versionInfo.FileDescription
                            });
                        }
                        catch (Exception ex)
                        {
                            // Логируем ошибку и продолжаем обработку следующего файла
                            Console.WriteLine($"Ошибка при получении информации о файле {filePath}: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при поиске файлов: {ex.Message}");
                throw;
            }

            return result;
        }

        public class FileInfo
        {
            public string FileName { get; set; }
            public string FileVersion { get; set; }
            public string ProductVersion { get; set; }
            public string CompanyName { get; set; }
            public string FileDescription { get; set; }
        }
    }
}
