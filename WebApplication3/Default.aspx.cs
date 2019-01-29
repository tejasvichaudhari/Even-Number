using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WebApplication3
{
    public partial class _Default : System.Web.UI.Page, IView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region IView Members

        public string LabelNumber
        {
            get
            {
                return lblNumber.Text;
            }
            set
            {
                lblNumber.Text = value;
            }
        }

        public string TextforEvenNumbers
        {
            get
            {
                return txtNumberForEven.Text;
            }
            set
            {
                txtNumberForEven.Text = value;
            }
        }

        public string TextBoxNumberEven
        {
            get
            {
                return txtEvenNumbers.Text;
            }
            set
            {
                txtEvenNumbers.Text = value;
            }
        }


        public string TextNumberfor7Div
        {
            get
            {
                return txtNumberFor7Div.Text;
            }
            set
            {
                txtNumberFor7Div.Text = value;
            }
        }

        public string TextNumbersDivBy7
        {
            get
            {
                return txtNoDivBy7.Text;
            }
            set
            {
                txtNoDivBy7.Text = value;
            }
        }

        public string LabelNumberFor7Div
        {
            get
            {
                return lblEnterNoFor7.Text;
            }
            set
            {
                lblEnterNoFor7.Text = value;
            }
        }
        #endregion

        protected void btnGetAllEvenNo_Click(object sender, EventArgs e)
        {
            Presenter1 p = new Presenter1(this, new WebApplication3.Model());
            p.BindModalView();
        }

        protected void btnGetAllNoDivby7_Click(object sender, EventArgs e)
        {
            Presenter1 p = new Presenter1(this, new WebApplication3.Model());
            p.BindModalViewForNoDivBy7();
        }
    }
}
