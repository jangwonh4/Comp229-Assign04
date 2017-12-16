using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment4.Models;

namespace Assignment4
{
    public partial class NewModel : System.Web.UI.Page
    {
        

  
       
        protected void Page_Load(object sender, EventArgs e)
        {
          
 
        }

        public void From(Model newone)
        {
            newone.name = nameTextBox.Text;
            newone.faction = factionTextBox.Text;
            newone.rank = Int32.Parse(rankTextBox.Text);
            newone._base = Int32.Parse(BaseTextBox.Text);
            newone.size = Int32.Parse(sizeTextBox.Text);
            newone.deploymentZone = deploymentZoneTextBox.Text;            
            newone.mobility = Int32.Parse(mobilityTextBox.Text);
            newone.willpower = Int32.Parse(willpowerTextBox.Text);
            newone.resiliance = Int32.Parse(resilianceTextBox.Text);
            newone.wounds = Int32.Parse(woundsTextBox.Text);           
            newone.imageUrl = imageurlTextBox.Text;
        }

        public void To(Model newone)
        {
            nameTextBox.Text = newone.name;
            factionTextBox.Text = newone.faction;
            rankTextBox.Text = newone.rank.ToString();
            BaseTextBox.Text = newone._base.ToString();
            sizeTextBox.Text = newone.size.ToString();
            deploymentZoneTextBox.Text = newone.deploymentZone;          
            mobilityTextBox.Text = newone.mobility.ToString();
            willpowerTextBox.Text = newone.willpower.ToString();
            resilianceTextBox.Text = newone.resiliance.ToString();
            woundsTextBox.Text = newone.wounds.ToString();          
            imageurlTextBox.Text = newone.imageUrl;
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            
            Model NewCha = new Model();
            From(NewCha);
            Global.Models.Add(NewCha);    
            Server.Transfer("~/Default.aspx");

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Default.aspx");
        }
    }

}
