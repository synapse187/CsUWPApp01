using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CsUWPApp01
{
    public class CharacterSheet : INotifyPropertyChanged
    {
        public CharacterSheet()
        {
            Strength = 10;
        }
        public int Strength
        {
            get => Strength;
            set
            {
                if(Strength != value)
                {
                    Strength = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Strength"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
