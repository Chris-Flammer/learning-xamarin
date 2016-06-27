using Foundation;
using System;
using UIKit;

namespace Mailbox
{
    public partial class DetailViewController : UIViewController
    {
        public DetailViewController (IntPtr handle) : base (handle)
        {
        }

		EmailItem item;
		public EmailItem Item
		{
			get
			{
				return item;
			}
			set
			{
				item = value;
				UpdateItem();
			}
		}


		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			UpdateItem();
		}

		public void UpdateItem()
		{
			if (EmailText != null)
			{
				EmailText.Text = (Item != null) ? Item.ToString() : "";
			}
		}





		partial void doneButtonTapped(UIButton sender)
		{
			this.DismissViewController(true, null);
		}



	}
}