﻿using System;
using Microsoft.ReactNative.Managed;

namespace ReactNativeModuleUser
{
    [ReactModule]
    class LoginUser
    {
        [ReactConstant]
        public double E = Math.E;

        [ReactConstant("Pi")]
        public double PI = Math.PI;

        [ReactMethod("add")]
        public double Add(double a, double b)
        {
            double result = a + b;
            AddEvent(result);
            return result;
        }

        [ReactMethod("login")]
        public string Login(string user, string pass)
        {
            string result = user + " / " + pass;
            //AddEvent(result);
            return result;
        }

        [ReactEvent]
        public Action<double> AddEvent { get; set; }
    }
}
