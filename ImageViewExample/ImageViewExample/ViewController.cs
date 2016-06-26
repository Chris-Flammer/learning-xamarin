using System;

using UIKit;

namespace ImageViewExample
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


			// example to add an imageview to screen
			var imageView = new UIImageView(new CoreGraphics.CGRect(0, 0, 100, 100));
			imageView.ContentMode = UIViewContentMode.ScaleAspectFill;
			imageView.Image = UIImage.FromBundle("testImage.png"); // stores a cache.  More efficient
			//imageView.Image = UIImage.FromFile("MyImages/testImage.png"); // doesn't store a cache.  uses dir

			View.AddSubview(imageView);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

