
using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace ProcessDashboard.Droid.Fragments
{
	public class ListProjectTasks : Fragment
	{
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.Home, container, false);
			ListView listView = view.FindViewById<ListView>(Resource.Id.tasksListView);
			loadDummyData(listView);
			return view;

		}

		private void loadDummyData(ListView listView)
		{
			string[] items = new string[] { "Sample Task", "Component 1 / Component 2 / Code", "... / head truncation" };
			ArrayAdapter ListAdapter = new ArrayAdapter<String>(this.Activity, Android.Resource.Layout.SimpleListItem1, items);
			listView.Adapter = ListAdapter;
		}
	}
}