using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LukOilMVP.Views;

namespace LukOilMVP
{
    public partial class Form1 : Form, IMainView
    {
    public EventHandler<EventArgs> LitrNumericUpDownValueChanged { get; set; }
    public EventHandler<EventArgs> PriceNumericUpDownValueChanged { get; set; }
    public EventHandler<EventArgs> PayButtonClicked { get; set; }
    public EventHandler<EventArgs> PetrolComboBoxSelectedIndexChanged { get; set; }
    public EventHandler<EventArgs> LitrRadioButtonCheckedChanged { get; set; }
    public EventHandler<EventArgs> PriceRadioButtonCheckedChanged { get; set; }
    public EventHandler<EventArgs> PayButtonMouseHover { get; set; }
    public EventHandler<EventArgs> PayButtonMouseLeave { get; set; }

    public EventHandler<EventArgs> RemoveButtonClicked { get; set; }
    public EventHandler<EventArgs> RemoveButtonMouseHover { get; set; }
    public EventHandler<EventArgs> RemoveButtonMouseLeave { get; set; }

    public EventHandler<EventArgs> ClearButtonClicked { get; set; }
    public EventHandler<EventArgs> ClearButtonMouseHover { get; set; }
    public EventHandler<EventArgs> ClearButtonMouseLeave { get; set; }


        public Guna2RadioButton LitrRadioButton { get { return LitrRdBtn; } set { LitrRdBtn = value; } }
        public Guna2RadioButton PriceRadioButton { get { return PriceRdBtn; } set { PriceRdBtn = value; } }
        public Guna2ComboBox PetrolComboBox { get { return PetrolCmbBx; } set { PetrolCmbBx = value; } }
        public Guna2TextBox PriceTextBox { get { return PriceTxtBx; } set { PriceTxtBx = value; } }
        public Guna2NumericUpDown LitrNumericUpDown { get { return LitrNPDwn; } set { LitrNPDwn = value; } }
        public Guna2NumericUpDown PriceNumericUpDown { get { return PriceNPDwn; } set { PriceNPDwn = value; } }
        public Label TotalPaymentLabel { get { return TotalPaymentLbl; } set { TotalPaymentLbl = value; } }
        public Guna2GradientButton PayButton { get { return PayCrclBtn; } set { PayCrclBtn = value; } }
        public Guna2Button RemoveButton { get { return RemoveBtn; } set { RemoveBtn = value; } }
        public Guna2Button ClearButton { get { return ClearBtn; } set { ClearBtn = value; } }
        public Label InfoLabel { get { return InfoLbl; } set { InfoLbl = value; } }

        public ListBox PaymentListBox { get { return PaymentLstBx; } set { PaymentLstBx = value; } }


        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TotalPaymentLbl_Click(object sender, EventArgs e)
        {

        }

        private void PetrolCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            PetrolComboBoxSelectedIndexChanged.Invoke(sender, e);
        }

        private void LitrRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            LitrRadioButtonCheckedChanged.Invoke(sender, e);
        }

        private void LitrNPDwn_ValueChanged(object sender, EventArgs e)
        {
            LitrNumericUpDownValueChanged.Invoke(sender, e);
        }

        private void PriceRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            PriceRadioButtonCheckedChanged.Invoke(sender, e);
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PriceNumericUpDownValueChanged.Invoke(sender, e);
        }

        private void PayCrclBtn_Click(object sender, EventArgs e)
        {
            PayButtonClicked.Invoke(sender, e);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveButtonClicked.Invoke(sender, e);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearButtonClicked.Invoke(sender, e);
        }

        private void RemoveBtn_MouseHover(object sender, EventArgs e)
        {
            RemoveButtonMouseHover.Invoke(sender, e);
        }

        private void RemoveBtn_MouseLeave(object sender, EventArgs e)
        {
            RemoveButtonMouseLeave(sender, e);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
