using System.Collections.ObjectModel;
using diabetica.Model;

namespace diabetica.ViewModel
{
	public class OrderInfoRepository
	{
	    public ObservableCollection<OrderInfo> OrderInfoCollection 
        {
			get => OrderInfo;
	        private set => this.OrderInfo = value;
		}

	    private ObservableCollection<OrderInfo> OrderInfo { get; set; }

	    public OrderInfoRepository ()
		{
			OrderInfoCollection = new ObservableCollection<OrderInfo> ();
			this.GenerateDiabetumGridContent ();
		}

		private void GenerateDiabetumGridContent ()
		{
		    OrderInfoCollection.Add(new OrderInfo("  0", "<", " 60", " 0", " 0", " 0", " 0"));
		    OrderInfoCollection.Add(new OrderInfo(" 60", "<", " 90", " 0", " 0", " 0", " 0"));
		    OrderInfoCollection.Add(new OrderInfo(" 90", "<", "120", "13", " 6", " 8", " 0"));
		    OrderInfoCollection.Add(new OrderInfo("120", "<", "150", "13", " 6", " 8", " 0"));
		    OrderInfoCollection.Add(new OrderInfo("150", "<", "180", "14", " 7", " 9", " 0"));
		    OrderInfoCollection.Add(new OrderInfo("180", "<", "210", "15", " 8", "10", " 0"));
		    OrderInfoCollection.Add(new OrderInfo("210", "<", "240", "16", " 9", "11", " 2"));
		    OrderInfoCollection.Add(new OrderInfo("240", "<", "270", "17", "10", "12", " 2"));
		    OrderInfoCollection.Add(new OrderInfo("270", "<", "300", "18", "11", "13", " 4"));
		    OrderInfoCollection.Add(new OrderInfo("300", "<", "900", "19", "12", "14", " 4"));
        }
	}
}

