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
using Android.Graphics;

namespace DrawPolygon.Helper
{
    class FilledPolygon : View
    {
        private readonly PointF[] _points = new[] {
        new PointF(100, 100),
            new PointF(200, 200),
            new PointF(200, 500),
            new PointF(600, 600),
            new PointF(400, 200),
            new PointF(100, 100)
    };
        public FilledPolygon(Context context) : base(context) { }
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            var path = new Path();
            path.MoveTo(_points[0].X, _points[0].Y);
            for (var i = 1; i < _points.Length; i++)
            {
                path.LineTo(_points[i].X, _points[i].Y);
            }
            var paint = new Paint
            {
                Color = Color.White
            };
            paint.SetStyle(Paint.Style.Fill);
            canvas.DrawPath(path, paint);
        }
    }
}