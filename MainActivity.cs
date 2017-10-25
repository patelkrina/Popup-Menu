using Android.App;
using Android.Widget;
using Android.OS;

namespace Pop_up_Menu
{
    [Activity(Label = "Pop_up_Menu", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button popup_btn = FindViewById<Button>(Resource.Id.popup_btn);

            int a = 1;
            int b = 99;
            int result=0;
            popup_btn.Click += delegate
            {

                Toast.MakeText(this, "display text", ToastLength.Long).Show();
                PopupMenu menu = new PopupMenu(this, popup_btn);
                menu.Inflate(Resource.Menu.popup_menu);
                menu.MenuItemClick += (s1, a1) =>
                {
                    Toast.MakeText(this, a1.Item.TitleFormatted.ToString(), ToastLength.Long).Show();
                    

                    switch (a1.Item.TitleFormatted.ToString())
                    {
                        case "+":
                            result = a + b;
                            //Toast.MakeText(this, result, ToastLength.Long).Show();
                            break;
                        case "-":
                            result = a - b;
                            //Toast.MakeText(this, result, ToastLength.Long).Show();
                            break;
                        case "*":
                            result = a * b;
                            //Toast.MakeText(this, "result", ToastLength.Long).Show();
                            break;
                        case "/":
                            result = a / b;
                            //Toast.MakeText(this, "result", ToastLength.Long).Show();
                            break;
                    }
                    Toast.MakeText(this, "result", ToastLength.Long).Show();
                };
                menu.Show();
            };
        }
    }
}

