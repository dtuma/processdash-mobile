using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace ProcessDashboard.iOS
{
    public partial class HomePageViewController : UIViewController
    {

		UIButton startButton, stopButton, checkButton;


		public HomePageViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var ProjectNameLabel = new UILabel(new CGRect(30, 80, 300, 40))
			{
				Text = "/ Project / Mobile App I1",
				Font = UIFont.SystemFontOfSize(16),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.FromRGB(220, 220, 220),
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap,
			};

			// 
			var CurrentTaskLabel = new UILabel(new CGRect(30, 130, 100, 20))
			{
				Text = "Current Task:",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Left,
				//BackgroundColor = UIColor.LightGray,
			};



			var CurrentTaskNameLabel = new UILabel(new CGRect(30, 170, 300, 60))
			{
				Text = "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Team Walkthrough",
				Font = UIFont.SystemFontOfSize(13),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.FromRGB(220, 220, 220),
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap,
			};

			startButton = UIButton.FromType(UIButtonType.RoundedRect);
			startButton.SetImage(UIImage.FromFile("start.png"), UIControlState.Normal);
			startButton.SetImage(UIImage.FromFile("start.png"), UIControlState.Disabled);
			//startButton.TintColor = UIColor.Black;
			startButton.Frame = new CGRect(100, 240, 40, 40);
			startButton.TouchUpInside += (sender, e) =>
			{
				startButton.Enabled = false;
				stopButton.Enabled = true;

			};
			stopButton = UIButton.FromType(UIButtonType.RoundedRect);
			stopButton.SetImage(UIImage.FromFile("stop.png"), UIControlState.Normal);
			//stopButton.SetImage(UIImage.FromFile("stop.png"), UIControlState.Disabled);
			//stopButton.TintColor = UIColor.Black;
			stopButton.Frame = new CGRect(170, 240, 40, 40);
			stopButton.TouchUpInside += (sender, e) =>
			{
				stopButton.Enabled = false;
				startButton.Enabled = true;

			};

			checkButton = UIButton.FromType(UIButtonType.Custom);
			checkButton.SetImage(UIImage.FromFile("Checkbox0.png"), UIControlState.Normal);
			checkButton.SetImage(UIImage.FromFile("Checkbox1.png"), UIControlState.Selected);
			//checkButton.TintColor = UIColor.Black;
			checkButton.Frame = new CGRect(240, 243, 32, 32);
			checkButton.TouchUpInside += (sender, e) =>
			{
				checkButton.Selected = !checkButton.Selected;

				//new UIAlertView("Notice"
				//	, "This task marks as completed!"
				//	, null
				//	, "OK"
				//	, null).Show();
			};


			string[] tableItems = new string[] { "/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Draft",
				"/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Draft",
				"/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Team Walkthrough",
				"/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / UI experiment/Refine",
				"/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Task2 / Publish", 
				"/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Refine", 
				"/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Draft", 
				"/ Project / Mobile App I1 / High Level Design Document / View Logic / UI experiment / Publish"};

			RecentTaskTable = new UITableView(new CGRect(25, 290, View.Bounds.Width - 50, View.Bounds.Height - 300 ));
			RecentTaskTable.Source = new TaskTableSource(tableItems,this);

			View.Add(RecentTaskTable);

		
			View.AddSubview(startButton);
			View.AddSubview(stopButton);
			View.AddSubview(checkButton);
			View.Add(ProjectNameLabel);
			this.Add(CurrentTaskLabel);
			this.Add(CurrentTaskNameLabel);


		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			// set the View Controller that’s powering the screen we’re
			// transitioning to
			if (segue.Identifier == "home2taskDetailsSegue")
			{
				var detailContoller = segue.DestinationViewController as TaskDetailsViewController;
				var indexPath = (NSIndexPath)sender;
			}

		}


    }
}