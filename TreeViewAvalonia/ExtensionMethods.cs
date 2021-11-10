using System.Linq;
using Avalonia.VisualTree;
using System.Collections;
using System;

namespace TreeViewAvalonia
{
    static class ExtensionMethods
	{
		public static T FindAncestor<T>(this IVisual d) where T : class
		{
			return d.GetVisualAncestors().OfType<T>().FirstOrDefault();
		}

		public static void AddOnce(this IList list, object item)
		{
			if (!list.Contains(item)) {
				list.Add(item);
			}
		}

		public static bool Any(this IEnumerable list)
		{
			var enumerator = list.GetEnumerator();
			var result = enumerator.MoveNext();
			(enumerator as IDisposable)?.Dispose();

			return result;
		}
	}
}
