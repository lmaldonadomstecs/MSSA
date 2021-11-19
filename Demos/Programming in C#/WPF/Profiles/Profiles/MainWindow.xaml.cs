using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Profiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Profile profile1;
        Profile profile2;
        Profile profile3;
        Profile profile4;

        public MainWindow()
        {
            profile1 = new Profile();
            profile2 = new Profile(autoAim: true);
            profile3 = new Profile(resolution: "1024x768");
            profile4 = new Profile(brightness: 75);
            InitializeComponent();
            settingsWindow.Visibility = Visibility.Hidden;
        }

        private void changeProfile(object sender, RoutedEventArgs e)
        {
            if (mainLabel.IsEnabled)
            {
                mainLabel.IsEnabled = false;
                mainLabel.Visibility = Visibility.Hidden;
                settingsWindow.Visibility = Visibility.Visible;
            }

            Button button = sender as Button;
            string buttonName = button.Content.ToString();
            switch (buttonName)
            {
                case "Profile 1":
                    DataContext = profile1;
                    updateDifficultyUI();
                    break;
                case "Profile 2":
                    DataContext = profile2;
                    updateDifficultyUI();
                    break;
                case "Profile 3":
                    DataContext = profile3;
                    updateDifficultyUI();
                    break;
                case "Profile 4":
                    DataContext = profile4;
                    updateDifficultyUI();
                    break;
            }
        }

        private Profile verifyCurrentProfile()
        {
            if (DataContext == profile2)
            {
                return profile2;
            }
            else if (DataContext == profile3)
            {
                return profile3;
            }
            else if (DataContext == profile4)
            {
                return profile4;
            }
            else
            {
                return profile1;
            }
        }

        private void changeDifficulty(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(sender);
            RadioButton radio = sender as RadioButton;
            string difficulty = radio.Content.ToString();

            Profile currentProfile = verifyCurrentProfile();

            if (difficulty == "Easy")
            {
                currentProfile.Difficulty = difficulty;
            }
            else if (difficulty == "Normal")
            {
                currentProfile.Difficulty = difficulty;
            }
            else if (difficulty == "Hard")
            {
                currentProfile.Difficulty = difficulty;
            }
        }

        private void updateDifficultyUI()
        {
            Profile currentProfile = verifyCurrentProfile();

            if (currentProfile.Difficulty == "Easy")
            {
                difficulty_easy.IsChecked = true;
            }
            else if (currentProfile.Difficulty == "Normal")
            {
                difficulty_normal.IsChecked = true;
            }
            else if (currentProfile.Difficulty == "Hard")
            {
                difficulty_hard.IsChecked = true;
            }
        }
    }
}
