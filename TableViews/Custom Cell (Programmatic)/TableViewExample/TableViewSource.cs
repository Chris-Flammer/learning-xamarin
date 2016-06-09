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
			var cell = tableView.DequeueReusableCell ("cell") as CustomCell;
			if (cell == null) {
				cell = new CustomCell (new Foundation.NSString ("cell"));
			}

			cell.UpdateCell (tableItems [indexPath.Row], tableItems [indexPath.Row]);

			// set up cell


			return cell;
		}


		// handle selection
		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			tableView.DeselectRow (indexPath, true);
		}


		// set up height
		public override nfloat GetHeightForRow (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 75f;
		}
	}
}

