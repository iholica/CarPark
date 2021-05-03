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
        DriversStatus drStatus;
        List<DriversStatus> DrList = new List<DriversStatus>();
        List<Driver> DriverLastChanges = new List<Driver>();
        public FormDrivers()
        {
            InitializeComponent();

            db = new DBEntities();
            db.Driver.Load();
            dataGridView1.DataSource = db.Driver.Local.ToBindingList();
        }
        //добавление водителя
        private void добавитьВодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditDriver form_edit = new FormEditDriver();

            DialogResult result = form_edit.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Driver driver = new Driver();
            driver.LastName = form_edit.textBox1.Text;
            driver.FirstName = form_edit.textBox2.Text;
            driver.DateOfBith = form_edit.dateTimePicker1.Value;
            driver.Address = form_edit.textBox3.Text;
            driver.Phone = form_edit.textBox4.Text;
            driver.Experience = form_edit.textBox5.Text;

            DriverLastChanges.Add(driver);
            
            db.Driver.Add(driver);
            db.SaveChanges();
            drStatus.id = DriverLastChanges.Last().Id;
            drStatus.status = "add";
            DrList.Add(drStatus);

            MessageBox.Show("Новый водитель добавлен.", "Водители", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //редактировать водителя
        private void изменитьВодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool item = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (item == false)
                    return;

                Driver driver = db.Driver.Find(id);
                Driver driver1 = (Driver)driver.Clone();
                DriverLastChanges.Add(driver1);
                drStatus.id = DriverLastChanges.Last().Id;
                drStatus.status = "change";
                DrList.Add(drStatus);

                FormEditDriver form_edit = new FormEditDriver();

                form_edit.textBox1.Text = driver.LastName;
                form_edit.textBox2.Text = driver.FirstName;
                form_edit.dateTimePicker1.Value = driver.DateOfBith;
                form_edit.textBox3.Text = driver.Address;
                form_edit.textBox4.Text = driver.Phone;
                form_edit.textBox5.Text = driver.Experience;

                DialogResult result = form_edit.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                driver.LastName = form_edit.textBox1.Text;
                driver.FirstName = form_edit.textBox2.Text;
                driver.DateOfBith = form_edit.dateTimePicker1.Value;
                driver.Address = form_edit.textBox3.Text;
                driver.Phone = form_edit.textBox4.Text;
                driver.Experience = form_edit.textBox5.Text;

                db.Entry(driver).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Данные обновлены.", "Водители", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Выберите данные для редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //удалить водителя
        private void удалитьВодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool item = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (!item)
                    return;
                if (MessageBox.Show("Вы действительно желаете удалить выбранного водителя?", "Операция удаления водителя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Driver driver = db.Driver.Find(id);
                    Driver driver1 = (Driver)driver.Clone();
                    DriverLastChanges.Add(driver1);
                    drStatus.id = DriverLastChanges.Last().Id;
                    drStatus.status = "delete";
                    DrList.Add(drStatus);
                    db.Driver.Remove(driver);
                    db.SaveChanges();
                    MessageBox.Show("Данные удалены.", "Водители", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Выберите данные для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DrList.Count != 0)
            {
                switch (DrList.Last().status)
                {
                    case "add":
                        {
                            Driver driver = db.Driver.Find(DriverLastChanges.Last().Id);
                            db.Driver.Remove(driver);
                            db.SaveChanges();
                            DriverLastChanges.Remove(DriverLastChanges.Last());
                            DrList.Remove(DrList.Last());
                            break;
                        }
                    case "delete":
                        {
                            Driver driver = new Driver();
                            driver.Address = DriverLastChanges.Last().Address;
                            driver.DateOfBith = DriverLastChanges.Last().DateOfBith;
                            driver.Experience = DriverLastChanges.Last().Experience;
                            driver.FirstName = DriverLastChanges.Last().FirstName;
                            driver.LastName = DriverLastChanges.Last().LastName;
                            driver.Phone = DriverLastChanges.Last().Phone;
                            driver.Bus = DriverLastChanges.Last().Bus;
                            db.Driver.Add(driver);
                            db.SaveChanges();
                            DriverLastChanges.Remove(DriverLastChanges.Last());
                            DrList.Remove(DrList.Last());
                            break;
                        }
                    case "changes":
                        {
                            Driver driver = db.Driver.Find(DriverLastChanges.Last().Id);
                            driver.Address = DriverLastChanges.Last().Address;
                            driver.DateOfBith = DriverLastChanges.Last().DateOfBith;
                            driver.Experience = DriverLastChanges.Last().Experience;
                            driver.FirstName = DriverLastChanges.Last().FirstName;
                            driver.LastName = DriverLastChanges.Last().LastName;
                            driver.Phone = DriverLastChanges.Last().Phone;
                            driver.Bus = DriverLastChanges.Last().Bus;
                            db.Entry(driver).State = EntityState.Modified;
                            db.SaveChanges();
                            DriverLastChanges.Remove(DriverLastChanges.Last());
                            DrList.Remove(DrList.Last());
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Нет последних изменений.", "Автобусы", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                }
            }
            else
                MessageBox.Show("Нет последних изменений.", "Автобусы", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    public struct DriversStatus
    {
        public int id;
        public string status;
    }
}
