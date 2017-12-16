using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment4.Models;
using System.IO;
using Newtonsoft.Json;
using System.Net.Mail;

namespace Assignment4
{
    public partial class ModelPage : System.Web.UI.Page
    {
        private Model _Model;
        protected string Name;
        protected string Faction;
        protected void Page_Load(object sender, EventArgs e)
        {
            Name = Request.QueryString["name"];
            Faction = Request.QueryString["faction"];

            if (string.IsNullOrEmpty(Name))
            {
                Response.Redirect("~/Default.aspx");               
            }
            _Model = Global.Models.FirstOrDefault(tModel => tModel.name == Name && tModel.faction == Faction);
            Bind();



        }

        

        protected void Update_Click(object sender, EventArgs e)
        {
            Save.Visible = true;
            Update.Visible = false;
            txtName.Enabled = true;
            txtFaction.Enabled = true;
            txtRank.Enabled = true;
            txtBase.Enabled = true;
            txtSize.Enabled = true;
            
        }
        protected void EmailButton_Click(object sender, EventArgs e)
        {
            string emailAddress = TextBoxEmail.Text;
            string emailName = TextBoxNameEmail.Text;

            Global.EmailJsonFile(emailAddress, emailName);
            Response.Redirect("Default.aspx");
        }



        private void UpdateAllModels()
        {
            _Model.name = txtName.Text;
            _Model.rank = int.Parse(txtRank.Text);
            _Model.faction = txtFaction.Text;
            _Model._base = int.Parse(txtBase.Text);
            _Model.size = int.Parse(txtSize.Text);
            Global.UpdateNewJsonFile();
            bool returnVal = true;
            if (returnVal)
            {
                EmailContainer.Visible = true;
            }
        }
        protected void Save_Click(object sender, EventArgs e)
        {
            Save.Visible = false;
            Update.Visible = true;
            txtName.Enabled = false;
            txtFaction.Enabled = false;
            txtRank.Enabled = false;
            txtBase.Enabled = false;
            txtSize.Enabled = false;

            Global.UpdateNewJsonFile();
            
                    
            UpdateAllModels();
            
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            //remove based on vname and vfaction          
            Global.Models.RemoveAll(tModel => tModel.name == Name && tModel.faction == Faction);
            Response.Redirect("~/Default.aspx");
        }

        private void Bind()
        {
            ImageGame.ImageUrl = _Model.imageUrl;

            txtName.Text = _Model.name;
            txtFaction.Text = _Model.faction;
            txtRank.Text = _Model.rank.ToString();
            txtBase.Text = _Model._base.ToString();
            txtSize.Text = _Model.size.ToString();
            txtDeploymentZone.Text = _Model.deploymentZone;
            txtMobility.Text = _Model.mobility.ToString();
            txtWillpower.Text = _Model.willpower.ToString();
            txtResiliance.Text = _Model.resiliance.ToString();
            txtWounds.Text = _Model.wounds.ToString();

            traits.DataSource = _Model.traits;
            traits.DataBind();

            types.DataSource = _Model.types;
            types.DataBind();

            defense.DataSource = _Model.defenseChart;
            defense.DataBind();

            action.DataSource = _Model.actions;
            action.DataBind();
        }


    }
}
