using Microsoft.Azure.Devices.Client;
using System;
using Xunit;

namespace DeviceApp.Tests
{
    public class SetTelemetryIntervalTests
    {

        private DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=ec-win20-danarv.azure-devices.net;DeviceId=DeviceApp;SharedAccessKey=oX1T0avW+ikvoo3oy57gXCchScQjN7acAhRBVbwmHn0=", TransportType.Mqtt);
        
        
        
        [Theory]
        [InlineData("SetTelemetryInterval", "10", 200)]
        [InlineData("SetTelemetry", "10", 501)]

        public void SetTelemetryInterval_ShouldChangeInterval(string methodName, string payload, int statuscode)
        {
            deviceClient.SetMethodHandlerAsync(methodName, SetTelemetryInterval, null).Wait();
        }
    }
}
