﻿using Microsoft.AspNetCore.Mvc;
using StarBlog.Web.Services;

namespace StarBlog.Web.Apis; 

/// <summary>
/// 页面主题
/// </summary>
[ApiController]
[Route("Api/[controller]")]
[ApiExplorerSettings(GroupName = "common")]
public class ThemeController : ControllerBase {
    private readonly ThemeService _themeService;

    public ThemeController(ThemeService themeService) {
        _themeService = themeService;
    }

    [HttpGet]
    public ActionResult<List<Theme>> GetAll() {
        return _themeService.Themes;
    }
}