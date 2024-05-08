using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;
using System.IO;//đẻ lấy đuongừ ẫn âm thanh 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Policy;
using static System.Net.WebRequestMethods;
using AP08VUPHI.AP08phiDataSetTableAdapters;
using NAudio.Wave;//để lấy chiều dài âm thanh 
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace AP08VUPHI
{
    public partial class Fr2WMP08 : Form

    {
        //string audiopath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string audiopath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath))) + "\\Audio file\\"; 
        //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP//Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 2 lần
        public Fr2WMP08()
        {
            InitializeComponent();
        }

        private void Fr2WMP08_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aP08phiDataSet1.AUDIOFILE' table. You can move, or remove it, as needed.
            //this.aUDIOFILETableAdapter.Fill(this.aP08phiDataSet.AUDIOFILE);
            try
            // TODO: This line of code loads data into the 'aP08phiDataSet.AUDIOFILE' table. You can move, or remove it, as needed.
            {
                //this.aUDIOFILETableAdapter.Fill(this.aP08phiDataSet.AUDIOFILE);
                //axWindowsMediaPlayer1.Ctlcontrols.play();
                this.audiofileTableAdapter.Fill(this.aP08phiDataSet.AUDIOFILE);
                // axWindowsMediaPlayer1.URL = "D:\\tài liệu\\lâp trinh âm thanh\\AP08VUPHI\\Audio file\\1.Sound\\haruharu.mp3";
            }
            catch (System.Exception)
            { }//MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
        }
        private void btexitform_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn đóng trang này không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Hỏi xác nhận NSD có thực sự muốn đóng Form hay không?, Kết quả NSD chọn nút nào [Yes, No] được lưu giữ trong biến ch thuộc kiểu DialogResult
            if (ch == DialogResult.Yes)//NSD đồng ý đóng Form, để về màn hình chính
            {
                this.Close();
                // Đóng Form này từ con trỏ This = CÂU LỆNH QUANG TRỌNG NHẤT (chỉ viết đúng 1 câu lệnh là OK)

            }
        }//private void btexitform_Click

        private void btexitapp_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn THOÁT CHƯƠNG TRÌNH này không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Hỏi xác nhận NSD có thực sự muốn THOÁT APP không?, Kết quả NSD chọn nút nào [Yes, No] được lưu giữ trong biến ch thuộc kiểu DialogResult
            if (ch == DialogResult.Yes)//NSD đồng ý THOÁT APP
            {
                Application.Exit(); //THOÁT APP = CÂU LỆNH QUANG TRỌNG NHẤT (chỉ viết đúng 1 câu lệnh là OK
            }
        }//private void btexitapp_Click
        //lap trinhf xu li am thanh
        private void btplay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play(); //chạy (play) file âm thanh hiện tại trên WMP
        }

        private void btplause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();// Dừng (Stop) audio file hiện đang play trên WMP

        }

        private void btfaster_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void btslower_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void btfirsttrack_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = 0;
        }

        private void btprevisoustrack_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex > 0) listBoxAuFile.SelectedIndex--;
            //Nếu chưa phải là Track ĐẦU ( > 0)  thì GIẢM vị trí Track XUỐNG 1 (--) đến Track kế TRƯỚC
            else listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1; //nếu đang là Track ĐẦU (0) thì chuyển XUỐNG Track CUỐI CÙNG(vi trí vị trí cuối: count - 1)            
        }

        private void btnexttrack_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex < listBoxAuFile.Items.Count - 1)
                listBoxAuFile.SelectedIndex++; //Nếu chưa phải là Track cuối ( < vị trí cuối: count -1) thì tăng vị trí Track lên 1(++) đến Track kế tiếp
            else listBoxAuFile.SelectedIndex = 0; //nếu đang là Track cuối (count - 1) thì chuyển về Track đầu tiên(vi trí 0)
        }

        private void btlasttrack_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1;
        }

        //viết hàm để lấy chiều dài file sẽ insert vào 
        public static int GetSoundLength(string fileName)
        {
            //kiểm tra xem đuôi file là gì 
            if(System.IO.Path.GetExtension(fileName) == ".mp3")
            {
                using (Mp3FileReader mf = new Mp3FileReader(fileName))
                {
                    return (int)mf.TotalTime.TotalSeconds;
                }
            }
            else
            {
                using (WaveFileReader wf = new WaveFileReader(fileName))
                {
                    // System.IO.File.Delete(fileName);
                    return (int)wf.TotalTime.TotalSeconds;
                }

            }
            //{
            //}
        }

        /// <summary>
        ///    /// <param name="sender"></param>
        /// <param name="e"></param>    
        /// </summary>
        static DialogResult ch = DialogResult.No;
        private void btnapthemfile_Click(object sender, EventArgs e)
        {
            tbmaso.Enabled = !tbmaso.Enabled;
            tbmota.Enabled = !tbmota.Enabled;
            btsuathongtinFile.Enabled = !btsuathongtinFile.Enabled;
            btGhiamfilemoi.Enabled = !btGhiamfilemoi.Enabled;
            btXoafile.Enabled = !btXoafile.Enabled;
            btplay.Enabled = !btplay.Enabled;
            btstop.Enabled = !btstop.Enabled;
            btplause.Enabled = !btplause.Enabled;
            btfaster.Enabled = !btfaster.Enabled;
            btslower.Enabled = !btslower.Enabled;
            btfirsttrack.Enabled = !btfirsttrack.Enabled;
            btlasttrack.Enabled = !btlasttrack.Enabled;
            btnexttrack.Enabled = !btnexttrack.Enabled;
            btprevisoustrack.Enabled = !btprevisoustrack.Enabled;
          

            if (btnapthemfile.Text == "Nạp thêm File")
            //bắt đầu nập file âm thanh = NSD chọn file & nập thông tin ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
            {//Mở OpenFilesDialog lên cho NSD chọn file âm thanh / PC
                ch = openFileDialog1.ShowDialog();
                //biến toàn cục ch đã khai báo phía trên, giữ lại nút lệnh (Y|N) mà NSD đã chọn để xử lý trong ...else..  
                tbmaso.Text = "Quý vị phải nhập mã số file vào đây";
                tbmota.Text = ""; // Xóa thống để NSD nhập mlo6 tả mới
                btnapthemfile.Text = "Lưu file âm thanh"; //Đổi nhãn (.Text) thahh2 "Lưu...": tự nhập
                

            }
            else//Sau khi NSD chọn file & nhập thông tin xong => Lưu file âm thanh vào thư mục App\AudioFiles và cập nhật thông tin file âm thanh vào DB
            {//B3: NẠP FILE ÂM THANH VÀO APP = GỒM 2 BƯỚC CƠ BẢN = COPY FILE ÂM THANH VÀO THƯ MỤC CỦA APP(AudioFiles) +Update THÔNG TIN FILE ÂM THANH VÀO DB
                if (ch == DialogResult.OK)//NSD đã đồng ý nạp file âm thanh đã chọn từ OpenFileDialog
                {
                    string tenfile = Path.GetFileName(openFileDialog1.FileName);
                   // duration đẻ lấy chiều dài âm thanh 
                    int duration = GetSoundLength(audiopath + tenfile);
                    //đổi sang kiểu string để gán cho tbchieudai.text
                    string mylength = duration.ToString();
                    tbchieudai.Text = mylength;
                    //lấy kích thước (byte) file 
                    System.IO.FileInfo file = new System.IO.FileInfo(audiopath + tenfile);
                    long fileSize = file.Length;
                    fileSize = fileSize / 1024;
     

                    //tên file âm thanh mà NSD đã chọn


                    //[1] COPY FILE ÂM THANH ĐÃ CHỌN VÀO THƯ MỤC ~\\AudioFiles
                    try
                    {
                        System.IO.File.Copy(openFileDialog1.FileName, audiopath + tenfile, true);
                        //[1 TRONG 2 CÂU LỆNH QUANG TRỌNG]  //openFileDialog1.FileName = Full path của file nguồn || System.IO.Path.GetFileName(...) lấy tên của path || true = chồng lên nêu trong thư mục đã có sẵn file
                    }
                    catch (Exception ex) { MessageBox.Show("Có lỗi copy file âm thanh: " + ex.Message); }
                 
                    //[2] NẠP THÔNG TIN CỦA FILE ÂM THANH ĐÃ CHỌN VÀO DATABASE SQL
                    if (tbmaso.Text != "" && tbmaso.Text != "Quý vị phải nhập mã số file vào đây")
                    //NSD bắt buộc nhập mã số file âm thanh thì mới lưu được.
                    {
                        try
                        {
                            
                            audiofileTableAdapter.Insert(tbmaso.Text.Trim(), tenfile, audiopath + tenfile, (int)fileSize, System.IO.Path.GetExtension(audiopath + tenfile), duration, tbmota.Text);
                            
                            //NẠP THÔNG TIN FILE ÂM THANH VÀO DB [1 TRONG 2 CÂU LỆNH QUANG TRỌNG]
                        }
                        catch (Exception ex)
                        { MessageBox.Show("Có lỗi khi nạp thông tin file âm thanh vào DB: " + ex.Message); }
                    }
                    else MessageBox.Show("Không được để trống mã file");
                    try
                    {
                        this.audiofileTableAdapter.Fill(this.aP08phiDataSet.AUDIOFILE);
                        //nạp DB files âm thanh
                    }
                    catch (Exception)
                    { }

                    btnapthemfile.Text = "Nạp thêm File";
                    //Trả lại nhãn ban đầu ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
                    
                }//NSD OK             
            }//Lưu file

        }//btnLoad = NẠP FILE ÂM THANH

        private void btsuathongtinFile_Click(object sender, EventArgs e)
        {
            tbmota.Enabled = !tbmota.Enabled;
            btnapthemfile.Enabled = !btnapthemfile.Enabled;
            btGhiamfilemoi.Enabled = !btGhiamfilemoi.Enabled;
            btXoafile.Enabled = !btXoafile.Enabled;
            btplay.Enabled = !btplay.Enabled;
            btstop.Enabled = !btstop.Enabled;
            btplause.Enabled = !btplause.Enabled;
            btfaster.Enabled = !btfaster.Enabled;
            btslower.Enabled = !btslower.Enabled;
            btfirsttrack.Enabled = !btfirsttrack.Enabled;
            btlasttrack.Enabled = !btlasttrack.Enabled;
            btnexttrack.Enabled = !btnexttrack.Enabled;
            btprevisoustrack.Enabled = !btprevisoustrack.Enabled;
            //B2: ĐỔI NHÃN (.TEXT) CỦA NÚT LỆNH : "Sửa..." <-> "Lưu..."
            if (btsuathongtinFile.Text == "Sửa thông tin files")
            //bắt đầu Sửa thông tin file âm thanh trong các TextBox ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]
            {//Thông báo nhắc NSD cách sủa thông tin
                MessageBox.Show("Quý vị sửa mô tả file trong TextBox Mô tả phía trên, Không sửa được các thông thin khác."); //thông báo hướng dẫn NSD cách sửa thông tin file

                btsuathongtinFile.Text = "Lưu sau sửa"; //Đổi nhãn (.Text) thành2 "Lưu...": tự nhập
            }
            else//Sau khi NSD sửa thông tin xong =>Lưu thông tin file âm thanh sau sửa vào DB
            {//B3: SỬA THÔNG TIN FILE ÂM THANH  + Update THÔNG TIN SỬA VÀO DB
                try
                {
                    audiofileTableAdapter.Update(tbmota.Text, tbmaso.Text.Trim());
                    //Lưu THÔNG TIN FILE ÂM THANH sau Sửa VÀO DB [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi SỬA thông tin file âm thanh: " + ex.Message); }

                //B4: Tải file mới vừa nạp vào ListBox và nghe thử / axWMP = COPY xuống TỪ trên FrWMPManagement_Load(..)
                try
                {
                    this.audiofileTableAdapter.Fill(this.aP08phiDataSet.AUDIOFILE);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
                //B5: Đổi nhãn thành ban đầu
                btsuathongtinFile.Text = "Sửa thông tin files";
                //Trả lại nhãn ban đầu ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]                
            }//else Lưu thông tin file vào DB
        }//btnModify// SỬA THÔNG TIN FILE ÂM THANH

        private void btXoafile_Click(object sender, EventArgs e)
        {
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Thiệt xóa file âm thanh: " + tbmaso.Text.Trim()
                                     + " _ " + tbnamefile.Text.Trim() + " không(Y/N)?", "Xác nhận",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //B2: XÓA Khi NSD Y
            if (ch == DialogResult.Yes)//NSD đồng ý Xóa
            {
                try
                {
                    audiofileTableAdapter.Delete(tbmaso.Text.Trim());//XÓA FILE ÂM THANH [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi XÓA file âm thanh: " + ex.Message); }
                //B3: Tải các file sau xóa lên ListBox = COPY xuống TỪ trên FrWMPManagement_Load(..)
                try
                {
                    this.audiofileTableAdapter.Fill(this.aP08phiDataSet.AUDIOFILE);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
            }//If NSD Y
        }//btnDelete// XÓA FILE ÂM THANH

    }
}
