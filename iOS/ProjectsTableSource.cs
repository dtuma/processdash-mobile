using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ProcessDashboard.iOS
{
	public class ProjectsTableSource : UITableViewSource
	{

		string[] TableItems;
		string CellIdentifier = "TableCell";


		public ProjectsTableSource(string[] items)
		{
			TableItems = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{

			return TableItems.Length;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			
			tableView.DeselectRow(indexPath, true);
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{

			var cell = tableView.DequeueReusableCell(CellIdentifier);
			string item = TableItems[indexPath.Row];
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);

			//populate the cell with the appropriate data based on the indexPath
			cell.TextLabel.Text = item;
			//	cell.TextLabel.LineBreakMode = UILineBreakMode.WordWrap;
			//	cell.TextLabel.Lines = 0;
			//cell.TextLabel.SizeToFit ();
			cell.TextLabel.Font = UIFont.SystemFontOfSize(10);
			cell.TextLabel.Lines = 1;
			cell.TextLabel.TextColor = UIColor.Black;
			cell.TextLabel.LineBreakMode = UILineBreakMode.HeadTruncation;
			return cell;


		}
	}
}


