using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfCodeFastAndMvpAsp
{
    public partial class WebForm1 : System.Web.UI.Page, IView, IModel
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var presenter = new Presenter(this);
            presenter.ShowData();
        }

        public string Name
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }
        public string Address
        {
            get { return AddressTextBox.Text; }
            set { AddressTextBox.Text = value; }
        }
        public string PhoneNumbet
        {
            get { return PhoneNumbetTextBox.Text; }
            set { PhoneNumbetTextBox.Text = value; }
        }
        public DateTime DateofBirth
        {
            get { return DptCalendar.SelectedDate; }
            set { DptCalendar.SelectedDate = value; }
        }
        public bool IsAlive
        {
            get { return IsAliveCheckBox.Checked; }
            set { IsAliveCheckBox.Checked = value; }
        }

        public List<PersonalInfo> PersonalInfos
        {
            get { return new List<PersonalInfo>(); }
            set
            {
                GridView1.DataSource = value;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var presenter = new Presenter();
            presenter.AddPInfo(this);
            Page.Response.Redirect(Page.Request.Url.ToString(),true);
        }
    }
}