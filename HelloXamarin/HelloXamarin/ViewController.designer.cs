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

namespace HelloXamarin
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIActivityIndicatorView activityIndicator { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel buttonLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton clickButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch colorSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIProgressView progressBar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider slider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView textView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (activityIndicator != null) {
				activityIndicator.Dispose ();
				activityIndicator = null;
			}
			if (buttonLabel != null) {
				buttonLabel.Dispose ();
				buttonLabel = null;
			}
			if (clickButton != null) {
				clickButton.Dispose ();
				clickButton = null;
			}
			if (colorSwitch != null) {
				colorSwitch.Dispose ();
				colorSwitch = null;
			}
			if (progressBar != null) {
				progressBar.Dispose ();
				progressBar = null;
			}
			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}
			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}
			if (textView != null) {
				textView.Dispose ();
				textView = null;
			}
		}
	}
}
