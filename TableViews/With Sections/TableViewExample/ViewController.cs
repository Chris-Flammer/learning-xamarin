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
			tableItems.Add ("Apple");
			tableItems.Add ("Aardavark");
			tableItems.Add ("Bee");
			tableItems.Add ("Butterfly");
			tableItems.Add ("Candy");
			tableItems.Add ("Donut");
			tableItems.Add ("Mild");
			tableItems.Add ("Hot");
			tableItems.Add ("Salsa");
			tableItems.Add ("Bread");
			tableItems.Add ("Zebra");
			tableItems.Add ("Zoo");
			tableItems.Add ("Car");
			tableItems.Add ("Computer");
			tableItems.Add ("Shape");
			tableItems.Add ("Can");
			tableItems.Add ("Code");
			tableItems.Add ("Market");
			tableItems.Add ("Hotel");
			tableItems.Add ("Strawberry");
			tableItems.Add ("Statue");
			tableItems.Add ("Xeno");
			tableItems.Add ("Orange");
			tableItems.Add ("Space");
			tableItems.Add ("Galaxy");
			tableItems.Add ("Orien");
			tableItems.Add ("Ordinary");
			tableItems.Add ("Falls");
			tableItems.Add ("Manners");
			tableItems.Add ("Food");
			tableItems.Add ("Chips");
			tableItems.Add ("Knife");
			tableItems.Add ("Stripes");
			tableItems.Add ("Worker");
			tableItems.Add ("Motercycle");
			tableItems.Add ("Mouse");
			tableItems.Add ("Rat");
			tableItems.Add ("Cat");
			tableItems.Add ("Cyber");
			tableItems.Add ("Hacker");
			tableItems.Add ("Home");
			tableItems.Add ("Strange");
			tableItems.Add ("Zip");
			tableItems.Add ("Yellow");

					
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

