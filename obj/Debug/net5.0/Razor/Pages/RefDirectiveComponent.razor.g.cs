#pragma checksum "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b9fe4e0ff16e853d64147466d28a6a8409fde8"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/refkeydownhandle")]
    public partial class RefDirectiveComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Two-Way Binding Example with Reference Directive</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Enter your name: ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
                     name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
                           age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
                          name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(11, (__value) => {
#nullable restore
#line 11 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
                                      nameInput = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n<br>\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
                          age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(17, (__value) => {
#nullable restore
#line 13 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
                                     ageInput = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Hello, ");
            __builder.AddContent(21, 
#nullable restore
#line 15 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
           name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n<br>\r\n");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, "Current Element Reference ID : ");
            __builder.AddContent(26, 
#nullable restore
#line 17 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
                                   currentElement.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
       
    private string name = "John Doe";
    private ElementReference nameInput;

    private string age = "45";
    private ElementReference ageInput;

    private ElementReference currentElement;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
           

private void HandleNameChange(ChangeEventArgs e)
{
    // Custom logic when the name changes
    // For example, you can validate the input or perform other actions
    name = e.Value.ToString();
    currentElement = ageInput;
    currentElement.FocusAsync();
    nameInput.FocusAsync();
}

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
