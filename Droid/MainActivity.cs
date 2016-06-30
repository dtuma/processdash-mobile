using Android.OS;
using Android.Views;
using ProcessDashboard.Droid.Fragments;
using Android.Runtime;
using Android.Support.Design.Widget;
using Java.Lang;
using Android.Support.V4.App;

namespace ProcessDashboard.Droid
{
    [Android.App.Activity(Label = "Process Dashboard", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : FragmentActivity
    {

        public enum fragmentTypes { login, home, settings, listofprojects, listoftasks, taskdetails, tasktimelogdetails, globaltimelog, globaltimelogdetails };
        private Home HomeFragment;
        private Login LoginFragment;
        private Settings SettingsFragment;
        private GlobalTimeLog GlobalTimeLogFragment;
        private GlobalTimeLogDetail GlobalTimeLogDetailFragment;
        private ListOfProjects ListOfProjectFragment;
        private TaskDetails TaskDetailFragment;
        private TaskTimeLogDetail TaskTimeLogDetailFragment;
        private ListProjectTasks ListOfTasksFragment;

        private Fragment CurrentFragment;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);
            //ActionBar.Title = "Process Dashboard";

            var fragments = new Fragment[]
          {
            HomeFragment, ListOfProjectFragment, GlobalTimeLogFragment
          };


            var titles = CharSequence.ArrayFromStringArray(new[]
                {
                    "Home","Projects","Time Log"
                });


            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewpager);
            viewPager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, fragments, titles);

            // Give the TabLayout the ViewPager
            var tabLayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            tabLayout.SetupWithViewPager(viewPager);


            LoginFragment = new Login();
            HomeFragment = new Home();
            SettingsFragment = new Settings();
            GlobalTimeLogFragment = new GlobalTimeLog();
            GlobalTimeLogDetailFragment = new GlobalTimeLogDetail();
            ListOfProjectFragment = new ListOfProjects();
            TaskDetailFragment = new TaskDetails();
            TaskTimeLogDetailFragment = new TaskTimeLogDetail();
            ListOfTasksFragment = new ListProjectTasks();


            // if logged in
            //CurrentFragment = HomeFragment;
            // else 
            CurrentFragment = LoginFragment;

            FragmentTransaction fragmentTx = this.SupportFragmentManager.BeginTransaction();
            // The fragment will have the ID of Resource.Id.fragment_container.
            fragmentTx.Replace(Resource.Id.fragmentContainer, CurrentFragment);
            // Commit the transaction.
            fragmentTx.Commit();


        }

        private void ShowFragment(Fragment fragment)
        {
            if (fragment.IsVisible)
            {
                return;
            }
            FragmentTransaction fragmentTx = this.SupportFragmentManager.BeginTransaction();
            // The fragment will have the ID of Resource.Id.fragment_container.
            fragmentTx.Replace(Resource.Id.fragmentContainer, fragment);
            // Commit the transaction.
            fragmentTx.AddToBackStack(null);

            fragmentTx.Commit();
        }

        public override void OnBackPressed()
        {

            if (SupportFragmentManager.BackStackEntryCount > 0)
            {
                SupportFragmentManager.PopBackStack();
                //CurrentFragment = mStackFragments.Pop();
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch(item.ItemId)
            {
                case Resource.Id.settings:
                    switchToFragment(fragmentTypes.settings);
                    return true;

                default:
                    return true;
            }

        }


        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.action_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public void switchToFragment(fragmentTypes fragmentType)
        {
            switch (fragmentType)
            {
                case fragmentTypes.home:
                    ShowFragment(HomeFragment);
                    break;
                case fragmentTypes.login:
                    ShowFragment(LoginFragment);
                    break;
                case fragmentTypes.settings:
                    //ShowFragment(SettingsFragment);
                    break;
                case fragmentTypes.listoftasks:
                    ShowFragment(ListOfTasksFragment);
                    break;
                case fragmentTypes.globaltimelog:
                    ShowFragment(GlobalTimeLogFragment);
                    break;
                case fragmentTypes.globaltimelogdetails:
                    ShowFragment(GlobalTimeLogDetailFragment);
                    break;
                case fragmentTypes.listofprojects:
                    ShowFragment(ListOfProjectFragment);
                    break;
                case fragmentTypes.taskdetails:
                    ShowFragment(TaskDetailFragment);
                    break;
                case fragmentTypes.tasktimelogdetails:
                    ShowFragment(TaskTimeLogDetailFragment);
                    break;

            }
        }

    }

    public class TabsFragmentPagerAdapter : FragmentPagerAdapter
    {
        private readonly Fragment[] fragments;

        private readonly ICharSequence[] titles;

        public TabsFragmentPagerAdapter(FragmentManager fm, Fragment[] fragments, ICharSequence[] titles) : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
        }
        public override int Count
        {
            get
            {
                return fragments.Length;
            }
        }

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return titles[position];
        }
    }
}


