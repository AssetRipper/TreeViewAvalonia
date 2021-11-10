using Avalonia.Controls.Primitives;
using Avalonia;

namespace TreeViewAvalonia
{
    public class GeneralAdorner : VisualLayerManager
	{
		public GeneralAdorner()
		{
		}

		protected override Size MeasureOverride(Size constraint)
		{
			if (Child != null) {
				Child.Measure(constraint);
				return Child.DesiredSize;
			}
			return new Size();
		}

		protected override Size ArrangeOverride(Size finalSize)
		{
			if (Child != null) {
				Child.Arrange(new Rect(finalSize));
				return finalSize;
			}
			return new Size();
		}
	}
}
