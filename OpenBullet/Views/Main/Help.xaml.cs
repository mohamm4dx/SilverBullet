using System.Windows;
using System.Windows.Controls;

namespace OpenBullet.Views.Main
{
    /// <summary>
    /// Logica di interazione per About.xaml
    /// </summary>
    public partial class Help : Page
    {
        AboutPage aboutPage;
        ReleaseNotesPage releaseNotesPage;
        public Help()
        {
            InitializeComponent();
            aboutPage = new AboutPage();
            releaseNotesPage = new ReleaseNotesPage();
            Main.Content = aboutPage;
            menuOptionSelected(aboutLabel);
        }

        private void repoButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void docuButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void menuOptionSelected(object sender)
        {
            foreach (var child in topMenu.Children)
            {
                try
                {
                    var c = (Label)child;
                    c.Foreground = Utils.GetBrush("ForegroundMain");
                }
                catch { }
            }
         ((Label)sender).Foreground = Utils.GetBrush("ForegroundCustom");
        }

        //about 
        private void Label_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Main.Content = aboutPage;
            menuOptionSelected(sender);
        }

        //release notes
        private void Label_MouseLeftButtonUp_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Main.Content = releaseNotesPage;
            menuOptionSelected(sender);
        }

        private void checkForUpdateLabel_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                var result = CheckUpdate.Run(SB.updateUrl);
                if (result.Update)
                {
                    var notesWindow = new NotesWindow()
                    {
                        DontShowMainWindow = true,
                        SBUrl = result.Url,
                    };
                    notesWindow.titleLabel.Content += " " + result.Version;
                    for (var i = 0; i < result.Notes.Count; i++)
                    {
                        notesWindow.richTextBox.AppendText(result.Notes[i].Note + "\n");
                    }
                    notesWindow.Show();
                }
                else
                {
                    MessageBox.Show("actualmente no hay actualizaciones disponibles", "OpenBullet", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch { }
        }
    }
}
