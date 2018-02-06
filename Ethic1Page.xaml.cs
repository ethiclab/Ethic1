using Xamarin.Forms;
using Microsoft.AppCenter.Push;

namespace Ethic1
{
    public partial class Ethic1Page : ContentPage
    {
        public Ethic1Page()
        {
            InitializeComponent();
        }

        public void subscribe() {
            // This should come before AppCenter.Start() is called
            Push.PushNotificationReceived += (sender, e) => {

                // Add the notification message and title to the message
                var summary = $"Push notification received:" +
                                    $"\n\tNotification title: {e.Title}" +
                                    $"\n\tMessage: {e.Message}";

                // If there is custom data associated with the notification,
                // print the entries
                if (e.CustomData != null)
                {
                    summary += "\n\tCustom data:\n";
                    foreach (var key in e.CustomData.Keys)
                    {
                        summary += $"\t\t{key} : {e.CustomData[key]}\n";
                    }
                }

                // Send the notification summary to debug output
                System.Diagnostics.Debug.WriteLine(summary);
                myLabel.Text = summary;
            };
        }
    }
}
