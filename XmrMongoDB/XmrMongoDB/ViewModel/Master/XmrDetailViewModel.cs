using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmrMongoDB.Common;

namespace XmrMongoDB.ViewModel
{
    public class XmrDetailViewModel : ObservableObject
    {
        private string _name { get; set; }
        public XmrDetailViewModel()
        {
            Name = "Detail";
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
