using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using Database;
using WebEcommerce.Services;


namespace WebEcommerce.Controllers
{
    [Authorize(Roles = "User")]
    public class CartController : Controller
    {

        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

    }
}
