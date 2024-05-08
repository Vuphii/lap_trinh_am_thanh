using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP08VUPHI
{
    public partial class Fr1Main08 : Form
    {
        public Fr1Main08()
        {
            InitializeComponent();
        }

       
        private void Fr1Main08_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToShortDateString() + " : " + DateTime.Now.ToLongTimeString();
    
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        //
        //THOAT CHUONG TRINH 
        //
       
        private void tHOÁTCHƯƠNGTRÌNHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("BẠN MUỐN THOÁT KHÔNG (Y/N)", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //
        //quản lý âm thanh dung window media player 
        //
        private void qUẢNLÝÂMTHANHDÙNGWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr2WMP08 fr = new Fr2WMP08();
            fr.ShowDialog();
        }

        private void qUẢNLÝÂMTHANHDÙNGIrrklangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr3IrrKLang08 fr = new Fr3IrrKLang08();
            fr.ShowDialog();
        }
    }
}
