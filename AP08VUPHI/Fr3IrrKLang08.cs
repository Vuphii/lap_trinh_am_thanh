using IrrKlang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AP08VUPHI
{
    public partial class Fr3IrrKLang08 : Form
    {
        public Fr3IrrKLang08()
        {
            InitializeComponent();
        }
        //KHAI BÁO CÁC BIẾN TOÀN CỤC 
        ISoundEngine fn = new ISoundEngine();
        //Khai báo biến toàn cục thuộc đối tượng File âm thanh của irrKLang 
        string audiopath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath))) + "\\Audio file\\1.Sound\\";
        //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP
        //Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 2 lần
        //để lấy thư mục cha sử dụng System.IO.Path.GetDirectoryName(Application.StartupPath)


        //PLAY SOUND 2D DÙNG irrKLang
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            fn.SoundVolume = 100;
            fn.Play2D(audiopath+ "\\African Lion.mp3", true);
            MessageBox.Show("OK");
        }
    }
}
