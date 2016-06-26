using System;

using UIKit;

namespace ProtocolExample
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
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}



	// this is an example of a protocol
	interface IProtocolExample
	{
		void printName();
		void anotherDelegateMethod();

	}



	// this would be the class that implements the protocol's delegate methods
	public class MyClassApoptingProtocol : IProtocolExample
	{
		public void printName()
		{
			// code here
		}

		public void anotherDelegateMethod()
		{
			// code here
		}
	}

}

