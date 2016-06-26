using System;
using System.Collections.Generic;
using UIKit;

namespace CollectionViewApp
{
	public partial class ViewController : UIViewController
	{

		List<string> collectionItems;


		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			collectionView.RegisterClassForCell(typeof(CustomCell), CustomCell.CellID);

			collectionItems = new List<string>();
			var alphabet = new string[] { "a", "b", "c", "d", "e" };
			var random = new Random();
			for (var i = 0; i < 100; i++)
			{
				collectionItems.Add(alphabet[random.Next(0, 4)]);
			}

			collectionView.Source = new CustomCollectionSource(collectionItems);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

