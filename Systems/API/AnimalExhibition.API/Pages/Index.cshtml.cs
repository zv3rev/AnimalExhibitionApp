namespace AnimalExhibition.Api.Pages;

using AnimalExhibition.Api.Settings;
using AnimalExhibition.Common;
using AnimalExhibition.Services.Settings;
using DSRNetSchool.Api.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

public class IndexModel : PageModel
{
    [BindProperty]
    public bool OpenApiEnabled =>  settings.Enabled;

    [BindProperty]
    public string Version => Assembly.GetExecutingAssembly().GetAssemblyVersion();

    [BindProperty]
    public string HelloMessage => apiSettings.HelloMessage;


    private readonly SwaggerSettings settings;
    private readonly ApiSpecialSettings apiSettings;
    
    public IndexModel(SwaggerSettings settings, ApiSpecialSettings apiSettings)
    {
        this.settings = settings;
        this.apiSettings = apiSettings;
    }

    public void OnGet()
    {
    }
}
