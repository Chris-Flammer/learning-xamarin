using System;

using UIKit;

namespace Fireworks
{
	public partial class ViewController : UIViewController
	{
		SimpleParticleGen fireworks;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			fireworks = new SimpleParticleGen(UIImage.FromFile("xamlogo.png"),View);
			fireworks.ContinousParticles = true;

			// configure the start button
			startButton.Layer.CornerRadius = 5.0f;
			startButton.TouchUpInside += delegate (object sender, EventArgs e)
			{
				if (fireworks.isRunning)
				{
					fireworks.Stop();
					startButton.SetTitle("Start Show", UIControlState.Normal);
				}
				else {
					fireworks.Start();
					startButton.SetTitle("End Show", UIControlState.Normal);
				}

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		partial void toggleNight(UISwitch sender)
		{
			if (nightSwitch.On)
			{
				nightLabel.TextColor = UIColor.White;
				sizeLabel.TextColor = UIColor.White;
				this.View.BackgroundColor = UIColor.DarkGray;
			}
			else {
				nightLabel.TextColor = UIColor.Black;
				sizeLabel.TextColor = UIColor.Black;
				this.View.BackgroundColor = UIColor.White;
			}
		}

		partial void sliderChanged(UISlider sender)
		{
			fireworks.ScaleMax = (nfloat)sizeSlider.Value;
		}
	}
}

