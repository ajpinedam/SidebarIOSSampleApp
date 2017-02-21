using Foundation;
using System;
using UIKit;
using SidebarNavigation;

namespace sidebarTest
{
    public partial class MenuButtonsController : UIViewController
    {

		public SidebarController SidebarController { get; set; }

		public RootTabBarViewController RootTabBarViewController { get; set; }

        public MenuButtonsController (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			SidebarController = ((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController;

			RootTabBarViewController = SidebarController?.ContentAreaController as RootTabBarViewController;
		}

		//page 1
		partial void UIButton377_TouchUpInside(UIButton sender)
		{
			Navigate(0);
		}

		//page 2
		partial void UIButton378_TouchUpInside(UIButton sender)
		{
			Navigate(1);
		}

		//page 3
		partial void UIButton379_TouchUpInside(UIButton sender)
		{
			Navigate(2);
		}

		void Navigate(int index)
		{ 
			if (RootTabBarViewController == null)
				return;

			RootTabBarViewController.SelectedIndex = index;

			SidebarController.ToggleMenu();
		}
	}
}