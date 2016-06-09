using System;

using UIKit;
using System.Threading.Tasks;

namespace HelloXamarin
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Console.WriteLine ("Hello Xamarin");

			activityIndicator.StartAnimating ();
			textView.Text = "Hello";


			clickButton.TouchUpInside += ClickButton_TouchUpInside;
			colorSwitch.ValueChanged += ColorSwitch_ValueChanged;
			slider.ValueChanged += Slider_ValueChanged;




		}



		async void myBackgroundMethod() {
			await Task.Factory.StartNew(() => {
				// do background work here

				InvokeOnMainThread(() => {
					// main thread.  Handle UI updates here
				});

			});
		}

		void Slider_ValueChanged (object sender, EventArgs e)
		{
			Console.WriteLine ("slide value is " + slider.Value);
			textView.Font = UIFont.SystemFontOfSize (slider.Value);
			progressBar.Progress = slider.Value / 100f;
		}

		void ColorSwitch_ValueChanged (object sender, EventArgs e)
		{
			if (colorSwitch.On) 
			{
				textView.Text = "On";
			} else 
			{
				textView.Text = "Off";
			}
		}





		void ClickButton_TouchUpInside (object sender, EventArgs e)
		{
			activityIndicator.StopAnimating();
			clickButton.SetTitle("Hello Xamarin!", forState:UIControlState.Normal);
			textView.Text = "Hello Xamarin!";
			textView.ResignFirstResponder();
			textField.ResignFirstResponder();

			var randSeed = new Random ();
			var red = (float)randSeed.NextDouble ();
			var blue = (float)randSeed.NextDouble ();
			var green = (float)randSeed.NextDouble ();
			View.BackgroundColor = UIColor.FromRGB (red, green, blue);

			progressBar.SetProgress (0.8f, true);
		}


		public override void ViewWillUnload ()
		{
			base.ViewWillUnload ();
			Console.WriteLine ("View will Unload");
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			Console.WriteLine ("View will Appear");
		}


		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			Console.WriteLine ("View Will Dissappear");
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}


	}
}

