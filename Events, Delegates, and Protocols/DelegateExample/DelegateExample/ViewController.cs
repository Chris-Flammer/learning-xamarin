using System;

using UIKit;

namespace DelegateExample
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

			ExampleDelegate del = new ExampleDelegate();
			// once you've instantiated the delgate class, you can now set and assign it to handle any work the delegate is for (ex: UITableViewDelegate)




		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}



	// This delegate is using the UIAlertViewDelegate Protocol, but you can use any protocol (even a custom one)
	public class ExampleDelegate : UIAlertViewDelegate
	{
		public override void Clicked(UIAlertView alertview, nint buttonIndex)
		{
			base.Clicked(alertview, buttonIndex);
			Console.WriteLine(buttonIndex.ToString() + " clicked");
		}

	}
}

