using System;

using UIKit;

namespace EventExample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			buttonOne.TouchUpInside += (sender, e) =>
			{
				// code here
			};


			buttonTwo.TouchUpInside += ButtonTwo_TouchUpInside;


		}



		void ButtonTwo_TouchUpInside(object sender, EventArgs e)
		{

		}



		partial void ButtonThreePressed(UIButton sender)
		{
			// code here...
		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

