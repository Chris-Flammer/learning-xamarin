using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace TableViewExample
{
	public class CustomCell : UITableViewCell
	{

		UILabel headingLabel, subheadingLabel;


		public CustomCell (NSString cellId) : base (UITableViewCellStyle.Default, cellId)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Blue;
			ContentView.BackgroundColor = UIColor.GroupTableViewBackgroundColor;

			// set up the properties for the heading label
			headingLabel = new UILabel () {
				Font = UIFont.SystemFontOfSize(20),
				TextColor = UIColor.Black,
				BackgroundColor = UIColor.Clear,
			};

			// set up the properties for the subheading label
			subheadingLabel = new UILabel () {
				Font = UIFont.BoldSystemFontOfSize(15),
				TextColor = UIColor.DarkGray,
				BackgroundColor = UIColor.Clear,
			};


			// add the subviews to the ContentView
			ContentView.AddSubviews(new UIView[]{headingLabel,subheadingLabel});

		}


		// helper method to transport data to our cell's elements
		public void UpdateCell (string _heading, string _subheading) {
			headingLabel.Text = _heading;
			subheadingLabel.Text = _subheading;
		}


		// position each control here
		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			headingLabel.Frame = new CGRect (5, 5, ContentView.Bounds.Width, 20);
			subheadingLabel.Frame = new CGRect (15, 30, ContentView.Bounds.Width, 20);
		}

	}
}

