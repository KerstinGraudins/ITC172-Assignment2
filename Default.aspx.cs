using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{ string[,] events= new string[5,2]; 
    protected void Page_Load(object sender, EventArgs e)
    {
        events[0, 0] = "Tom's Birthday";
        events[0, 1] = "1/25/2017";
        events[1, 0] = "Date with Sarah";
        events[1, 1] = "1/11/2017";
        events[2, 0] = "work Party";
        events[2, 1] = "1/11/2017";
        events[3, 0] = "homework 5 due";
        events[3, 1] = "1/12/2017";
        events[4, 0] = "Vet appointment";
        events[4, 1] = "1/27/2017";

        
    }
    

    protected void Button1_Click(object sender, EventArgs e)
    {
        GetEvents();
    }

    private void GetEvents()
    {
        Label1.Text = "";
        if (Calendar1.SelectedDate > DateTime.MinValue)
        {
            string calendarDateTime = Calendar1.SelectedDate.ToShortDateString();
            for(int i=0; i< events.GetLength(0); i++)
            {
                if(events[i,1].Equals(calendarDateTime))
                {
                    Label1.Text += events[i,0] + "<br/>";
                }
            }
        }
        if (Label1.Text.Length == 0)
        {
            Label1.Text = "No Events Found";
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }
}