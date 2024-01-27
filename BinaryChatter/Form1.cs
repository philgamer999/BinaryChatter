using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryChatter
{
    public partial class MainWindow : Form
    {
        /*
            X[index] - deletes a value
            -[index][index] - swaps to values
            _ - reverses the order
            O[char] - inserts [char] for 0
            I[char] - inserts [char] for 1
        */

        public static string[] chars = { " ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "\\", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{", "|", "}", "~" };
        public static string[] bins = { "00100000", "00100001", "00100010", "00100011", "00100100", "00100101", "00100110", "00100111", "00101000", "00101001", "00101010", "00101011", "00101100", "00101101", "00101110", "00101111", "00110000", "00110001", "00110010", "00110011", "00110100", "00110101", "00110110", "00110111", "00111000", "00111001", "00111010", "00111011", "00111100", "00111101", "00111110", "00111111", "01000000", "01000001", "01000010", "01000011", "01000100", "01000101", "01000110", "01000111", "01001000", "01001001", "01001010", "01001011", "01001100", "01001101", "01001110", "01001111", "01010000", "01010001", "01010010", "01010011", "01010100", "01010101", "01010110", "01010111", "01011000", "01011001", "01011010", "01011011", "01011100", "01011101", "01011110", "01011111", "01100000", "01100001", "01100010", "01100011", "01100100", "01100101", "01100110", "01100111", "01101000", "01101001", "01101010", "01101011", "01101100", "01101101", "01101110", "01101111", "01110000", "01110001", "01110010", "01110011", "01110100", "01110101", "01110110", "01110111", "01111000", "01111001", "01111010", "01111011", "01111100", "01111101", "01111110" };
        public static string key = "";

        public MainWindow()
        {
            InitializeComponent();
            SelectionBox.SelectedIndex = 0;
        }

        private void InputField_TextChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void SelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputField.Text = "";
            OutputField.Text = "";
        }

        private void UpdateText()
        {
            key = KeyBox.Text;

            if (SelectionBox.SelectedIndex == 0)
            {
                OutputField.Text = Converter(InputField.Text, 0);
            }
            else if (SelectionBox.SelectedIndex == 1)
            {
                OutputField.Text = Converter(InputField.Text, 1);
            }
        }

        private static string Converter(string input, int type)
        {
            string output = "";
            char[] keyChars = key.ToCharArray();

            if (type == 0)
            {
                char[] inputChars = input.ToCharArray();
                foreach (char c in inputChars)
                {
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (c.ToString() == chars[i])
                        {

                            #region Encryption
                            List<char> tempBin = new List<char>();
                            tempBin.AddRange(bins[i]);
                            int keyCount = 0;
                            foreach (char cc in keyChars)
                            {
                                if (cc.ToString() == "X")
                                {
                                    try
                                    {
                                        tempBin.RemoveAt(int.Parse(keyChars[keyCount+1].ToString()));
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex);
                                    }
                                }
                                else if (cc.ToString() == "-")
                                {
                                    try
                                    {
                                        int ic1 = int.Parse(keyChars[keyCount+1].ToString());
                                        int ic2 = int.Parse(keyChars[keyCount+2].ToString());
                                        char c1 = tempBin[ic1];
                                        char c2 = tempBin[ic2];

                                        tempBin[ic1] = c2;
                                        tempBin[ic2] = c1;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex);
                                    }
                                }
                                else if (cc.ToString() == "_")
                                {
                                    tempBin.Reverse();
                                }
                                else if (cc.ToString() == "O")
                                {
                                    for (int ii = 0; ii < tempBin.Count; ii++)
                                    {
                                        if (tempBin[ii].ToString() == "0")
                                        {
                                            try
                                            {
                                                tempBin[ii] = char.Parse(keyChars[keyCount + 1].ToString());
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex);
                                            }
                                        }
                                    }
                                }
                                else if (cc.ToString() == "I")
                                {
                                    for (int ii = 0; ii < tempBin.Count; ii++)
                                    {
                                        if (tempBin[ii].ToString() == "1")
                                        {
                                            try
                                            {
                                                tempBin[ii] = char.Parse(keyChars[keyCount + 1].ToString());
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex);
                                            }
                                        }
                                    }
                                }
                                keyCount++;
                            }
                            #endregion

                            output = output + new string(tempBin.ToArray()) + " ";
                        }
                    }
                }
            }
            else if (type == 1)
            {
                char[] inputChars = input.ToCharArray();
                List<string> inputStrings = new List<string>();
                List<string> outputStrings = new List<string>();
                string tempstring = "";

                int cCount = 0;
                foreach (char c in inputChars)
                {
                    if (c.ToString() != " ")
                    {
                        tempstring = tempstring + c.ToString();

                        if (cCount == inputChars.Length - 1)
                        {
                            inputStrings.Add(tempstring);
                            tempstring = "";
                        }
                    }
                    else if (c.ToString() == " ")
                    {
                        inputStrings.Add(tempstring);
                        tempstring = "";
                    }

                    cCount++;
                }


                int stringCount = 0;
                foreach (string s in inputStrings)
                {
                    List<char> stringChars = new List<char>();
                    stringChars.AddRange(s);


                    #region decrypt
                    if (key == "")
                    {
                        outputStrings.Add(new string(stringChars.ToArray()));
                    }
                    else
                    {
                        int keyCount = 0;
                        char[] reversedKeyChars = keyChars.Reverse().ToArray();
                        foreach (char cc in reversedKeyChars)
                        {
                            if (cc.ToString() == "X")
                            {
                                try
                                {
                                    stringChars.Insert(int.Parse(reversedKeyChars[keyCount - 1].ToString()), char.Parse("0"));
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }
                            }
                            else if (cc.ToString() == "-")
                            {
                                try
                                {
                                    int ic1 = int.Parse(keyChars[keyCount - 1].ToString());
                                    int ic2 = int.Parse(keyChars[keyCount - 2].ToString());
                                    char c1 = stringChars[ic1];
                                    char c2 = stringChars[ic2];

                                    stringChars[ic1] = c2;
                                    stringChars[ic2] = c1;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }
                            }
                            else if (cc.ToString() == "_")
                            {
                                stringChars.Reverse();
                            }
                            else if (cc.ToString() == "O")
                            {
                                for (int ii = 0; ii < stringChars.Count; ii++)
                                {
                                    if (stringChars[ii].ToString() == reversedKeyChars[keyCount - 1].ToString())
                                    {
                                        try
                                        {
                                            stringChars[ii] = char.Parse("0");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex);
                                        }
                                    }
                                }
                            }
                            else if (cc.ToString() == "I")
                            {
                                for (int ii = 0; ii < stringChars.Count; ii++)
                                {
                                    if (stringChars[ii].ToString() == reversedKeyChars[keyCount - 1].ToString())
                                    {
                                        try
                                        {
                                            stringChars[ii] = char.Parse("1");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex);
                                        }
                                    }
                                }
                            }
                            keyCount++;
                        }
                        outputStrings.Add(new string(stringChars.ToArray()));
                    }
                    
                    #endregion


                    for (int i = 0; i < bins.Length; i++)
                    {
                        if (outputStrings[stringCount] == bins[i])
                        {
                            try
                            {
                                output = output + chars[i];
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                        }
                    }
                    stringCount++;
                }
            }

            return output;
        }
    }
}
