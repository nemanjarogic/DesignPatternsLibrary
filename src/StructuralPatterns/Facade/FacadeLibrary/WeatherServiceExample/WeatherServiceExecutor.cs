using FacadeLibrary.WeatherServiceExample.After;
using FacadeLibrary.WeatherServiceExample.Before;

namespace FacadeLibrary.WeatherServiceExample
{
    public static class WeatherServiceExecutor
    {
        public static void Execute()
        {
            BeforeExecutor.Execute();
            AfterExecutor.Execute();
        }
    }
}
