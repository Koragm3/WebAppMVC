using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models.Components;
using WebAppMVC.Models.Sections;
using WebAppMVC.Models.Views;

namespace WebAppMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        var viewModel = new HomeIndexViewModel
        {
            Title = "Ultimate Task Managment Assistent",
            Showcase = new ShowcaseViewModel
            {
                Id = "overview",
                ShowcaseImage = new() { ImageUrl = "images/showcase-taskmaster.svg", AltText = "Task Managment Assistent" },
                Title = "Ultimate Task Managment Assistent",
                Text = "We offer you a new genration of task managment system. Plan, manage track all your tasks in one flexible tool",
                BrandsText = "Largest companies use our tool to work efficiently",               
                Link = new() { ControlerName = "Downloads", ActionName = "Index", Text = "Get started for free"},
                Brands = new List<ImageViewModel> 
                { 
                    new() { ImageUrl = "images/brands/brand1.svg", AltText = "Brand Name 1"},
                    new() { ImageUrl = "images/brands/brand2.svg", AltText = "Brand Name 2"},
                    new() { ImageUrl = "images/brands/brand3.svg", AltText = "Brand Name 3"},
                    new() { ImageUrl = "images/brands/brand4.svg", AltText = "Brand Name 4"},
                }
                
            }

        };


        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    
}
