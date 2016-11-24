using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DrawPolygon.Helper;

namespace DrawPolygon
{
    [Activity(Label = "Polygon")]
    public class Polygon : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.polygon);
            SetContentView(new FilledPolygon(this));
        }
    }
}