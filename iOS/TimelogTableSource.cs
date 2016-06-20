using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using System.IO;
using System.Linq;
using CoreGraphics;
using System.Drawing;


namespace ProcessDashboard.iOS
{
	public class TimelogTableSource : UITableViewSource
	{
		protected string cellIdentifier = "TableCell";

		Dictionary<string, List<TimelogTableItem>> indexedTableItems;
		string[] keys;
		TimeLogPageViewController owner;

		public TimelogTableSource(List<TimelogTableItem> items, TimeLogPageViewController owner)
		{
			this.owner = owner;

			indexedTableItems = new Dictionary<string, List<TimelogTableItem>>();
			foreach (var t in items)
			{
				if (indexedTableItems.ContainsKey(t.SubHeading))
				{
					indexedTableItems[t.SubHeading].Add(t);
				}
				else {
					indexedTableItems.Add(t.SubHeading, new List<TimelogTableItem>() { t });
				}
			}
			keys = indexedTableItems.Keys.ToArray();
		}


		/// <summary>
		/// Called by the TableView to determine how many sections(groups) there are.
		/// </summary>
		public override nint NumberOfSections(UITableView tableView)
		{
			return keys.Length;
		}

		/// <summary>
		/// Called by the TableView to determine how many cells to create for that particular section.
		/// </summary>
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return indexedTableItems[keys[section]].Count;
		}


		/// <summary>
		/// The string to show in the section header
		/// </summary>
		public override string TitleForHeader(UITableView tableView, nint section)
		{
			return keys[section];
		}


		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{

			// Display view
			owner.PerformSegue("detailSegue", indexPath);

			////UIAlertController okAlertController = UIAlertController.Create("Row Selected", indexedTableItems[keys[indexPath.Section]][indexPath.Row].Heading, UIAlertControllerStyle.Alert);
			////okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
			////owner.PresentViewController(okAlertController, true, null);

			tableView.DeselectRow(indexPath, true);
		}

		/// <summary>
		/// Called by the TableView to get the actual UITableViewCell to render for the particular section and row
		/// </summary>
		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			//---- declare vars
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			TimelogTableItem item = indexedTableItems[keys[indexPath.Section]][indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			//{ cell = new UITableViewCell(item.CellStyle, cellIdentifier); }
			{ cell = new UITableViewCell(UITableViewCellStyle.Value1, cellIdentifier);}

			//---- set the item text
			cell.TextLabel.Text = item.Heading;
			cell.DetailTextLabel.Text = item.SubHeading;
			cell.TextLabel.Font = UIFont.SystemFontOfSize(12);
			cell.DetailTextLabel.Font = UIFont.SystemFontOfSize(10);
			cell.TextLabel.Lines = 1;
			var bounds = cell.TextLabel.Bounds;
			bounds.Size = new Size(30, 23);
			cell.TextLabel.Bounds = bounds;
			cell.TextLabel.TextColor = UIColor.Black;
			cell.TextLabel.LineBreakMode = UILineBreakMode.HeadTruncation;

			//---- if the item has a valid image, and it's not the contact style (doesn't support images)
			if (!string.IsNullOrEmpty(item.ImageName) && item.CellStyle != UITableViewCellStyle.Value2)
			{
				if (File.Exists(item.ImageName))
				{ cell.ImageView.Image = UIImage.FromBundle(item.ImageName); }
			}
		
			//---- set the accessory
			cell.Accessory = item.CellAccessory;

			return cell;
		}
	}
}

