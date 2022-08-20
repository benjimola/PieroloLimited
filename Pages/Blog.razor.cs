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
using Pierolo.com.Component.Blogs;
using Pierolo.com.Model;
using Pierolo.com.IServices;

namespace Pierolo.com.Pages
{
   
    public partial class Blog
    {
        [Inject]NavigationManager? Navigation { get; set; }
        [Inject] IBlogService BlogService { get; set; }
        List<BlogPost>? blogs { get; set; }

        protected override void OnInitialized()
        {
            blogs = BlogService.GetBlogPosts();
        }

        //protected override void OnParametersSet()
        //{
        //    Navigation.NavigateTo
        //}
    }
}