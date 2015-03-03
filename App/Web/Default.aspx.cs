using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Modelo;

namespace App.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
             
        {
             Persona p= new Persona("s","jull","ama","1356","ddd");


             Label1.Text = p.ToString().Replace("\n", "</br>");

        }
    }
}