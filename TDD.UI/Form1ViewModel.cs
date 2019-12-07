using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TDD.UI
{
    public class Form1ViewModel : ViewModelBase
    {
        private IDB _db;
        private string _aTextBoxText = string.Empty;

        public Form1ViewModel(IDB db)
        {
            _db = db;
        }
        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set {
                SetProperty(ref _aTextBoxText, value);
            }
        }
        private string _bTextBoxText = string.Empty;
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set
            {
                SetProperty(ref _bTextBoxText, value);
            }
        }
        private string _resultLabelText = string.Empty;
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set
            {
                SetProperty(ref _resultLabelText, value);
            }
        }

        public void CaluclationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            //var db = new DB();
            int dbValue = _db.GetDBValue();
            ResultLabelText = (Caluculation.Sum(a, b) + dbValue).ToString();
        }
    }
}
