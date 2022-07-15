using System;
using System.Collections.Generic;
using Microsoft.ReactNative.Managed;

namespace ReactNativeModulePrinter
{

    [ReactModule]
    class Printers
    {

        [ReactMethod("getList")]
        public async void ListAsync(IReactPromise<List<PrintDLL.Printer>> promise)
        {
            try
            {

                var printers = new PrintDLL.Printers();
                var printerList = await printers.ListPrinters();
                promise.Resolve((List<PrintDLL.Printer>)printerList);

            }
            catch (Exception e)
            {
                promise.Reject(new ReactError { Exception = e });
            }

        }
    }
}
