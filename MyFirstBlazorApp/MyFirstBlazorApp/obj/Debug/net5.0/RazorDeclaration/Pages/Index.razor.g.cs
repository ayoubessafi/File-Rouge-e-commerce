// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyFirstBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using eShope.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\_Imports.razor"
using MyFirstBlazorApp.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Pages\Index.razor"
      

    private List<Product> Products = new List<Product>
    {
          new Product { Id = 495, Brand = "maybelline", Name = "Maybelline Face Studio Master Hi-Light Light Booster Bronzer", Price = 14.99, ImageLink = "https://d3t32hsnjxo7q6.cloudfront.net/i/991799d3e70b8856686979f8ff6dcfe0_ra,w158,h184_pa,w158,h184.png", Description = "Maybelline Face Studio Master Hi-Light Light Boosting bronzer formula has an expert  balance of shade + shimmer illuminator for natural glow. Skin goes  soft-lit with zero glitz.    For Best Results: Brush over all shades in palette and gently sweep over  cheekbones, brow bones, and temples, or anywhere light naturally touches  the face.                            "},
          new Product { Id = 488, Brand = "maybelline", Name = "Maybelline Fit Me Bronzer", Price = 10.29, ImageLink = "https://d3t32hsnjxo7q6.cloudfront.net/i/d4f7d82b4858c622bb3c1cef07b9d850_ra,w158,h184_pa,w158,h184.png", Description = "Why You'll Love It  Lightweight pigments blend easily and wear evenly Provides a natural, fade-proof bronzed color that leaves skin the way it was meant to be...fresh, breathing and natural  For Best Results: For soft, natural look, brush along cheekbone, sweeping upward."},
          new Product { Id = 477, Brand = "maybelline", Name = "Maybelline Facestudio Master Contour Kit", Price = 15.99, ImageLink = "https://d3t32hsnjxo7q6.cloudfront.net/i/4f731de249cbd4cb819ea7f5f4cfb5c3_ra,w158,h184_pa,w158,h184.png", Description = "Maybelline Facestudio Master Contour Kit is the ultimate on the go all-in-one palette, with contouring brush included.  Define and highlight in a New York minute with this effortless 3-step face contouring kit.  This easy-to-use 3-step face contouring kit features a bronzer, blush and highlighter."},
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
