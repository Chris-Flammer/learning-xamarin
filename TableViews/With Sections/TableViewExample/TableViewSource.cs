using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;



namespace TableViewExample
{
	public class TableViewSource : UITableViewSource
	{
		List<string> tableItems;

		Dictionary<string, List<string>> indexedTableItems;
		string[] keys;

		public TableViewSource (List<string> _tableItems)
		{
			tableItems = _tableItems;

			// get up indexedTableItems
			indexedTableItems = new Dictionary<string, List<string>> ();
			foreach (var t in tableItems) {
				if (indexedTableItems.ContainsKey (t [0].ToString ())) {
					indexedTableItems [t [0].ToString ()].Add (t);
				} else {
					indexedTableItems.Add (t [0].ToString (), new List<string> () { t });
				}
			}
			keys = indexedTableItems.Keys.ToArray ();

		}


		public override nint NumberOfSections (UITableView tableView)
		{
			return keys.Length;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			string key = keys[section];
			var listItem = indexedTableItems [key];
			return listItem.Count;
		}


		public override string[] SectionIndexTitles (UITableView tableView)
		{
			return keys;
		}


		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("cell");

			// set up cell
			string key = keys[indexPath.Section];
			var listItem = indexedTableItems [key];
			var title = listItem [indexPath.Row];

			cell.TextLabel.Text = title;

			return cell;
		}


	}
}

