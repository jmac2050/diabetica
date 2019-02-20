namespace diabetica.Model
{
	public class OrderInfo
	{
	    public string Min { get; set; }
	    public string Part { get; set; }
	    public string Max { get; set; }
	    public string Mo { get; set; }
	    public string Mi { get; set; }
	    public string Ab { get; set; }
	    public string Sp { get; set; }

	    public OrderInfo (string min, string part, string max, string mo, string mi, string ab, string sp)
		{
			this.Min = min;
			this.Part = part;
		    this.Max = max;
		    this.Mo = mo;
            this.Mi = mi;
		    this.Ab = ab;
		    this.Sp = sp;
        }
	}
}

