#pragma checksum "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\TemplatedComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718353019da900bcde854aba04a6f476bc50ba3b"
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
    public partial class TemplatedComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Templated Component</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\TemplatedComponent.razor"
     Header

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
#nullable restore
#line 8 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\TemplatedComponent.razor"
         foreach (var item in Items)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 10 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\TemplatedComponent.razor"
             RepeatrItem(item)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 10 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\TemplatedComponent.razor"
                              
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddContent(7, 
#nullable restore
#line 13 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\TemplatedComponent.razor"
     Footer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Administrateur\Desktop\File-Rouge-e-commerce\MyFirstBlazorApp\MyFirstBlazorApp\Controls\TemplatedComponent.razor"
       
    [Parameter]
    public RenderFragment Header { get; set; }

    [Parameter]
    public RenderFragment Footer { get; set; }

    [Parameter]
    public List<TItem> Items { get; set; }

    [Parameter]
    public RenderFragment<TItem> RepeatrItem { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591