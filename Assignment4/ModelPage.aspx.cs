using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment4.Models;

namespace Assignment4
{
    public partial class ModelPage : System.Web.UI.Page
    {
        private Model _Model;
        protected void Page_Load(object sender, EventArgs e)
        {

            var name = Request.QueryString["name"];
            var faction = Request.QueryString["faction"];

            UpdateModel.NavigateUrl = String.Format("~/UpdateModel.aspx?name={0}", name);


            if (string.IsNullOrEmpty(name))
            {
                Response.Redirect("~/Default.aspx");
                return;
            }
            _Model = Global.Models.FirstOrDefault(tModel => tModel.name == name);
            SetBindings();
        }

        private void SetBindings()
        {
            //Values
            ImageGame.ImageUrl = _Model.imageUrl;

            LblNameValue.Text = _Model.name;
            LblFactionValue.Text = _Model.faction;
            LblRankValue.Text = _Model.rank.ToString();
            LblBaseValue.Text = _Model._base.ToString();
            LblSizeValue.Text = _Model.size.ToString();
            LblDeploymentZoneValue.Text = _Model.deploymentZone.ToString();

            rptTraits.DataSource = _Model.traits;
            rptTraits.DataBind();

            rptTypes.DataSource = _Model.types;
            rptTypes.DataBind();

            rptDefenseChart.DataSource = _Model.defenseChart;
            rptDefenseChart.DataBind();

            LblMobilityValue.Text = _Model.mobility.ToString();
            LblWillPowerValue.Text = _Model.willpower.ToString();
            LblResilianceValue.Text = _Model.resiliance.ToString();
            LblWoundsValue.Text = _Model.wounds.ToString();

            rptActions.DataSource = _Model.actions;
            rptActions.DataBind();

            rptSpecialAbilities.DataSource = _Model.specialAbilities;
            rptSpecialAbilities.DataBind();

           
            
            


        }
    }
}
