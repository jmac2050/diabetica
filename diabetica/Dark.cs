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
            return Color.Purple; 
        }

        public override Color GetHeaderForegroundColor()
        {
            return Color.Yellow; 
        }

        public override Color GetRecordBackgroundColor()
        {
            return Color.Rgb(43, 43, 43);
        }

        public override Color GetRecordForegroundColor()
        {
            return Color.Yellow;
        }

        public override Color GetBorderColor()
        {
            return Color.White;
        }
      
        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.Blue;
        }
    }
}