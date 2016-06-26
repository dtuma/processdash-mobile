using Android.Widget;
using Android.OS;
using Android.Views;

using System.Collections.Generic;

using SupportFragment = Android.App.Fragment;

using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using ProcessDashboard.Droid.Fragments;

namespace ProcessDashboard.Droid
{
    [Android.App.Activity(Label = "Process Dashboard", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Android.Support.V7.App.AppCompatActivity
    {
    

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            


        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.action_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }


    }
}


