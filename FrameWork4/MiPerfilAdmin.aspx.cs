﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameWork4
{
    public partial class MiPerfilAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var sesion = Session["sessionID"].ToString(); 

            if (Session["sessionID"] == null)
            {
                Response.Redirect("Login.aspx");  // Sin Logeo Dirigido a Login
            }
            else
            {
                email.Text = Session["username"].ToString();
                var resultadoSql = FrameWork4.MiPerfil.miPerfil(Session["username"].ToString());
                firstName.Text = resultadoSql.Item2.ToString();
                lastName.Text = resultadoSql.Item3.ToString();
                lastLogin.Text = resultadoSql.Item4.ToString();
                lastChangePassword.Text = resultadoSql.Item5.ToString();
               // isAdmin.Text = "1";


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Add_Users.aspx");
        }

        protected void ButtonToDefault_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}