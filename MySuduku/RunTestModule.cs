using System;
using System.Web;
using System.Linq;

namespace MySuduku
{
    public class RunTestModule : IHttpModule
    {
        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(RunTest);
        }

        private void RunTest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            if (context.Request.QueryString.Count > 0 && !context.Request.QueryString.AllKeys.Contains("runtests"))
            {
                context.RewritePath(string.Format("{0}&runtests=false", context.Request.RawUrl));
            }
        }
    }
}
