using System;
using UIKit;
using SidebarNavigation;

namespace sidebarTest
{
	public class BaseViewController : UIViewController
	{
		public BaseViewController(IntPtr handle) : base (handle)
        {

		}

		public SidebarController SidebarController { get; set; }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			SidebarController = ((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController;

			if (NavigationItem != null)
				NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIImage.FromBundle("menu_burger"), UIBarButtonItemStyle.Plain, (sender, e) =>
				{
					if (SidebarController == null) return;

					SidebarController.ToggleMenu();

				}); ;

		}
	}


	public class BaseTableViewController : UITableViewController
	{ 

		public SidebarController SidebarController { get; set; }

        public BaseTableViewController (IntPtr handle) : base (handle)
        {
			
        }


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			SidebarController = ((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController;

			if (NavigationItem != null)
				NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIImage.FromBundle("menu_burger"), UIBarButtonItemStyle.Plain,  (sender, e) => {

					if (SidebarController == null) 
						return;

					SidebarController.ToggleMenu();
					}); ;
		}

	}
}
