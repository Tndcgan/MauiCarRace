using MauiCarRace.Classes;
using NetworkExtension;

namespace MauiCarRace;

public partial class MainPage : ContentPage
{
	Car porsche;
	Car bmw;
	bool isFinish = false;

	public MainPage()
	{
		InitializeComponent();

		porsche = new Car("A1" , 220 ,20);
		porsche.UseFuelRate = 10;
		bmw = new Car("B1" , 180 ,3);
		bmw.UseFuelRate = 8;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if(!this.isFinish)
		{
			var screenWidth = Application.Current.MainPage.Width;
			this.porscheRun(screenWidth);
			this.bmwRun(screenWidth);
			this.myLabel.Text = porsche.ShowInfo() + "\n" + bmw.ShowInfo();
			this.isFinish = true;
		}
		else
		{
			ImageCar1.TranslateTo(0,0,0, Easing.Linear);
			ImageCar2.TranslateTo(0,0,0, Easing.Linear);
			this.isFinish = false;
		}
		
		//porsche.Run(30);
		//bmw.Run(15);
		//myLabel.Text = porsche.ShowInfo() +"\n"+ bmw.ShowInfo();
	}
	private void porscheRun (double distance)
	{
		var timeuse = porsche.TimeUseForRun(distance);
		ImageCar1.TranslateTo(distance - 100, 0,timeuse*1000, Easing.Linear);

	}

	private void bmwRun(double distance)
	{
		var timeuse = bmw.TimeUseForRun(distance);
		ImageCar2.TranslateTo(distance - 100, 0,timeuse*1000, Easing.Linear);
	}
}

