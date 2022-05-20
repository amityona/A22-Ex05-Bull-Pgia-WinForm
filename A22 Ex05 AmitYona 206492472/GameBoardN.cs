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
    public partial class GameBoardN : Form
    {
        private const int k_MaxChooseOption = 4;
        private LogicBullsAndCows m_LogicBullCows;
        private Color[] m_ArrayofColor = new Color[4];
        private int m_CurrentRow = 0;
        private Button[,] m_ArrButton; 
        private int m_CountChoose;
        private int m_StartHeigth = 100;
        public GameBoardN(int i_CountChoose)
        {
            m_LogicBullCows = new LogicBullsAndCows(i_CountChoose);
            //MessageBox.Show(m_LogicBullCows.GenerateStringProperty);
            InitializeComponent();
            this.Width = 400;
            this.Height = i_CountChoose * 50 + 150;
            m_CountChoose = i_CountChoose;
            m_ArrButton = new Button[i_CountChoose, 9];
           
        }
        public void InitGame()
        {
            for (int j = 0; j < m_CountChoose; j++)
            {
                int space = 0;
                for (int i = 0; i < k_MaxChooseOption; i++)
                {

                    m_ArrButton[j, i] = new Button();
                    m_ArrButton[j, i].Location = new Point(btnBlack1.Left + space, m_StartHeigth);
                    space += 61;
                    m_ArrButton[j, i].Size = new Size(40, 43);
                    if (j != 0)
                    {
                        m_ArrButton[j, i].Enabled = false;
                    }
                    m_ArrButton[j, i].Click += ChooseColorDynamic_Click;
                    this.Controls.Add(m_ArrButton[j, i]);
                }
                m_StartHeigth += 50;
            }
            MakeGetAnswer();
        }
            private void MakeGetAnswer()
            {
                for (int j = 0; j < m_CountChoose; j++)
                {
                    m_ArrButton[j, 4] = new Button();
                    m_ArrButton[j, 4].Text = "->>";
                    m_ArrButton[j, 4].Enabled = false;
                    m_ArrButton[j, 4].Size = new Size(40, 20);
                    m_ArrButton[j, 4].Location = new Point(m_ArrButton[j, 3].Right + 20, m_ArrButton[j, 3].Top + 9);
                    this.Controls.Add(m_ArrButton[j, 4]);
                }
            MakeAnswerResult();
        }
        private void ChooseColorDynamic_Click(object sender, EventArgs e)
        {
            PickAColor chooseColorForm = new PickAColor((Button)sender);
            chooseColorForm.ShowDialog();
            CheckValidOfColorInput();

        }
        private void CheckValidOfColorInput()
        {
            bool status = true;
            bool allChoose = true;
            for (int i=0; i< k_MaxChooseOption ; i++)
            {
                m_ArrayofColor[i] = m_ArrButton[m_CurrentRow,i].BackColor;
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                   if( m_ArrayofColor[i] == Control.DefaultBackColor)
                    {
                        allChoose = false;
                        m_ArrButton[m_CurrentRow, 4].Enabled = false;
                        m_ArrButton[m_CurrentRow, 4].Click -= GetAnswer_Click;
                    }
                    if ((m_ArrayofColor[i] == m_ArrayofColor[j]) && (i!=j) &&(m_ArrayofColor[i]!= Control.DefaultBackColor))
                    {
                        status = false;
                        m_ArrButton[m_CurrentRow, 4].Enabled = false;
                        m_ArrButton[m_CurrentRow, 4].Click -= GetAnswer_Click;
                    }
                 }
            }
            if (!status)
            {
                MessageBox.Show("Cant Choose Same Color");
            }
            if(allChoose && status)
            {
                m_ArrButton[m_CurrentRow, 4].Enabled = true;
                m_ArrButton[m_CurrentRow, 4].Click += GetAnswer_Click;
            }
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {

            string answerToCheck = CodeColorToString();
            string answer = m_LogicBullCows.GetFeedBack(answerToCheck);
            
            if (answer == "V V V V ")
            {
                MessageBox.Show("You win the Game");
                DisplayOnBlack();
                GameEnd();
            }
            DisplayFeedBackFromString(answer);
            EndOfRow();
        }

        private void EndOfRow()
        {
            m_ArrButton[m_CurrentRow, 4].Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                m_ArrayofColor[i] = Control.DefaultBackColor;
            }
            if(m_CurrentRow+1 < m_CountChoose)
            {
                for (int i=0;i<4;i++)
                {
                    m_ArrButton[m_CurrentRow, i].Enabled = false;
                    if (m_CurrentRow + 1 < m_CountChoose)
                    {
                        m_ArrButton[m_CurrentRow + 1, i].Enabled = true;
                    }
                }
                m_CurrentRow += 1;
            }
            else
            {
                MessageBox.Show("You Lose");
                GameEnd();
            }
        }
        private void DisplayOnBlack()
        {
            Button[] arrBlackButton = new Button[k_MaxChooseOption];
            arrBlackButton[0] = btnBlack1;
            arrBlackButton[1] = btnBlack2;
            arrBlackButton[2] = btnBlack3;
            arrBlackButton[3] = btnBlack4;
            string generateString = m_LogicBullCows.GenerateStringProperty;
            char[] genetere = new char[k_MaxChooseOption];
            genetere[0] = generateString[0];
            genetere[1] = generateString[2];
            genetere[2] = generateString[4];
            genetere[3] = generateString[6];
            for (int i=0; i< k_MaxChooseOption ; i++)
            {
                if (genetere[i] == 'A')
                {
                    arrBlackButton[i].BackColor = Color.Fuchsia;
                }
                else if (genetere[i] == 'B')
                {
                    arrBlackButton[i].BackColor = Color.Red;
                }
                else if (genetere[i] == 'C')
                {
                    arrBlackButton[i].BackColor = Color.Lime;
                }
                else if (genetere[i] == 'D')
                {
                    arrBlackButton[i].BackColor = Color.Aqua;
                }
                else if (genetere[i] == 'E')
                {
                    arrBlackButton[i].BackColor = Color.Blue;
                }
                else if (genetere[i] == 'F')
                {
                    arrBlackButton[i].BackColor = Color.Yellow;
                }
                else if (genetere[i] == 'G')
                {
                    arrBlackButton[i].BackColor = Color.Sienna;
                }
                else if (genetere[i] == 'H')
                {
                    arrBlackButton[i].BackColor = Color.White;
                }
            }

        }
        private void GameEnd()
        {
            DisplayOnBlack();
            DialogResult restartGame = MessageBox.Show("Want to Play Again ?","Restart Game" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (restartGame == DialogResult.Yes)
            {
                this.Close();
             //   Form1 startAgain = new Form1();
               // startAgain.ShowDialog();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private void DisplayFeedBackFromString(string i_FeedBackString)
        {
            int countCurrentDisplay = 5;
            for (int i=0;i< i_FeedBackString.Length; i=i+2)
            {
                if (i_FeedBackString[i] == 'V')
                {
                    m_ArrButton[m_CurrentRow, countCurrentDisplay].BackColor = Color.Black;
                    countCurrentDisplay++;
                }
                if (i_FeedBackString[i] == 'X')
                {
                    m_ArrButton[m_CurrentRow, countCurrentDisplay].BackColor = Color.Yellow;
                    countCurrentDisplay++;
                }
            }
        }


       // EFCG
        private string CodeColorToString()
        {
            StringBuilder answerCodeColorToString = new StringBuilder(string.Empty);
            for (int i=0; i< k_MaxChooseOption; i++)
            {
                if (m_ArrayofColor[i] == Color.Fuchsia)
                {
                    answerCodeColorToString.Append("A");
                }
                else if (m_ArrayofColor[i] == Color.Red)
                {
                 answerCodeColorToString.Append("B");
                }
                else if (m_ArrayofColor[i] == Color.Lime)
                {
                    answerCodeColorToString.Append("C");
                }
                else if (m_ArrayofColor[i] == Color.Aqua)
                {
                    answerCodeColorToString.Append("D");
                }
                else if (m_ArrayofColor[i] == Color.Blue)
                {
                    answerCodeColorToString.Append("E");

                }
                else if (m_ArrayofColor[i] == Color.Yellow)
                {
                    answerCodeColorToString.Append("F");
                }
                else if (m_ArrayofColor[i] == Color.Sienna)
                {
                    answerCodeColorToString.Append("G");
                }
                else if (m_ArrayofColor[i] == Color.White) 
                {
                    answerCodeColorToString.Append("H");
                }
                if ( i != 3)
                {
                    answerCodeColorToString.Append(" ");
                }
            }
            return answerCodeColorToString.ToString();
        }
            private void MakeAnswerResult()
        {
            for (int j=0;j< m_CountChoose;j++)
            {
                for (int i = 5; i <= 8; i++)
                {
                 m_ArrButton[j, i] = new Button();
                 m_ArrButton[j, i].Enabled = false;
                 m_ArrButton[j, i].Size = new Size(20, 20);
                    if (i <= 6)
                    {
                         
                        m_ArrButton[j, i].Location = new Point(m_ArrButton[j, i - 1].Right + 5, m_ArrButton[j, 3].Top);
                    }
                    else
                    {
                        m_ArrButton[j, i].Location = new Point(m_ArrButton[j, i-3].Right+5 , m_ArrButton[j, i-2].Bottom +5);
                    }
                    this.Controls.Add(m_ArrButton[j, i]);
                }
            }
        }

        }
    }

