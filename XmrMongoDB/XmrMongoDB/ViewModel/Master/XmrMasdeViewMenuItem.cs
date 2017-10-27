using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XmrMongoDB.Common;
using XmrMongoDB.View;

namespace XmrMongoDB.ViewModel
{

    public class XmrMasdeViewMenuItem : ObservableObject
    {
        public XmrMasdeViewMenuItem()
        {
          
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }


     

    }
}