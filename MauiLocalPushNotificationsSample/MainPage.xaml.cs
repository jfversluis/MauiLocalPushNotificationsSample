using Plugin.LocalNotification;

namespace MauiLocalPushNotificationsSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		LocalNotificationCenter.Current.NotificationActionTapped += Current_NotificationActionTapped;
	}

	private void Current_NotificationActionTapped(Plugin.LocalNotification.EventArgs.NotificationActionEventArgs e)
	{
		if (e.IsDismissed)
		{

		}
		else if (e.IsTapped)
		{

		}
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var request = new NotificationRequest
		{
			NotificationId = 1337,
			Title = "Subscribe to my channel",
			Subtitle = "Hello",
			Description = "It's me",
			BadgeNumber = 42,
			Schedule = new NotificationRequestSchedule
			{
				NotifyTime = DateTime.Now.AddSeconds(5),
				NotifyRepeatInterval = TimeSpan.FromDays(1),
			}
		};

		LocalNotificationCenter.Current.Show(request);
	}
}

