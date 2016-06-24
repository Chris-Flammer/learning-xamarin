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

namespace Fireworks
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel nightLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch nightSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sizeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sizeSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton startButton { get; set; }

        [Action ("toggleNight:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void toggleNight (UIKit.UISwitch sender);

        [Action ("sliderChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void sliderChanged (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (nightLabel != null) {
                nightLabel.Dispose ();
                nightLabel = null;
            }

            if (nightSwitch != null) {
                nightSwitch.Dispose ();
                nightSwitch = null;
            }

            if (sizeLabel != null) {
                sizeLabel.Dispose ();
                sizeLabel = null;
            }

            if (sizeSlider != null) {
                sizeSlider.Dispose ();
                sizeSlider = null;
            }

            if (startButton != null) {
                startButton.Dispose ();
                startButton = null;
            }
        }
    }
}