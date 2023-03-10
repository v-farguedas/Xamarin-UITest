using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace AppCenter.UITest.Android
{
    public class Tests
    {
        AndroidApp _app;

        [SetUp]
        public void SetUp()
        {
            _app = ConfigureApp.Android.ApkFile("/Users/francisco/Downloads/build/sample.apk").StartApp();
        }

        [Test]
        public void AppDoesLaunch()
        {
            _app.WaitForElement(c => c.All());
        }
    }
}
