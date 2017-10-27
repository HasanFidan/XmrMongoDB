using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmrMongoDB.Common;

namespace XmrMongoDB.ViewModel
{
    public class XmrViewModel : ObservableObject
    {
        private string _name { get; set; }
        public XmrViewModel()
        {
            Name = "tEst Application Hasan Fidan";
        }


        public string Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

    }
}
