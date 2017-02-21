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

namespace sidebarTest
{
    [Register ("Page2ViewController")]
    partial class Page2ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem cameraButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cameraButton != null) {
                cameraButton.Dispose ();
                cameraButton = null;
            }
        }
    }
}