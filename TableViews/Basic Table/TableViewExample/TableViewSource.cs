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
	}
}

