using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TDD.UI
{
    public class Form1ViewModel : INotifyPropertyChanged
    {

        //private System.Windows.Forms.TextBox ATextBox;
        //private System.Windows.Forms.TextBox BTextBox;
        //private System.Windows.Forms.Label ResultLabel;
        //private System.Windows.Forms.Button CalucationBotton;

        public string ATextBoxText { get; set; } = string.Empty;
        public string BTextBoxText { get; set; } = string.Empty;
        public string ResultLabelText { get; set; } = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void CaluclationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            ResultLabelText = Caluculation.Sum(a, b).ToString();

            OnPropertyChanged(string.Empty);
        }
    }
}
