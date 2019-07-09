﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Model;
using PagedList;
using Data;

namespace OtakuStore.ViewModels
{
    public class SearchViewModel
    {
        public IPagedList<Product> list { get; set; }
        public IEnumerable<Image> images { get; set; }
        public IEnumerable<Manufactor> manufactors { get; set; }
        public IEnumerable<WishList> wishLists { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Anime> animes { get; set; }
        public IEnumerable<Product> productAll { get; set; }
        public SearchViewModel()

        {
            list = null;
        }
    }

    public class SearchAPIViewModel
    {
        public IPagedList<ProductViewModel> list { get; set; }
        public int count;
        public SearchAPIViewModel()

        {
            list = null;
        }
    }

    public partial class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ManufactorID { get; set; }

        public string Description { get; set; }

        public double? Price { get; set; }

        public int StatusID { get; set; }

        public int CategoryID { get; set; }

        public int? C_View { get; set; }

        public int? OrderCounter { get; set; }

        public string Size { get; set; }

        public DateTime? DateCreated { get; set; }
        public int? Rate { get; set; }
        public bool isDelete { get; set; }
        public int SaleRate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public IEnumerable<Image> images { get; set; }
    }
}