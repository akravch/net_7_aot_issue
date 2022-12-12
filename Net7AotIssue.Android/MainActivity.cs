namespace Net7AotIssue.Android
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }

    public class ProblematicClass<T>
    {
        public Type ProblematicMethod(int i)
        {
            return i == 0 ? typeof(T) : null;
        }
    }
}