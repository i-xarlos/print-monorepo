using Microsoft.ReactNative.Managed;
using Windows.Security.ExchangeActiveSyncProvisioning;

namespace ReactNativeModuleDevice
{
    [ReactModule]
    class Device
    {

        [ReactMethod("getDeviceModel")]
        public string GetDeviceModel()
        {
            EasClientDeviceInformation info = new EasClientDeviceInformation();
            return info.SystemProductName;
        }
    }
}
