using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopThoiTrang
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        //??i t??ng l?u Json
        protected void Session_Start()
        {
            Session["UserAdmin"] = "";
            Session["UserId"] = "";
            Session["FullName"] = "";
            Session["Img"] = "";
            //Nhi?u bi?n kh�c 
        }

    }
}
