using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TDD.UI
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T field,T value,[CallerMemberName]string propertyName = null)
        {
            if(Equals(field,value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if(h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }

            return true;
        }
    }
}
