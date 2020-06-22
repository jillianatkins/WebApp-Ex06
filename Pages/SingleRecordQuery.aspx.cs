using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBSystem.BLL;
using DBSystem.ENTITIES;

namespace WebApplication2.Pages
{
    public partial class SingleRecordQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ID.Text = "";
            Name.Text = "";
        }
        protected void Fetch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDArg.Text))
            {
                MessageLabel.Text = "Enter a Team ID.";
                ID.Text = "";
                Name.Text = "";
            }
            else
            {
                int id = 0;
                if (int.TryParse(IDArg.Text, out id))
                {
                    if (id > 0)
                    {
                        Controller01 sysmgr = new Controller01();
                        Entity01 info = null;
                        info = sysmgr.FindByPKID(id); //BLL controller method
                        if (info == null)
                        {
                            MessageLabel.Text = "Team not found.";
                            ID.Text = "";
                            Name.Text = "";
                        }
                        else
                        {
                            ID.Text = info.TeamID.ToString();
                            Name.Text = info.TeamName;
                            MessageLabel.Text = "";
                        }
                    }
                    else
                    {
                        MessageLabel.Text = "ID must be greater than 0";
                        ID.Text = "";
                        Name.Text = "";
                    }
                }
                else
                {
                    MessageLabel.Text = "ID must be a number.";
                    ID.Text = "";
                    Name.Text = "";
                }
            }
        }
    }
}