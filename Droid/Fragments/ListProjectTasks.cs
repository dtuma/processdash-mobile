
using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace ProcessDashboard.Droid.Fragments
{
    public class ProjectDetails : Fragment
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

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            loadDummyData();
            
        }

        public void loadDummyData()
        {
            string[] values = new[] { "Android", "iPhone", "WindowsMobile",
                "Blackberry", "WebOS", "Ubuntu", "Windows7", "Max OS X",
                "Linux", "OS/2" };
            this.ListAdapter = new Android.Widget.ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleExpandableListItem1, values);
        }

        public override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
            ListView.SetItemChecked(position, true);
            ((MainActivity)Activity).switchToFragment(MainActivity.fragmentTypes.taskdetails);
            
        }

      
    }
}