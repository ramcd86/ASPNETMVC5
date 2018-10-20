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
        // GET: GoodsList
        // route: CONTROLLER / METHOD
        [Route("GoodsList/Index")]
        public ActionResult Index()
        {
            // View Model is a combination of multiple models combined together and passed to the view.
            var goodsList = new List<GoodsListModel>
            {
                new GoodsListModel
                {
                    Id = 1,
                    GoodsName = "Bananas",
                    GoodsPrice = "£0.99"
                },
                new GoodsListModel
                {
                    Id = 2,
                    GoodsName = "Apples",
                    GoodsPrice = "£1.15"
                },
                new GoodsListModel
                {
                    Id = 3,
                    GoodsName = "Strawberries",
                    GoodsPrice = "£9.34"
                }
            };

            var goodsListRatings = new List<GoodsListRatingsModel>
            {
                new GoodsListRatingsModel
                {
                    Id = 1,
                    Rating = "Superb Bananas."
                },
                new GoodsListRatingsModel
                {
                    Id = 2,
                    Rating = "Crunchy Apples."
                },
                new GoodsListRatingsModel
                {
                    Id = 3,
                    Rating = "Profoundly overpriced Strawberries."
                }
            };

            var viewModel = new GoodsListViewModel
            {
                GoodsList = goodsList,
                GoodsListRating = goodsListRatings
            };

            return View(viewModel);
        }
    }
}