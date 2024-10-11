using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DailyCheckbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddCheckBoxTextRows();
        }

        List<string> todoList = new List<string>
{
    "1. Finish writing the project report",
    "2. Schedule meeting with team",
    "3. Update client on project status",
    "4. Review and merge pull requests",
    "5. Refactor the login authentication module",
    "6. Research new UI design trends",
    "7. Test the payment gateway integration",
    "8. Optimize database queries",
    "9. Backup the server",
    "10. Write unit tests for the new feature",
    "11. Fix the CSS issues in the dashboard",
    "12. Prepare presentation for Monday's meeting",
    "13. Respond to pending emails",
    "14. Create deployment pipeline for production",
    "15. Update project documentation",
    "16. Schedule code review for next sprint"
};





        // Method to create and add StackPanel with CheckBox and TextBlock
        private void AddCheckBoxTextRows()
        {
            int rowCounter = 0;
            foreach (string todo in todoList) // Loop to add up to 16 rows
            {
                rowCounter++;
                // Create StackPanel
                StackPanel stackPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    VerticalAlignment = VerticalAlignment.Center,
                    Margin = new Thickness(0, 0, 10, 0)
                };

                // Create TextBlock
                TextBlock textBlock = new TextBlock
                {
                    Text = $"{rowCounter} days streak",
                    VerticalAlignment = VerticalAlignment.Center,
                    FontSize = 18,
                    MinWidth = 130,
                };

                // Create CheckBox
                CheckBox checkBox = new CheckBox
                {
                    VerticalAlignment = VerticalAlignment.Center,
                    FontSize = 25,
                    Margin = new Thickness(0, 0, 10, 0) // Add some margin between checkbox and text
                };

                // Attach Checked event handler to the CheckBox, using the current value of 'i'
                int rowIndex = rowCounter; // Capture the current value of i for use inside the lambda
                checkBox.Checked += (sender, e) =>
                {
                    MessageBox.Show($"CheckBox clicked in row: {rowIndex}");
                };

                // Handle the Unchecked event
                checkBox.Unchecked += (sender, e) =>
                {
                    MessageBox.Show($"CheckBox unchecked in row: {rowIndex}");
                };

                // Create TextBlock
                TextBox textBox = new TextBox
                {
                    Text = "Hello World",
                    VerticalAlignment = VerticalAlignment.Center,
                    FontSize = 18
                };

                // Add CheckBox and TextBlock to StackPanel
                stackPanel.Children.Add(textBlock);
                stackPanel.Children.Add(checkBox);
                stackPanel.Children.Add(textBox);

                // Add StackPanel to the Grid in the specified row
                DailyCheckboxGrid.Children.Add(stackPanel);
                Grid.SetRow(stackPanel, rowCounter); // Place the StackPanel in the i-th row
                Grid.SetColumn(stackPanel, 1); // Place the StackPanel in the second column

                if (rowCounter % 16 == 0)
                {
                    break;
                }

            }
        }
    }
}
