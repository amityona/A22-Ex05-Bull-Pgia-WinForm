using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A22_Ex05_G
{
    public partial class PickAColor : Form
    {
        private Button m_ChoseColorButton;
        public PickAColor(Button i_ChooseColor)
        {
            InitializeComponent();
            m_ChoseColorButton = i_ChooseColor;
        }
        private void GenericChooseColor_Click(object sender, EventArgs e)
        {
            Button send = (Button)sender;
            m_ChoseColorButton.BackColor = send.BackColor;
            this.Close();
        }
    }
}
