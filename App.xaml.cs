using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

namespace Ethic1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Ethic1Page();
        }

        protected override void OnStart()
        {
            AppCenter.Start(
                  "ios=96997c18-01be-4693-9aca-9ecf59492840;" 
                + "uwp=e320f61f-24c5-414c-9d5b-53a4ca811eb6;" 
                + "android=7a2127b6-5796-4027-bc8c-51875a5325a9"
                , typeof(Analytics)
                , typeof(Crashes)
                , typeof(Push)
            );
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
