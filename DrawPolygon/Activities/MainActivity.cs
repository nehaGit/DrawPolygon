using Android.App;
using Android.Widget;
using Android.OS;

namespace DrawPolygon
{
    [Activity(Label = "DrawPolygon", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        #region variables
        Button btnPolygon, btnGraphics, btnAnimation, btnImage;

        #endregion
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);

            btnPolygon = FindViewById<Button>(Resource.Id.btnPolygon);
            btnPolygon.Click += ((sender,e)=>{

                StartActivity(typeof(Polygon));
            });
        }
    }
}

