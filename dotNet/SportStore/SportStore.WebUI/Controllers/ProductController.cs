﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using SportStore.WebUI.Models;

namespace SportStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public int pageSize = 4;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List(string category,int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => category == null|| p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = pageSize, TotalItems = category == null ? repository.Products.Count():repository.Products.Where(e => e.Category == category).Count() },
                CurrentCategory = category
            };

            return View(model);
        }

        public FileContentResult GetImage(int productId)
        {
            Product prod = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            if(prod != null)
            {
                return File(prod.ImageData, prod.ImageMimeType);
            }else
            {
                return null;
            }
        }
    }
}