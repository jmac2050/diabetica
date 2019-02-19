using Android.Graphics;
using Syncfusion.SfDataGrid;

namespace diabetica
{
    class Dark : DataGridStyle
    {
        public Dark()
        {
        }

        public override Color GetHeaderBackgroundColor()
        {
            return Color.Purple; //.Rgb(15, 15, 15);
        }

        public override Color GetHeaderForegroundColor()
        {
            return Color.Yellow; //.Rgb(255, 255, 255);
        }

        public override Color GetRecordBackgroundColor()
        {
            return Color.Rgb(43, 43, 43);
        }

        public override Color GetRecordForegroundColor()
        {
            return Color.Yellow; //.Rgb(255, 255, 255);
        }
             
        public override Color GetBorderColor()
        {
            return Color.White; //.Rgb(81, 83, 82);
        }
      
        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.Blue;
        }
    }
}