
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace ProcessDashboard.Droid.Fragments
{
    public class ListOfTasks : ListFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
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