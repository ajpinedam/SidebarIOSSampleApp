using Foundation;
using System;
using UIKit;

namespace sidebarTest
{
    public partial class Page2ViewController : BaseViewController
    {
        public Page2ViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			cameraButton.Clicked += CameraButton_Clicked;
		}

		void CameraButton_Clicked (object sender, EventArgs e)
		{
			PerformSegue("pageTwoMoreInfo", this);
		}
	}
}