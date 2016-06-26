
using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace ProcessDashboard.Droid.Fragments
{
    public class ListOfProjects : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Home, container, false);
			ListView listView = view.FindViewById<ListView>(Resource.Id.projectsListView);
			loadDummyData(listView);
			return view;

        }

		private void loadDummyData(ListView listView)
		{
			string[] items = new string[] { "Sample Project", "Linux Kernel", "Windows 11 Ultimate", "Mobile Process Dashboard"};
			ArrayAdapter ListAdapter = new ArrayAdapter<String>(this.Activity, Android.Resource.Layout.SimpleListItem1, items);
			listView.Adapter = ListAdapter;
		}
    }
}