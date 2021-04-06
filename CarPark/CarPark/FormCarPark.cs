using System.Windows.Forms;

namespace CarPark
{
    public partial class FormCarPark : Form
    {
        public FormCarPark()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        //водители
        private void водителиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormDrivers form = new FormDrivers();
            form.Show();
        }
        //типы автобусов
        private void типыАвтобусовToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormTypesOfBuses form = new FormTypesOfBuses();
            form.Show();
        }
        //состояние
        private void состояниеАвтобусовToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormConditions form = new FormConditions();
            form.Show();
        }
    }
}
