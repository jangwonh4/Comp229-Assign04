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


        public static void EmailJsonFile(string clientEmailAddress, string clientName, string attachmentFileName)
        {
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
          

            MailMessage message = new MailMessage();
            
            
            MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "Comp229-Assign04");
            MailAddress toAddress = new MailAddress(clientEmailAddress, clientName);
            message.From = fromAddress;
            message.To.Add(toAddress);
            message.Subject = "Comp229-Assign04 email";
            message.Body = "This is the body of a sample message";
        
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;
        
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");
        
            System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
            contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;
            contentType.Name = attachmentFileName;
            message.Attachments.Add(new Attachment(System.Web.Hosting.HostingEnvironment.MapPath(ModelsNewJsonFilePath), contentType));
        
            smtpClient.Send(message);

            
        }

        public static void Email()
        {
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            MailMessage message = new MailMessage();

            try
            { 
            MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "Comp229-Assign04");
            MailAddress toAddress = new MailAddress("jangwonh4@gmail.com", "Mingi");
            message.From = fromAddress;
            message.To.Add(toAddress);
            message.Subject = "Comp229-Assign04";
            message.Body = "Here is a body";

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