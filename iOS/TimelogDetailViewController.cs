using Foundation;
using System;
using UIKit;
using CoreGraphics;
using System.Drawing;

namespace ProcessDashboard.iOS
{
    public partial class TimelogDetailViewController : UIViewController
    {
        public TimelogDetailViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			var TaskNameLabel = new UILabel(new CGRect(30, 100, 300, 60))
			{
				Text = "/Project/Mobile App I1/High Level Design Document/View Logic/UI Experiment/Team Walkthrough",
				Font = UIFont.SystemFontOfSize(14),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.LightTextColor,
				Lines = 0,
				LineBreakMode = UILineBreakMode.WordWrap,
			};

			// 
			var StartTimeLabel = new UILabel(new CGRect(30, 180, 300, 20))
			{
				Text = "Start Time",
				Font = UIFont.SystemFontOfSize(13),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.FromRGB(220, 220, 220),
			};

			var StartTimeText = new UITextField(new CGRect(30, 220, 300, 20))
			{
				Text = "2016-06-02 10:20:23 AM",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.LightGray,
				TextAlignment = UITextAlignment.Center,
				//BackgroundColor = UIColor.LightGray,

			};

			// 
			var DeltaLabel = new UILabel(new CGRect(30, 250, 300, 20))
			{
				Text = "Delta",
				Font = UIFont.SystemFontOfSize(13),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.FromRGB(220, 220, 220),

			};

			var DeltaText = new UITextField(new CGRect(30, 290, 300, 20))
			{
				Text = "1:20",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.LightGray,
				TextAlignment = UITextAlignment.Center,
				//BackgroundColor = UIColor.LightGray,

			};


			// 

			var IntLabel = new UILabel(new CGRect(30, 320, 300, 20))
			{
				Text = "Int",
				Font = UIFont.SystemFontOfSize(13),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.FromRGB(220, 220, 220),
			};


			var IntText = new UITextField(new CGRect(30, 360, 300, 20))
			{
				Text = "00:00",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.LightGray,
				TextAlignment = UITextAlignment.Center,
				//BackgroundColor = UIColor.LightGray,

			};

			//
			var CommentLabel = new UILabel(new CGRect(30, 390, 300, 20))
			{
				Text = "Comment",
				Font = UIFont.SystemFontOfSize(13),
				TextColor = UIColor.Black,
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.FromRGB(220,220,220),

			};

			var CommentText = new UITextView(new CGRect(30, 420, 300, 100))
			{
				Text = "The comment just for testing.The comment just for testing.The comment just for testing.The comment just for testing.",
				Font = UIFont.SystemFontOfSize(12),
				TextColor = UIColor.LightGray,
				TextAlignment = UITextAlignment.Left,
				Editable = true,
				//BackgroundColor = UIColor.LightGray,
	
			};

			this.Add(TaskNameLabel);
			this.Add(StartTimeLabel);
			this.Add(StartTimeText);
			this.Add(DeltaLabel);
			this.Add(DeltaText);
			this.Add(IntLabel);
			this.Add(IntText);
			this.Add(CommentLabel);
			this.Add(CommentText);

		}

    }
}