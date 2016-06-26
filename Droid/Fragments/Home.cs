using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.App;

namespace ProcessDashboard.Droid.Fragments
{
    public class Home : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View v = inflater.Inflate(Resource.Layout.Home, container, false);
            ListView lv = v.FindViewById<ListView>(Resource.Id.recentTaskList_Home);
            loadDummyData(lv);
            return v;
        }

        private void loadDummyData(ListView lv)
        {
            string[] items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };

            ArrayAdapter ListAdapter = new ArrayAdapter<String>(this.Activity, Android.Resource.Layout.SimpleListItem1, items);

            lv.Adapter = ListAdapter;


        }
    }
}