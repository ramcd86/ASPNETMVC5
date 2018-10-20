using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Vidly.Models;

namespace Vidly.ViewModels
{
    public class GoodsListViewModel
    {
        public List<GoodsListModel> GoodsList { get; set; }
        public List<GoodsListRatingsModel> GoodsListRating { get; set; }
    }
}