using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rock.Web.UI;
using MarkdownSharp;
using System.Net;
using Rock.Model;
using System.Web.Compilation;
using System.Web.Hosting;

namespace RockWeb.Plugins.com_rockMP.Cms
{
    public partial class MarkdownContent : RockBlock
    {
        protected void btnTransform_Click( object sender, EventArgs e )
        {
            MarkdownSharp.Markdown markdown = new Markdown();
            lHtml.Text = markdown.Transform( tbMarkdownInput.Text );
        }
        
        protected void btnRestart_Click( object sender, EventArgs e )
        {
            
            BuildManager.GetCompiledType(this.CurrentBlock.BlockType.Path);
            
            
            
            System.Web.Hosting.HostingEnvironment.InitiateShutdown();
            
            Rock.Web.Cache.PageCache.Flush( this.CurrentPage.Id );
            Rock.Web.Cache.BlockTypeCache.Flush( this.CurrentBlock.BlockTypeId );
            Rock.Web.Cache.BlockCache.Flush( this.CurrentBlock.Id );
            WebRequest request = WebRequest.Create( Request.Url );
            WebResponse response = request.GetResponse();
        }
}
}