using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using MarketStore.Models;



namespace MarketStore


{

    
    // I am having some issues with running the project as it gives a parser error.


    // Parser Error Message: Could not load type 'MarketStore.MvcApplication'. 
    // Source Error: Line 1: <%@ Application Codebehind="Global.asax.cs" Inherits="MarketStore.MvcApplication" Language="C#" %>


    // I resolved this by renaming the value inside Inherits from "MarketStore.MvcApplication"  into  "MarketStore.MarketStoreApplication".  That is MarketStore is the namespace
    // and MarketStoreApplication is the name of the class

    public class MarketStoreApplication : System.Web.HttpApplication
        

    {
        
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                    "Default", //Route name
                    "{controller}/{action}/{id}",   //URL with parameters

                    new {controller ="Home", action = "Index", id = UrlParameter.Optional} // Parameter defaults


                );

                     
        }
    
       

    protected void Application_Start()
            {

                System.Data.Entity.Database.SetInitializer(new MarketStore.Models.StoreData());

            

            //**************************************************************************

                // I will initialize the Database 

               // Database.SetInitializer(new ProductDatabaseInitializer(StoreData));

            //*************************************************************************


                AreaRegistration.RegisterAllAreas();
                RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);


            }

        }
    }




