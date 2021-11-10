using Avalonia.Data.Converters;

namespace TreeViewAvalonia
{
	public class BoolConverters 
	{
		public static readonly IValueConverter Inverse = new FuncValueConverter<bool,bool>((b) => !b);
	}
}
