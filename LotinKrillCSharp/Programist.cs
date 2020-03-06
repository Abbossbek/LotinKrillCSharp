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
    public partial class Programist : Form
    {
        public Programist()
        {
            InitializeComponent();
            label1.Text = "NIYOZQULOV ABBOS\nO'zMU talabasi\n\nTelegram: @Programmer1718\nTelegram kanal: @Csharp_N1\n\n\nProgramma 04.12.2018 da yaratildi.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/Programmer1718");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/CSharp_N1");
        }
    }
}
