using WebAppMVC.Models.Sections;

namespace WebAppMVC.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";

    public ShowcaseViewModel Showcase { get; set; } = null!;   
}
