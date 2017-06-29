using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;
using System.Threading.Tasks;

namespace AutomationScript
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                .ApkFile(@"C:\Mani\Xamarin\XamarinUITest\XamarinUITest\obj\Release\android\bin\XamarinUITest.XamarinUITest.apk")
                .EnableLocalScreenshots()
                .StartApp();
        }

        [Test]
        public async Task AppLaunches()
        {
            // waiting for mapview to load
            app.WaitForElement(x=>x.Id("MyMapView"),timeout:TimeSpan.FromSeconds(200));

            // waiting for respective buttons to load
            app.WaitForElement(x => x.Id("la"), timeout: TimeSpan.FromSeconds(200));
            app.WaitForElement(x => x.Id("lv"), timeout: TimeSpan.FromSeconds(200));

            // click/tap on button 
            app.Tap(x=>x.Id("la"));
            // waiting for 10 secods for map to render.
            Task.Delay(10000);
            app.Screenshot("Los Angeles");

            // click/tap on button
            app.Tap(x=>x.Id("lv"));
            // waiting for 10 secods for map to render.
            Task.Delay(10000);
            app.Screenshot("Los Vegas");
        
        }
    }
}

