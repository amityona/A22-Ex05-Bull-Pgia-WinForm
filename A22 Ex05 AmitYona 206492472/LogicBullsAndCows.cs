using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LogicBullsAndCows
{
    private char[] m_GenerateString;
    public LogicBullsAndCows(int i_ChooseNumber)
    {
        this.GenerateString();
    }
    public string GenerateStringProperty
    {
        get
        {
            string charsStr = new string(new char[] { this.m_GenerateString[0], ' ', this.m_GenerateString[1], ' ', this.m_GenerateString[2], ' ', this.m_GenerateString[3], ' ' });
            return charsStr;
        }
    }

    private void GenerateString()
    {
        char[] generateAnswer = new char[4];
        Random rand = new Random();
        int randomNumber;
        int[] generateNumber = new int[4];
        for (int i = 0; i < 4; i++)
        {
            randomNumber = rand.Next(0, 7);
            bool statusExists = false;
            for (int j = 0; j < generateNumber.Length; j++)
            {
                if (generateNumber[j] == randomNumber)
                {
                    statusExists = true;
                }
            }

            if (!statusExists)
            {
                generateNumber[i] = randomNumber;
                char currentCharToAdd = (char)('A' + randomNumber);
                generateAnswer[i] = currentCharToAdd;
            }
            else
            {
                i--;
            }
        }

        this.m_GenerateString = generateAnswer;
    }


    public string GetFeedBack(string i_InputString)
    {
        string feedback = string.Empty;
            StringBuilder answerFeedBack = new StringBuilder(string.Empty);
            char[] inputChars = new char[4];
            inputChars[0] = i_InputString[0];
            inputChars[1] = i_InputString[2];
            inputChars[2] = i_InputString[4];
            inputChars[3] = i_InputString[6];

            for (int i = 0; i < inputChars.Length; i++)
            {
                if (inputChars[i] == this.m_GenerateString[i])
                {
                answerFeedBack.Append("V ");
                }
            }

            for (int i = 0; i < inputChars.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((j != i) && (inputChars[i] == this.m_GenerateString[j]))
                    {
                        answerFeedBack.Append("X ");
                    }
                }
            }
            feedback = answerFeedBack.ToString();
        return feedback;
    }
}

