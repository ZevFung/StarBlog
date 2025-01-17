﻿using Microsoft.AspNetCore.Mvc;
using StarBlog.Web.Services;
using StarBlog.Web.ViewModels;

namespace StarBlog.Web.Controllers;

public class HomeController : Controller {
    private readonly BlogService _blogService;
    private readonly PhotoService _photoService;
    private readonly CategoryService _categoryService;

    public HomeController(BlogService blogService, PhotoService photoService, CategoryService categoryService) {
        _blogService = blogService;
        _photoService = photoService;
        _categoryService = categoryService;
    }

    public IActionResult Index() {
        return View(new HomeViewModel {
            RandomPhoto = _photoService.GetRandomPhoto(),
            TopPost = _blogService.GetTopOnePost(),
            FeaturedPosts = _blogService.GetFeaturedPosts(),
            FeaturedPhotos = _photoService.GetFeaturedPhotos(),
            FeaturedCategories = _categoryService.GetFeaturedCategories()
        });
    }
}