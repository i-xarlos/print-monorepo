using System.IO;
using Microsoft.ReactNative.Managed;

namespace ReactNativeModuleImage
{
    public sealed class DataImage
    {
        public string directory { get; set; }
        public string[] content { get; set; }
    }

    [ReactModule]
    class Image
    {
        public string[] getImagesList()
        {
            string path = "Assets";
            string[] filePaths = Directory.GetFiles(path, "*.png");
            return filePaths;
        }

        [ReactMethod("getImages")]
        public DataImage GetImages()
        {
            var imagesList = getImagesList();
            DataImage dataPrinters = new DataImage() { directory = Directory.GetCurrentDirectory(), content = imagesList };
            return dataPrinters;

        }
    }
}
