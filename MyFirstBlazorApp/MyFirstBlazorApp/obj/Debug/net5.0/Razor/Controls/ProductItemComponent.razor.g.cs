#pragma checksum "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd54f4e320b76bdcdaafdab3943b9a29ed99c10"
// <auto-generated/>
#pragma warning disable 1591
namespace MyFirstBlazorApp.Controls
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
    public partial class ProductItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
 if (this.product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "tr");
            __builder.OpenElement(1, "td");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
             product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "td");
            __builder.AddContent(5, 
#nullable restore
#line 5 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
             product.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
             product.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\ProductItemComponent.razor"
       
    [Parameter]
    public Product product { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
