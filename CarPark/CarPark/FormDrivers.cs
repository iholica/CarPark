using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPark
{
    public partial class FormDrivers : Form
    {
        DBEntities db;
        
        public FormDrivers()
        {
            InitializeComponent();

            db = new DBEntities();
            db.Driver.Load();
            dataGridView1.DataSource = db.Driver.Local.ToBindingList();
        }
    }
}
