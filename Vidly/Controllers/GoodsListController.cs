//  SYSTEM DEPENDENCIES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// NAMESPACE DEPENDENCIES
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class GoodsListController : Controller
    {
        // Properties can be scoped to the class, or to the method nested in the class. 
        // Properties once declared can be accessed inside of methods.
        // this. annotation is not necessary to access these properties, but may be good practice?

        public List<GoodsListModel> goodsList = new List<GoodsListModel>
        {
            new GoodsListModel{ Id = 1, GoodsName = "Bananas", GoodsPrice = "£0.99" },
            new GoodsListModel { Id = 2, GoodsName = "Apples", GoodsPrice = "£1.15" },
            new GoodsListModel { Id = 3, GoodsName = "Strawberries", GoodsPrice = "£9.34" }
        };

        public List<GoodsListRatingsModel> goodsListRatings = new List<GoodsListRatingsModel>
        {
            new GoodsListRatingsModel { Id = 1, Rating = "Superb Bananas." },
            new GoodsListRatingsModel { Id = 2, Rating = "Crunchy Apples." },
            new GoodsListRatingsModel { Id = 3, Rating = "Profoundly overpriced Strawberries." }
        };

        // GET: GoodsList
        // route: CONTROLLER / METHOD
        [Route("GoodsList/Index")]
        public ActionResult Index()
        {
            // View Model is a combination of multiple models combined together and passed to the view.
            // ViewModel should be built inside of the parent method.
            var viewModel = new GoodsListViewModel
            {
                GoodsList = this.goodsList,
                GoodsListRating = this.goodsListRatings
            };

            return View(viewModel);
        }

        [Route("GoodsList/Selected/{Id}")]
        public ActionResult Selected(int Id)
        {
            // Us the 'SingleOrDefault' native method to find an object inside a List of objects with a matching key like 'Id'.
            var selectedItem = goodsList.SingleOrDefault(x => x.Id == Id);


            // Use the ViewBag to return variables assigned to Methods like this.
            ViewBag.SelectedItem = selectedItem;
            return View(selectedItem);
        }


    }
}