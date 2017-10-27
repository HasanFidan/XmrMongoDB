using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XmrMongoDB.Common;
using XmrMongoDB.View;

namespace XmrMongoDB.ViewModel
{
    public class XmrMasterViewModel : ObservableObject
    {
        public ObservableCollection<XmrMasdeViewMenuItem> MenuItems { get; set; }

        private XmrMasdeViewMenuItem _objItemSelected;
        public XmrMasdeViewMenuItem objItemSelected { get
            { return _objItemSelected; }
            set {
                if (value != null)
                {
                    _objItemSelected = value;
                    OnPropertyChanged("objItemSelected");
                }
            } }


        private string _name { get; set; }
        public XmrMasterViewModel()
        {
            Name = "Master";
            SquareRootWithParameterCommand = new Command<string>(CalculateSquareRoot);

            MenuItems = new ObservableCollection<XmrMasdeViewMenuItem>(new[]
              {
                    new XmrMasdeViewMenuItem { Id = 0, Title = "Page 1", TargetType = typeof(XmrToDoViewDetail)},
                    new XmrMasdeViewMenuItem { Id = 1, Title = "Page 2", TargetType = typeof(XmrContactViewDetail) },
                    new XmrMasdeViewMenuItem { Id = 2, Title = "Page 3",TargetType = typeof(XmrTabPage) },
                    new XmrMasdeViewMenuItem { Id = 3, Title = "Page 4",TargetType = typeof(XmrContactViewDetail)},
                    new XmrMasdeViewMenuItem { Id = 4, Title = "Page 5",TargetType = typeof(CarusolPage) },
                });
        }

        void CalculateSquareRoot(string value)
        {
            double num = Convert.ToDouble(value);
           
        }


        public string Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public ICommand SquareRootWithParameterCommand { get; private set; }

        public ICommand _openPageOneCommand { get; set; }
        public ICommand OpenPageOneCommand
        {
            get
            {
                if (_openPageOneCommand == null)
                {

                    // Call action
                    _openPageOneCommand = new Command<object>(k=>
                        OpenPageOne(k)

                    );
                }
                return _openPageOneCommand;
            }
        }
        private bool OpenPageOneCanClick() { return true; }
        private void OpenPageOne(object id)
        {


        }




    }
}
