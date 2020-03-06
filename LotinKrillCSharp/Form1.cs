using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotinKrillCSharp
{
    public partial class Form1 : Form
    {
        private string s;
        public Form1()
        {
            InitializeComponent();
            contextMenuStrip1.Enabled = true;
            nusxaOlishToolStripMenuItem.Enabled = false;
            groupBox1.Width = this.Width / 2-5;
            groupBox2.Width = this.Width / 2-5;
            rtb1.Width = this.Width / 2 - 15;
            rtb2.Width = this.Width / 2 - 15;
            rtb1.Height = this.Height - 95;
            rtb2.Height = this.Height - 95;
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            s = rtb1.Text;
            if (krillLotinToolStripMenuItem.Checked)
            {
                s = s.Replace("ё", "yo");
                s = s.Replace("Ё", "Yo");
                s = s.Replace("ғ", "g‘");
                s = s.Replace("Ғ", "G‘");
                s = s.Replace("ҳ", "h");
                s = s.Replace("Ҳ", "H");
                s = s.Replace("ъ", "'");
                s = s.Replace("х", "x");
                s = s.Replace("Х", "X");
                s = s.Replace("з", "z");
                s = s.Replace("З", "Z");
                s = s.Replace("ў", "o‘");
                s = s.Replace("Ў", "O‘");
                s = s.Replace("ш", "sh");
                s = s.Replace("Ш", "Sh");
                s = s.Replace("г", "g");
                s = s.Replace("Г", "G");
                s = s.Replace("н", "n");
                s = s.Replace("Н", "N");
                s = s.Replace(" е", " ye");
                s = s.Replace(" Е", " Ye");
                s = s.Replace("е", "e");
                s = s.Replace("Е", "e");
                s = s.Replace("к", "k");
                s = s.Replace("К", "K");
                s = s.Replace("у", "u");
                s = s.Replace("У", "U");
                s = s.Replace("ц", "ts");
                s = s.Replace("Ц", "S");
                s = s.Replace("й", "y");
                s = s.Replace("Й", "Y");
                s = s.Replace("ф", "f");
                s = s.Replace("Ф", "F");
                s = s.Replace("қ", "q");
                s = s.Replace("Қ", "Q");
                s = s.Replace("в", "v");
                s = s.Replace("В", "V");
                s = s.Replace("а", "a");
                s = s.Replace("А", "A");
                s = s.Replace("п", "p");
                s = s.Replace("П", "P");
                s = s.Replace("р", "r");
                s = s.Replace("Р", "R");
                s = s.Replace("о", "o");
                s = s.Replace("О", "O");
                s = s.Replace("л", "l");
                s = s.Replace("Л", "L");
                s = s.Replace("д", "d");
                s = s.Replace("Д", "D");
                s = s.Replace("ж", "j");
                s = s.Replace("Ж", "J");
                s = s.Replace("э", "e");
                s = s.Replace("Э", "E");
                s = s.Replace("ю", "yu");
                s = s.Replace("Ю", "Yu");
                s = s.Replace("б", "b");
                s = s.Replace("Б", "B");
                s = s.Replace("ь", "");
                s = s.Replace("Ь", "");
                s = s.Replace("т", "t");
                s = s.Replace("Т", "T");
                s = s.Replace("и", "i");
                s = s.Replace("И", "I");
                s = s.Replace("м", "m");
                s = s.Replace("М", "M");
                s = s.Replace("с", "s");
                s = s.Replace("С", "S");
                s = s.Replace("ч", "ch");
                s = s.Replace("Ч", "Ch");
                s = s.Replace("я", "ya");
                s = s.Replace("Я", "Ya");
            }
            else
            {
                if (lotinKrillToolStripMenuItem.Checked)
                {
                    s = s.Replace("yo", "ё");
                    s = s.Replace("Yo", "Ё");
                    s = s.Replace("sh","ш");
                    s = s.Replace("Sh", "Ш");
                    s = s.Replace("g‘", "ғ");
                    s = s.Replace("g'", "ғ");
                    s = s.Replace("G‘", "Ғ");
                    s = s.Replace("G'", "Ғ");
                    s = s.Replace("o‘", "ў");
                    s = s.Replace("o'", "ў");
                    s = s.Replace("O‘", "Ў");
                    s = s.Replace("O'", "Ў");
                    s = s.Replace(" ye"," е");
                    s = s.Replace(" Ye"," Е");
                    s = s.Replace("ts","ц");
                    s = s.Replace("S","Ц");
                    s = s.Replace("yu","ю");
                    s = s.Replace("Yu","Ю");
                    s = s.Replace("ch","ч");
                    s = s.Replace("Ch","Ч");
                    s = s.Replace("ya","я");
                    s = s.Replace("Ya","Я");
                    s = s.Replace("h","ҳ");
                    s = s.Replace("H","Ҳ");
                    s = s.Replace("'","ъ");
                    s = s.Replace("x","х");
                    s = s.Replace("X","Х");
                    s = s.Replace("z","з");
                    s = s.Replace("Z","З");
                    s = s.Replace("g","г");
                    s = s.Replace("G","Г");
                    s = s.Replace("n","н");
                    s = s.Replace("N","Н");
                    s = s.Replace("e","е");
                    s = s.Replace("e","Е");
                    s = s.Replace("k","к");
                    s = s.Replace("K","К");
                    s = s.Replace("u","у");
                    s = s.Replace("U","У");
                    s = s.Replace("y","й");
                    s = s.Replace("Y","Й");
                    s = s.Replace("f","ф");
                    s = s.Replace("F","Ф");
                    s = s.Replace("q","қ");
                    s = s.Replace("Q","Қ");
                    s = s.Replace("v","в");
                    s = s.Replace("V","В");
                    s = s.Replace("a","а");
                    s = s.Replace("A","А");
                    s = s.Replace("p","п");
                    s = s.Replace("P","П");
                    s = s.Replace("r","р");
                    s = s.Replace("R","Р");
                    s = s.Replace("o","о");
                    s = s.Replace("O","О");
                    s = s.Replace("l","л");
                    s = s.Replace("L","Л");
                    s = s.Replace("d","д");
                    s = s.Replace("D","Д");
                    s = s.Replace("j","ж");
                    s = s.Replace("J","Ж");
                    s = s.Replace("e","э");
                    s = s.Replace("E","Э");
                    s = s.Replace("b","б");
                    s = s.Replace("B","Б");
                    s = s.Replace("t","т");
                    s = s.Replace("T","Т");
                    s = s.Replace("i","и");
                    s = s.Replace("I","И");
                    s = s.Replace("m","м");
                    s = s.Replace("M","М");
                    s = s.Replace("s","с");
                    s = s.Replace("S","С");
                }
            }
            rtb2.Text = s;
        }
       
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rtb1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Control.MousePosition.X, Control.MousePosition.Y);
            }
        }

        private void nusxaOlishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectedText.Count()!=0)
            {
                Clipboard.SetText(rtb1.SelectedText);
            }
        }

        private void rtb2_SelectionChanged(object sender, EventArgs e)
        {
            if (rtb1.SelectedText.Count()!=0)
            {
                nusxaOlishToolStripMenuItem.Enabled = true;
            }
        }

        private void joylashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rtb1.Focused)
            {
                rtb1.Text += Clipboard.GetText();
            }
            else
            {
                rtb2.Text += Clipboard.GetText();
            }
        }

        private void hammasiniBelgilashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb1.Focused)
            {
                rtb1.SelectAll();
            }
            else
            {
                rtb2.SelectAll();
            }
        }

        private void groupBox1_Layout(object sender, LayoutEventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }


        private void Form1_SizeChanged_1(object sender, EventArgs e)
        {
            groupBox1.Width = this.Width / 2 - 5;
            groupBox2.Width = this.Width / 2 - 5;
            rtb1.Width = this.Width / 2 - 15;
            rtb2.Width = this.Width / 2 - 15;
            rtb1.Height = this.Height - 95;
            rtb2.Height = this.Height - 95;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtb1.Font = new Font("Arial", Convert.ToInt32(toolStripComboBox1.SelectedItem.ToString()));
            rtb2.Font = new Font("Arial", Convert.ToInt32(toolStripComboBox1.SelectedItem.ToString()));
        }

        private void toolStripComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lotinKrillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lotinKrillToolStripMenuItem.Checked = true;
            krillLotinToolStripMenuItem.Checked = false;
            label1.Text = "LOTIN";
            label2.Text = "KRILL";
        }

        private void krillLotinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            krillLotinToolStripMenuItem.Checked = true;
            lotinKrillToolStripMenuItem.Checked = false;
            label1.Text = "KRILL";
            label2.Text = "LOTIN";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Programist p = new Programist();
            p.ShowDialog();
        }

        private void sozlamalarToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            sozlamalarToolStripMenuItem.ForeColor = Color.Black;
        }

        private void sozlamalarToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            sozlamalarToolStripMenuItem.ForeColor = Color.White;
        }
    }
}
