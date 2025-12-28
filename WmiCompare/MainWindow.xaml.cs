using System.Diagnostics;
using System.Management;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WmiLight;

namespace WmiCompare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        record Property
        {
            public string? Name { get; set; }

            public Type? Type { get; set; }
            public string? Value { get; set; }

            public bool Error { get; set; }
        }

        private static string? ObjectValueToString(object? value)
        {
            if (value is null)
                return "null";

            if (value is Array valueAsArray)
            {
                List<string> strings = new List<string>();

                foreach (var arrayItem in valueAsArray)
                {
                    if (arrayItem is string)
                        strings.Add($"\"{arrayItem.ToString()}\"");
                    else
                        strings.Add(arrayItem.ToString() ?? "null");

                }
                return "{ " +string.Join(",", strings) + " }";
            }

            return value.ToString();
        }

        private void LeftListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            GetScrollViewer(this.RightListView)?.ScrollToVerticalOffset(e.VerticalOffset);
        }

        private void RightListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            GetScrollViewer(this.LeftListView)?.ScrollToVerticalOffset(e.VerticalOffset);
        }

        public static ScrollViewer? GetScrollViewer(UIElement? element)
        {
            if (element == null)
                return null;

            ScrollViewer? retour = null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element) && retour == null; i++)
            {
                if (VisualTreeHelper.GetChild(element, i) is ScrollViewer)
                {
                    retour = (ScrollViewer)(VisualTreeHelper.GetChild(element, i));
                }
                else
                {
                    retour = GetScrollViewer(VisualTreeHelper.GetChild(element, i) as UIElement);
                }
            }

            return retour;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QueryTextBox.Foreground = SystemColors.ControlTextBrush;

            try
            {
                this.LeftListView.Items.Clear();
                this.RightListView.Items.Clear();

                int leftCount = 0, rightCount = 0;
                int leftPropCount = 0, rightPropCount = 0;

                Stopwatch stopwatch = Stopwatch.StartNew();

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(this.QueryTextBox.Text);
                ManagementObjectCollection retObjectCollection = searcher.Get();


                foreach (ManagementObject retObject in retObjectCollection)
                {
                    if (leftCount++ == 0)
                    {
                        foreach (PropertyData prop in retObject.Properties)
                        {
                            leftPropCount++;
                            this.LeftListView.Items.Add(new Property() { Name = prop.Name, Type = prop.Value?.GetType(), Value = ObjectValueToString(prop.Value) });
                        } 
                    }
                }

                stopwatch.Stop();

                this.LeftRecordCountTextBlock.Text = $"Record Count: {retObjectCollection.Count}";
                this.LeftPropertyCountTextBlock.Text = $"Property Count: {leftPropCount}";
                this.LeftQueryDurationTextBlock.Text = $"Query Duration: {(int)stopwatch.ElapsedMilliseconds} ms";

                stopwatch.Restart();

                Stopwatch stopwatch2 = Stopwatch.StartNew();

                using (WmiConnection connection = new WmiConnection())
                {
                    foreach (WmiObject partition in connection.CreateQuery(this.QueryTextBox.Text))
                    {
                        if (rightCount++ == 0)
                        {
                            foreach (string propertyName in partition.GetPropertyNames())
                            {
                                rightPropCount++;
                                var value = partition.GetPropertyValue(propertyName);
                                this.RightListView.Items.Add(new Property() { Name = propertyName, Type = value?.GetType(), Value = ObjectValueToString(value) });
                            }
                        }
                    }
                }

                stopwatch.Stop();

                this.RightRecordCountTextBlock.Text = $"Record Count: {rightCount}";
                this.RightPropertyCountTextBlock.Text = $"Property Count: {rightPropCount}";
                this.RightQueryDurationTextBlock.Text = $"Query Duration: {(int)stopwatch.ElapsedMilliseconds} ms";


                for (int i = 0; i < int.Max(this.RightListView.Items.Count, this.LeftListView.Items.Count); i++)
                {
                    if (this.RightListView.Items.Count < (i + 1))
                    {
                        ((Property)this.LeftListView.Items[i]).Error = true;
                    }
                    else if (this.LeftListView.Items.Count < (i + 1))
                    {
                        ((Property)this.RightListView.Items[i]).Error = true;
                    }
                    else
                    {
                        Property left = (Property)this.LeftListView.Items[i];
                        Property right = (Property)this.RightListView.Items[i];

                        if (left.Type != right.Type || left.Value != right.Value)
                        {
                            left.Error = right.Error = true;
                        }
                    }
                }
            }
            catch (ManagementException ex) when (ex.Message.Trim() == "Invalid query" || ex.Message.Trim() == "Invalid class")
            {
                this.LeftListView.Items.Clear();
                this.RightListView.Items.Clear();

                QueryTextBox.Foreground = Brushes.Red;

            }
            catch (Exception ex)
            {
                this.LeftListView.Items.Clear();
                this.RightListView.Items.Clear();

                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}