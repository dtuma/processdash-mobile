using Android.OS;
using Android.Views;
using ProcessDashboard.Droid.Fragments;
using Android.App;

namespace ProcessDashboard.Droid
{
    [Android.App.Activity(Label = "Process Dashboard", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Android.Support.V7.App.AppCompatActivity
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
        private ListOfTasks ListOfTasksFragment;

        private Fragment CurrentFragment;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            LoginFragment = new Login();
            HomeFragment = new Home();
            SettingsFragment = new Settings();
            GlobalTimeLogFragment = new GlobalTimeLog();
            GlobalTimeLogDetailFragment = new GlobalTimeLogDetail();
            ListOfProjectFragment = new ListOfProjects();
            TaskDetailFragment = new TaskDetails();
            TaskTimeLogDetailFragment = new TaskTimeLogDetail();
            ListOfTasksFragment = new ListOfTasks();


            // if logged in
            CurrentFragment = HomeFragment;
            // else 
            //CurrentFragment = HomeFragment;

            FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction();
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
            FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction();
            // The fragment will have the ID of Resource.Id.fragment_container.
            fragmentTx.Replace(Resource.Id.fragmentContainer, fragment);
            // Commit the transaction.
            fragmentTx.AddToBackStack(null);

            fragmentTx.Commit();
        }

        public override void OnBackPressed()
        {

            if (FragmentManager.BackStackEntryCount > 0)
            {
                FragmentManager.PopBackStack();
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
                    ShowFragment(SettingsFragment);
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
}


