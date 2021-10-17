using System;
using BuildingBlocks;

namespace NullObjectLibrary.SmartphoneApplicationExample
{
    public static class SmartphoneApplicationExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Smartphone application example");

            var applicationRepository = new ApplicationRepository();

            var validProcessId = new Guid("6a3852ab-0973-4d1b-82d8-edd131c5f0a9");
            var invalidProcessId = Guid.Empty;

            var gmail = applicationRepository.Find(validProcessId);
            gmail.Open();
            gmail.Close();

            // Null exception won't be thrown if an application with the specified process ID can't be found.
            // In that case, default (NULL) object will be returned.
            var youtube = applicationRepository.Find(invalidProcessId);
            youtube.Open();
            youtube.Close();
        }
    }
}
