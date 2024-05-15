using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Election;
namespace ADOWinApps
{
    public partial class update : Form
    {
        Election.databaseOperation db;
        string newpname, prepname;
      
        public update()
        {
            InitializeComponent();
            db=new Election.databaseOperation();
            newpname = "";prepname = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newpname = textBox1.Text;
            prepname= textBox2.Text;

             int ans=db.UpdateRecord(prepname,newpname);
            lblAns.Text = ans.ToString() + " updated";
           
        }
    }
}
