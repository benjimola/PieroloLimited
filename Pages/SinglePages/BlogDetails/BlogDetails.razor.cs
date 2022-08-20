using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using MudBlazor;
using Pierolo.com;
using Pierolo.com.Shared;
using Pierolo.com.Pages.SinglePages.BlogDetails.Components;
using Pierolo.com.IServices;
using Pierolo.com.Model;

namespace Pierolo.com.Pages.SinglePages.BlogDetails
{
    public partial class BlogDetails
    {
        [Inject] IBlogService BlogService { get; set; }
        [Parameter]public int id { get; set; }
        [Parameter]public string? url { get; set; }

        BlogPost post { get; set; }

        protected override void OnInitialized()
        {
            //post = BlogService.GetBlogPost(id);
        }
    }
}