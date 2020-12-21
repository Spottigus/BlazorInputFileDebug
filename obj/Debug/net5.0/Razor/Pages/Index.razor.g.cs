#pragma checksum "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52e9951edef38614e181adb1c8c77df7b13e01c"
// <auto-generated/>
#pragma warning disable 1591
namespace FileUploadDebug.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using FileUploadDebug;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\_Imports.razor"
using FileUploadDebug.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Upload PNG images</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(2);
            __builder.AddAttribute(3, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor"
                          OnInputFileChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor"
 if (imageDataUrls.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<h4>Images</h4>");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddAttribute(8, "style", "width:30rem;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
#nullable restore
#line 15 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor"
             foreach (var imageDataUrl in imageDataUrls)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "class", "rounded m-1");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 17 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor"
                                               imageDataUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\phena\src\FileUploadDebug\FileUploadDebug\Pages\Index.razor"
       
    private IList<string> imageDataUrls = new List<string>();

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        var maxAllowedFiles = 3;
        var format = "image/png";

        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFiles))
        {
            var resizedImageFile = await imageFile.RequestImageFileAsync(format, 
                100, 100);
            var buffer = new byte[resizedImageFile.Size];
            await resizedImageFile.OpenReadStream().ReadAsync(buffer);
            var imageDataUrl = 
                $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            imageDataUrls.Add(imageDataUrl);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
