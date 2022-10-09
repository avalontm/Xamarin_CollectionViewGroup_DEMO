using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
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

            group1.items.Add(new ItemModel() { title = "G1_item1", description = "Grupo 1 - item 1", image = "banner.png" });
            group1.items.Add(new ItemModel() { title = "G1_item2", description = "Grupo 1 - item 2", image = "banner.png" });
            group1.items.Add(new ItemModel() { title = "G1_item3", description = "Grupo 1 - item 3", image = "banner.png" });

            items.Add(group1);

            CollectionModel group2 = new CollectionModel();

            group2.items.Add(new ItemModel() { title = "G2_item1", description = "Grupo 2 - item 1", image = "banner.png" });
            group2.items.Add(new ItemModel() { title = "G2_item2", description = "Grupo 2 - item 2", image = "banner.png" });
            group2.items.Add(new ItemModel() { title = "G2_item3", description = "Grupo 2 - item 3", image = "banner.png" });

            items.Add(group2);

            CollectionModel group3 = new CollectionModel();

            group3.items.Add(new ItemModel() { title = "G3_item1", description = "Grupo 3 - item 1", image = "banner.png" });
            group3.items.Add(new ItemModel() { title = "G3_item2", description = "Grupo 3 - item 2", image = "banner.png" });
            group3.items.Add(new ItemModel() { title = "G3_item3", description = "Grupo 3 - item 3", image = "banner.png" });

            items.Add(group3);
        }

    }
}
