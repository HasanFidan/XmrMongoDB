using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmrMongoDB.Common;

namespace XmrMongoDB.ViewModel
{
    public class XmrThirdViewModel : ObservableObject
    {
        private string _name { get; set; }
        public XmrThirdViewModel()
        {
            Name = "Third Page";


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
