﻿using System;
using UIKit;

namespace ProcessDashboard.iOS
{
	public class TimelogTableItem
	{
		public string Heading { get; set; }

		public string SubHeading { get; set; }

		public string ImageName { get; set; }

		public UITableViewCellStyle CellStyle
		{
			get { return cellStyle; }
			set { cellStyle = value; }
		}
		protected UITableViewCellStyle cellStyle = UITableViewCellStyle.Default;

		public UITableViewCellAccessory CellAccessory
		{
			get { return cellAccessory; }
			set { cellAccessory = value; }
		}
		protected UITableViewCellAccessory cellAccessory = UITableViewCellAccessory.None;

		public TimelogTableItem() { }

		public TimelogTableItem(string heading)
		{ Heading = heading; }
	}

}

