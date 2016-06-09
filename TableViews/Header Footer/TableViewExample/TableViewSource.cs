using System;
using UIKit;
using System.Collections.Generic;



namespace TableViewExample
{
	public class TableViewSource : UITableViewSource
	{
		List<string> tableItems;

		public TableViewSource (List<string> _tableItems)
		{
			tableItems = _tableItems;
		}


		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count;
		}


		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("cell");

			// set up cell
			cell.TextLabel.Text = tableItems[indexPath.Row];

			return cell;
		}


		public override string TitleForHeader (UITableView tableView, nint section)
		{
			return "This is a Header";
		}


		public override string TitleForFooter (UITableView tableView, nint section)
		{
			return "This is a Footer";
		}



		public override UIView GetViewForHeader (UITableView tableView, nint section)
		{
			// create our header
			var header = new UIView();
			header.BackgroundColor = UIColor.DarkGray;
			var label = new UILabel() {
				Font = UIFont.SystemFontOfSize(22), 
				Frame = new CoreGraphics.CGRect(5,10,tableView.Bounds.Size.Width, 25), 
				TextColor = UIColor.Red,
				Text = "Header",
			};

			header.Add(label);

			return header;
		}

		public override nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			return 200f;
		}
	}
}

