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

namespace EventExample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonOne { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonThree { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonTwo { get; set; }

        [Action ("ButtonThreePressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButtonThreePressed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (buttonOne != null) {
                buttonOne.Dispose ();
                buttonOne = null;
            }

            if (buttonThree != null) {
                buttonThree.Dispose ();
                buttonThree = null;
            }

            if (buttonTwo != null) {
                buttonTwo.Dispose ();
                buttonTwo = null;
            }
        }
    }
}