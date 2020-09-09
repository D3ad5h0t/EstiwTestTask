using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EstiwDesktop.Core.Actions
{
    public class BaseActions : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public object Clone() => this.MemberwiseClone();
    }
}
