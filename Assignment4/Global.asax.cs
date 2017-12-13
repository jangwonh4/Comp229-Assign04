using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Newtonsoft.Json;
using System.IO;
using System.Net.Mail;
using Assignment4.Models;


namespace Assignment4
{
    public class Global : HttpApplication
    {
        public static List<Model> Models;

        public const string ModelsJsonFilePath = "~/json/Assign04.json";
        public const string ModelsNewJsonFilePath = "~/json/NewAssign04.json";



        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelCollection();
            UpdateNewJsonFile();
        }

        private void ModelCollection()
        {
            using (StreamReader streamReader = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(ModelsJsonFilePath)))
            {
                var jsonString = streamReader.ReadToEnd();
                Models = JsonConvert.DeserializeObject<List<Model>>(jsonString);
            }
        }

        public static void UpdateNewJsonFile()
        {
            using (StreamWriter streamWriter = File.CreateText(System.Web.Hosting.HostingEnvironment.MapPath(ModelsNewJsonFilePath)))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(Models));
            }
        }
    }
}