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
    public partial class BullPgia : Form
    {
        private int m_CountOfChoose = 4;
        public BullPgia()
        {
            InitializeComponent();
            btnCount.Text = "Number of chances:" + m_CountOfChoose;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            m_CountOfChoose++;
            if (m_CountOfChoose > 10)
            {
                m_CountOfChoose = 4;
            }
         btnCount.Text = "Number of chances:" + m_CountOfChoose;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameBoardN GameBoardOBJ = new GameBoardN(m_CountOfChoose);
            GameBoardOBJ.InitGame();
            GameBoardOBJ.ShowDialog();
        }

    }
}
