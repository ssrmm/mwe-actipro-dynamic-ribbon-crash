using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls.Ribbon.Controls;

namespace WpfApp31
{
    /// <summary>
    /// Interaction logic for DetailView.xaml
    /// </summary>
    public partial class DetailView
    {
        public DetailView()
        {
            InitializeComponent();
        }

        private void DetailView_OnLoaded(object sender, RoutedEventArgs e)
        {
            var tabControl = new TabControl
                                        {
                                            Items = {new TabItem {Header = "Tab1"}, new TabItem {Header = "Tab2"},}
                                        };
            tabControl.SelectionChanged += TabControlOnSelectionChanged;
            ContentControl.Content = tabControl;
        }

        private void TabControlOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var mainWindow = (MainWindow)Window.GetWindow(this);
            var ancestorRibbon = mainWindow.Ribbon;
            ancestorRibbon.ContextualTabGroups[0].Items.Add(new Tab {Label = "Bla"});
        }

        private void DetailView_OnUnloaded(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = null;
        }
    }
}
