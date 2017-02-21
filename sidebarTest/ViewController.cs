using System;
using SidebarNavigation;
using UIKit;

namespace sidebarTest
{
	public partial class ViewController : UIViewController
	{

		public SidebarController SidebarController
		{
			get;
			set;
		}

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var str = UIStoryboard.FromName("Main", null);

			var rootTabBar = str.InstantiateViewController("RootTabBarViewController") as RootTabBarViewController;

			var menu = str.InstantiateViewController("MenuButtonsController");

			SidebarController = new SidebarController(this, rootTabBar, menu);

			SidebarController.HasShadowing = false;
			SidebarController.MenuWidth = 210;
			SidebarController.MenuLocation = MenuLocations.Left;

			((AppDelegate)UIApplication.SharedApplication.Delegate).SideBarController = SidebarController;

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.


		}
	}
}
