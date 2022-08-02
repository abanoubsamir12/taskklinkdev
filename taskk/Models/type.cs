namespace taskk.Models
{
	public class type
	{
        public type()
        {
            typelist = new List<Itemlist>() {
                 new Itemlist { Text = "tv", Value = 1 },
                 new Itemlist { Text = "laptop", Value = 2 },
                 new Itemlist { Text = "sound system", Value = 3 },
             };
        }

public int Id { get; set; }
		public static List<Itemlist> typelist { get; set; } = new List<Itemlist>() {
                 new Itemlist { Text = "tv", Value = 1 },
                 new Itemlist { Text = "laptop", Value = 2 },
                 new Itemlist { Text = "sound system", Value = 3 },
             };
    }
}
