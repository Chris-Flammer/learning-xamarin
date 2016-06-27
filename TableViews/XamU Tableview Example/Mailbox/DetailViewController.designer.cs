// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Mailbox
{
    [Register ("DetailViewController")]
    partial class DetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EmailText { get; set; }
        [Action ("doneButtonTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void doneButtonTapped (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (EmailText != null) {
                EmailText.Dispose ();
                EmailText = null;
            }
        }
    }
}