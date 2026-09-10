using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VinokurowAV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.VinokurowAV.Sprint0.Task2.V0.Test { [TestClass] public class DataServiceTest { [TestMethod] public void CheckGetMessageValid() { var name = "артем"; var res = DataService.GetMessage(name); Assert.AreEqual("Привет, артем", res); } } }
