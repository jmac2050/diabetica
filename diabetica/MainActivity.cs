using Android.App;
using Android.OS;
using diabetica.ViewModel;
using Syncfusion.SfDataGrid;

namespace diabetica
{
    [Activity(Label = "diabetica by jMaczioch 2019 R0220", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var sfgrid = FindViewById<SfDataGrid>(Resource.Id.sfDataGrid);

            sfgrid.AutoGeneratingColumn += HandleAutoGeneratingColumn;

            var viewModel = new OrderInfoRepository();
            sfgrid.ItemsSource = viewModel.OrderInfoCollection;
            sfgrid.GridStyle = new Dark();

            sfgrid.AutoGeneratingColumn += HandleAutoGeneratingColumn;
        }

        public void HandleAutoGeneratingColumn(object sender, AutoGeneratingColumnEventArgs e)
        {
            var cellWidth = 50;
            var fontHeaderSize = 18;
            var cellTextSize = 16;

            switch (e.Column.MappingName)
            {
                case "Min":
                    e.Column.HeaderText = "min";
                    e.Column.Width = cellWidth;
                    e.Column.HeaderCellTextSize = fontHeaderSize;
                    e.Column.CellTextSize = cellTextSize;
                    break;
                case "Part":
                    e.Column.HeaderText = "bis";
                    e.Column.Width = cellWidth;
                    e.Column.HeaderCellTextSize = fontHeaderSize;
                    e.Column.CellTextSize = cellTextSize;
                    break;
                case "Max":
                    e.Column.HeaderText = "max";
                    e.Column.Width = cellWidth;
                    e.Column.HeaderCellTextSize = fontHeaderSize;
                    e.Column.CellTextSize = cellTextSize;
                    break;
                case "Mo":
                    e.Column.HeaderText = "mo";
                    e.Column.Width = cellWidth;
                    e.Column.HeaderCellTextSize = fontHeaderSize;
                    e.Column.CellTextSize = cellTextSize;
                    break;
                case "Mi":
                    e.Column.HeaderText = "mi";
                    e.Column.Width = cellWidth;
                    e.Column.HeaderCellTextSize = fontHeaderSize;
                    e.Column.CellTextSize = cellTextSize;
                    break;
                case "Ab":
                    e.Column.HeaderText = "ab";
                    e.Column.Width = cellWidth;
                    e.Column.HeaderCellTextSize = fontHeaderSize;
                    e.Column.CellTextSize = cellTextSize;
                    break;
                case "Sp":
                    e.Column.HeaderText = "sp";
                    e.Column.Width = cellWidth;
                    e.Column.HeaderCellTextSize = fontHeaderSize;
                    e.Column.CellTextSize = cellTextSize;
                    break;
            }
        }
    }
}

