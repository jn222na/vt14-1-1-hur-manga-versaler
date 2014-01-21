using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnet_Versaler_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            string text = textArea.Text;
           
            int count = (TextAnalyzer.GetNumberOfCapitals(text));
            label.Text = textArea.Text + " Antal versaler: " + count;
            textArea.Enabled = false;
            button.OnClientClick = clear(text);
            textArea.Enabled = true;
            
        }
        private string clear(string text)
        {
            button.Text = "Rensa";
            textArea.Text = string.Empty;
            return textArea.Text;
        }
        //


    }
}