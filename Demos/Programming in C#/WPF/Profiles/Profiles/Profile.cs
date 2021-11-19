using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiles
{
    class Profile : INotifyPropertyChanged
    {
        //// Events
        public event PropertyChangedEventHandler PropertyChanged;

        //// Fields
        private string difficulty;
        private bool autoAim;
        private string resolution;
        private int brightness;        

        //// Properties
        public string Difficulty
        {
            get { return difficulty; }
            set
            {
                difficulty = value;
                updateUI("Difficulty");
            }
        }
        public bool AutoAim
        {
            get { return autoAim; }
            set
            {
                autoAim = value;
                updateUI("AutoAim");
            }
        }
        public string Resolution
        {
            get { return resolution; }
            set
            {
                resolution = value;
                updateUI("Resolution");
            }
        }
        public int Brightness
        {
            get { return brightness; }
            set
            {
                brightness = value;
                updateUI("Brightness");
            }
        }

        //// Constructor
        public Profile(string difficulty = "Normal", bool autoAim = false, string resolution = "1920x1080", int brightness = 100)
        {
            this.Difficulty = difficulty;
            this.AutoAim = autoAim;
            this.Resolution = resolution;
            this.Brightness = brightness;
        }

        //// Methods
        public void updateUI(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
