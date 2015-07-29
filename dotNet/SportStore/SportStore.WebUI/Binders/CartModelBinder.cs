using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SportStore.Domain.Entities;

namespace SportStore.WebUI.Binders
{
    public class CartModelBinder:IModelBinder
    {
        private const string sessionkey = "Cart";
        public object BindModel(ControllerContext controllerContext,ModelBindingContext bindingContext)
        {
            Cart cart = (Cart)controllerContext.HttpContext.Session[sessionkey];
            if(cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[sessionkey] = cart;
            }
            return cart;
        }
    }
}