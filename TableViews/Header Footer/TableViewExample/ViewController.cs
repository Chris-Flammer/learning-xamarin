using System;

using UIKit;
using System.Collections.Generic;

namespace TableViewExample
{
	public partial class ViewController : UIViewController
	{

		// the data for the dataView
		List<string> tableItems;

		public ViewController (IntPtr handle) : base (handle)
		{
			tableItems = new List<string> ();
			for (var i = 0; i < 40; i++)  {
				tableItems.Add ("Item number " + i.ToString());
			};
					
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			tableView.Source = new TableViewSource(tableItems);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}



	}
}

