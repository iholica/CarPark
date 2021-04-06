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
    public partial class FormConditions : Form
    {
        DBEntities db;
        public FormConditions()
        {
            InitializeComponent();

            db = new DBEntities();
            db.Condition.Load();
            dataGridView1.DataSource = db.Condition.Local.ToBindingList();
        }
    }
}
