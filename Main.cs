using System;
using System.Windows.Forms;

namespace CSCISystem1._1
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            loadingTimer.Start();
            LoadForm(new HomeForm());
        }
        private void LoadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        bool reportExpand = false;
        private void dropDownTimer_Tick(object sender, EventArgs e)
        {
            if (reportExpand == false)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Height >= 270)
                {
                    dropDownTimer.Stop();
                    reportExpand = true;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Height <= 185)
                {
                    dropDownTimer.Stop();
                    reportExpand = false;
                }
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new HomeForm());
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Product());
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new UserForm());
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            dropDownTimer.Start();
        }

        private void InventoryRBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new InventoryReport());
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void TempPOSBTN_Click(object sender, EventArgs e)
        {
            POS pos = new POS();
            pos.Show();
        }
    }
}
