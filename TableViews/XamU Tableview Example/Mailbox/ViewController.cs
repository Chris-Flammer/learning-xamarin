using System;
using Foundation;
using UIKit;

namespace Mailbox
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        //UITableView tableView;
		EmailServerDataSource dataSource;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

			/*
            Add(tableView = new UITableView(this.View.Frame));
			tableView.ContentInset = new UIEdgeInsets(20, 0, 0, 0);

            tableView.TranslatesAutoresizingMaskIntoConstraints = false;
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Top,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.TopMargin, 1, 0));
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Left,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.Left, 1, 0));
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Width,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.Width, 1, 0));
            View.AddConstraint(NSLayoutConstraint.Create(tableView, NSLayoutAttribute.Height,
                NSLayoutRelation.Equal, View, NSLayoutAttribute.Height, 1, 0));
                */

			dataSource = new EmailServerDataSource(this);
			tableView.Source = dataSource;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }



	class EmailServerDataSource : UITableViewSource
	{
		EmailServer emailServer = new EmailServer();

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return emailServer.Email.Count;
		}



		const string CellId = "EmailCell";

		public override UITableViewCell GetCell(UITableView tableView,
												NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellId, indexPath);
			if (cell.ImageView.Image != null)
			{
				cell.ImageView.Image.Dispose();
			}

			var item = emailServer.Email[indexPath.Row];

			cell.TextLabel.Text = item.Subject.Substring(0, 20) + "...";
			cell.ImageView.Image = item.GetImage();
			cell.DetailTextLabel.Text = item.Body;

			return cell;
		}





		ViewController owner;

		public EmailServerDataSource(ViewController owner)
		{
			this.owner = owner;
		}



		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			// Create the View Controller in the Main storyboard.
			var storyboard = UIStoryboard.FromName("Main", null);
			var detailViewController =
				(DetailViewController)storyboard.InstantiateViewController(
					"DetailViewController");

			// Set the email details
			var emailItem = emailServer.Email[indexPath.Row];
			detailViewController.Item = emailItem;

			// Show the new page as a "modal"
			owner.ShowDetailViewController(detailViewController, owner);
		}


		public override void AccessoryButtonTapped(UITableView tableView,
									   NSIndexPath indexPath)
		{
			var emailItem = emailServer.Email[indexPath.Row];

			var controller = UIAlertController.Create("Email Details",
								 emailItem.ToString(), UIAlertControllerStyle.Alert);
			controller.AddAction(UIAlertAction.Create("OK",
								 UIAlertActionStyle.Default, null));

			owner.PresentViewController(controller, true, null);
		}






	}






}

