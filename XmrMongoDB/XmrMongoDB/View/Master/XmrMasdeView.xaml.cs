using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XmrMongoDB.ViewModel;

namespace XmrMongoDB.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XmrMasdeView : MasterDetailPage
    {
        public XmrMasdeView()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }




        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as XmrMasdeViewMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            NavigationPage pg = new NavigationPage(page);

            Detail = pg;
            IsPresented = false;

            pg.PushAsync(page);
            
            

            MasterPage.ListView.SelectedItem = null;
        }
    }
}