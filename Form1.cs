using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Election;
namespace ADOWinApps
{
    public partial class Form1 : Form
    {
        Election.databaseOperation db;
        int vid, pno, sr;
        string pname;
       
        public Form1()
        {
            InitializeComponent();
           db=new Election.databaseOperation();
            vid = 0; pno = 0; sr = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            vid = Convert.ToInt32(textvoterid.Text);
            pno = Convert.ToInt32(textpartnumber.Text);
            pname = textpartname.Text;
            sr=Convert.ToInt32(textserialnumber.Text);  
            bool ans=db.CreateRecord(vid, pno, pname, sr);
            if(ans) 
                lblAns.Text = "record added";
                else
                    lblAns.Text = "record not added";
            }
        }
    }

