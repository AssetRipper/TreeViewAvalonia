using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TreeViewAvalonia;

namespace JsonViewer
{
    public partial class MainWindow : Window
    {
        internal SharpTreeView treeView;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            treeView = this.FindControl<SharpTreeView>("treeView");
        }
    }
}
