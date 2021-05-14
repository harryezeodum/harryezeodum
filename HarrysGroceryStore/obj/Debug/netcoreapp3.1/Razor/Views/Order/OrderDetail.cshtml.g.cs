#pragma checksum "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90254681d8d9a14fd4f2193179bee45953480203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderDetail), @"mvc.1.0.view", @"/Views/Order/OrderDetail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\_ViewImports.cshtml"
using HarrysGroceryStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\_ViewImports.cshtml"
using HarrysGroceryStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\_ViewImports.cshtml"
using HarrysGroceryStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90254681d8d9a14fd4f2193179bee45953480203", @"/Views/Order/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05761d455cbf7c0c0f121e153c8af2860c215b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3> Order Detail </h3>\r\n<hr />\r\n<table>\r\n    <tr>\r\n        <th class=\"text-right\"> Total Sales Amount: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 8 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.SalesAmount.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> Order Date: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 12 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> Shipped Date: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 16 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.ShippedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> First Name: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.Customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> Last Name: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.Customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> Address: </th>\r\n        <td> ");
#nullable restore
#line 28 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
        Write(Model.ShipAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> City: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 32 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.ShipCity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> State: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 36 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> ZipCode: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 40 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.Zipcode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> Employee Firstname: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.Employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th class=\"text-right\"> Employee Lastname: </th>\r\n        <td class=\"p-2\"> ");
#nullable restore
#line 48 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                    Write(Model.Employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n</table>\r\n<hr />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90254681d8d9a14fd4f2193179bee459534802038505", async() => {
                WriteLiteral(" Back ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Admin\source\repos\HarrysGroceryStore\HarrysGroceryStore\Views\Order\OrderDetail.cshtml"
                                               WriteLiteral(Model.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
