using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using XamarinDEMO.Models;

namespace XamarinDEMO.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        ObservableCollection<CollectionModel> _items;
        public ObservableCollection<CollectionModel> items
        { 
            get { return _items; }
            set { _items = value;
                OnPropertyChanged("items");
            }
        }

        public MainViewModel()
        {
            items = new ObservableCollection<CollectionModel>();
            onLoadItems();
        }

        void onLoadItems()
        {
            CollectionModel group1 = new CollectionModel();
            group1.header = "Perros";

            group1.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores perritos", image = "banner_dog.png" });
            group1.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores perritos", image = "banner_dog.png" });
            group1.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores perritos", image = "banner_dog.png" });

            items.Add(group1);

            CollectionModel group2 = new CollectionModel();
            group2.header = "Gatos";

            group2.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores gatitos", image = "banner_cat.png" });
            group2.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores gatitos", image = "banner_cat.png" });
            group2.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores gatitos", image = "banner_cat.png" });

            items.Add(group2);

            CollectionModel group3 = new CollectionModel();
            group3.header = "Conejos";

            group3.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores conejitos", image = "banner_bunny.png" });
            group3.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores conejitos", image = "banner_bunny.png" });
            group3.items.Add(new ItemModel() { title = "Xamarin", description = "Conoce a los mejores conejitos", image = "banner_bunny.png" });

            items.Add(group3);
        }

    }
}
