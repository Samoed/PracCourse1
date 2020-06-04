using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task11Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[0-1]") && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }
        public static string Code(string str)
        {
            string code = str[0].ToString();
            for (int i = 1; i < str.Length; ++i)
            {
                code += str[i] == str[i - 1] ? 1 : 0;
            }
            return code;
        }
        public static string Encode(string code)
        {
            string encode = code[0].ToString();
            for (int i = 1; i < code.Length; ++i)
            {
                if (code[i] == '1')
                {
                    encode += encode[i - 1];
                }
                else
                {
                    encode += encode[i - 1] == '1' ? 0 : 1;
                }
            }
            return encode;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (orderText.Text == "")
            {
                MessageBox.Show("Заполните ячейку");
                return;
            }
            string str = orderText.Text;
            string code = Code(str);
            codeText.Text = code;
            string encode = Encode(code);
            encodeText.Text = encode;
        }
    }
}
