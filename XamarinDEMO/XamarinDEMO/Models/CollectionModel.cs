﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinDEMO.Models
{
    public class CollectionModel
    {
       public List<ItemModel> items { get; set; }

        public CollectionModel()
        {
            items = new List<ItemModel>();
        }
    }

    public class ItemModel
    {
        public string title { set; get; }
        public string description { set; get; }
        public ImageSource image { set; get; }
    }
}