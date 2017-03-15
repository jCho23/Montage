using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace Montage
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
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile("/Users/junecho/Desktop/Montage.apk")
				.StartApp();
		}

		[Test]
		public void AppLaunches()
		{

			app.Tap(x => x.Class("AIRWindowSurfaceView"));
			app.DismissKeyboard();
			app.Screenshot("AIRWindowSurfaceView");

		}
	}
}

