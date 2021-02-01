using System;
using System.Collections.Generic;
using NullObjectLibrary.ApplicationExample.Applications.Common;
using NullObjectLibrary.SmartphoneApplicationExample.Applications;

namespace NullObjectLibrary.SmartphoneApplicationExample
{
    public class ApplicationRepository
    {
        private readonly Dictionary<Guid, Application> _installedApplications;

        public ApplicationRepository()
        {
            var gmailProcessId = new Guid("6a3852ab-0973-4d1b-82d8-edd131c5f0a9");
            var subwaySurfersProcessId = new Guid("c8bc60c6-f1d2-484f-91ee-a6e6dec9e782");
            var youtubeProcessId = new Guid("2b8ba9a3-4f83-4f86-96a8-94daf79fa4bd");

            _installedApplications = new Dictionary<Guid, Application>
            {
                { gmailProcessId, new Gmail(gmailProcessId) },
                { subwaySurfersProcessId, new SubwaySurfers(subwaySurfersProcessId) },
                { youtubeProcessId, new Youtube(youtubeProcessId) },
            };
        }

        public Application Find(Guid processId)
        {
            if (_installedApplications.TryGetValue(processId, out Application application))
            {
                return application;
            }

            return Application.Default;
        }
    }
}
