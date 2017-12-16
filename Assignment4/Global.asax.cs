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
        public static void deletebutton(Model model)
        {
            List<Model> List;
            List = Models.ToList();
            var item = List.SingleOrDefault(a => a.name == model.name && a.faction == model.faction);
            if (item != null) { List.Remove(item); }
            string json = JsonConvert.SerializeObject(List);

            using (StreamWriter streamWriter = File.CreateText(@"..\json\Assign04.json"))
            {
                streamWriter.WriteLine(json);
            }

            Global gb = new Global();
            gb.ModelCollection();

        }

        public static void EmailJsonFile(string clientEmailAddress, string clientName)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            try
            {
                
                MailAddress fromAddress = new MailAddress("jangwonh4@gmail.com", "From Me");   
                MailAddress toAddress1 = new MailAddress(clientEmailAddress, clientName);
                MailAddress toAddress2 = new MailAddress("cc-comp229f2016@outlook.com", "You");

                message.From = fromAddress;
                message.To.Add(toAddress1);
                message.To.Add(toAddress2);
                message.Subject = "Comp229-Assign04-email";
                message.Body = "This is the body of a sample message";

                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");
                smtpClient.Send(message);

            }
            catch (Exception ex)
            {

            }
        }
        
    }
}