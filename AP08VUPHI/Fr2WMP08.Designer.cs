namespace AP08VUPHI
{
    partial class Fr2WMP08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr2WMP08));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.aUDIOFILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aP08phiDataSet = new AP08VUPHI.AP08phiDataSet();
            this.listBoxAuFile = new System.Windows.Forms.ListBox();
            this.groupBoxAudioInfo = new System.Windows.Forms.GroupBox();
            this.tbmota = new System.Windows.Forms.TextBox();
            this.tbchieudai = new System.Windows.Forms.TextBox();
            this.tbphanmorong = new System.Windows.Forms.TextBox();
            this.tbsize = new System.Windows.Forms.TextBox();
            this.tbpath = new System.Windows.Forms.TextBox();
            this.tbnamefile = new System.Windows.Forms.TextBox();
            this.tbmaso = new System.Windows.Forms.TextBox();
            this.lbmota = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.lbchieudai = new System.Windows.Forms.Label();
            this.lbphanmorong = new System.Windows.Forms.Label();
            this.lbKB = new System.Windows.Forms.Label();
            this.lbsize = new System.Windows.Forms.Label();
            this.lbpath = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbmaso = new System.Windows.Forms.Label();
            this.lbFileinfo = new System.Windows.Forms.Label();
            this.lbAudioSelect = new System.Windows.Forms.Label();
            this.groupBoxAudioText = new System.Windows.Forms.GroupBox();
            this.btslower = new System.Windows.Forms.Button();
            this.btfaster = new System.Windows.Forms.Button();
            this.btplause = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.btnexttrack = new System.Windows.Forms.Button();
            this.btlasttrack = new System.Windows.Forms.Button();
            this.btprevisoustrack = new System.Windows.Forms.Button();
            this.btfirsttrack = new System.Windows.Forms.Button();
            this.btplay = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnapthemfile = new System.Windows.Forms.Button();
            this.btsuathongtinFile = new System.Windows.Forms.Button();
            this.btGhiamfilemoi = new System.Windows.Forms.Button();
            this.btXoafile = new System.Windows.Forms.Button();
            this.btexitform = new System.Windows.Forms.Button();
            this.btexitapp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.audiofileTableAdapter = new AP08VUPHI.AP08phiDataSetTableAdapters.AUDIOFILETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aP08phiDataSet)).BeginInit();
            this.groupBoxAudioInfo.SuspendLayout();
            this.groupBoxAudioText.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.DataBindings.Add(new System.Windows.Forms.Binding("URL", this.aUDIOFILEBindingSource, "filepath", true));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(16, 21);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(398, 180);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // aUDIOFILEBindingSource
            // 
            this.aUDIOFILEBindingSource.DataMember = "AUDIOFILE";
            this.aUDIOFILEBindingSource.DataSource = this.aP08phiDataSet;
            // 
            // aP08phiDataSet
            // 
            this.aP08phiDataSet.DataSetName = "AP08phiDataSet";
            this.aP08phiDataSet.Locale = new System.Globalization.CultureInfo("");
            this.aP08phiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBoxAuFile
            // 
            this.listBoxAuFile.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxAuFile.DataSource = this.aUDIOFILEBindingSource;
            this.listBoxAuFile.DisplayMember = "filename";
            this.listBoxAuFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxAuFile.FormattingEnabled = true;
            this.listBoxAuFile.ItemHeight = 16;
            this.listBoxAuFile.Location = new System.Drawing.Point(0, 38);
            this.listBoxAuFile.Name = "listBoxAuFile";
            this.listBoxAuFile.Size = new System.Drawing.Size(206, 244);
            this.listBoxAuFile.TabIndex = 1;
            this.listBoxAuFile.ValueMember = "filepath";
            // 
            // groupBoxAudioInfo
            // 
            this.groupBoxAudioInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAudioInfo.BackgroundImage = global::AP08VUPHI.Properties.Resources._1cca1e16dafde6dab9d5fa3d240039dc;
            this.groupBoxAudioInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxAudioInfo.Controls.Add(this.tbmota);
            this.groupBoxAudioInfo.Controls.Add(this.tbchieudai);
            this.groupBoxAudioInfo.Controls.Add(this.tbphanmorong);
            this.groupBoxAudioInfo.Controls.Add(this.tbsize);
            this.groupBoxAudioInfo.Controls.Add(this.tbpath);
            this.groupBoxAudioInfo.Controls.Add(this.tbnamefile);
            this.groupBoxAudioInfo.Controls.Add(this.tbmaso);
            this.groupBoxAudioInfo.Controls.Add(this.lbmota);
            this.groupBoxAudioInfo.Controls.Add(this.lbs);
            this.groupBoxAudioInfo.Controls.Add(this.lbchieudai);
            this.groupBoxAudioInfo.Controls.Add(this.lbphanmorong);
            this.groupBoxAudioInfo.Controls.Add(this.lbKB);
            this.groupBoxAudioInfo.Controls.Add(this.lbsize);
            this.groupBoxAudioInfo.Controls.Add(this.lbpath);
            this.groupBoxAudioInfo.Controls.Add(this.lbname);
            this.groupBoxAudioInfo.Controls.Add(this.lbmaso);
            this.groupBoxAudioInfo.Controls.Add(this.lbFileinfo);
            this.groupBoxAudioInfo.Controls.Add(this.lbAudioSelect);
            this.groupBoxAudioInfo.Controls.Add(this.listBoxAuFile);
            this.groupBoxAudioInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxAudioInfo.ForeColor = System.Drawing.Color.Olive;
            this.groupBoxAudioInfo.Location = new System.Drawing.Point(12, 55);
            this.groupBoxAudioInfo.Name = "groupBoxAudioInfo";
            this.groupBoxAudioInfo.Size = new System.Drawing.Size(602, 376);
            this.groupBoxAudioInfo.TabIndex = 0;
            this.groupBoxAudioInfo.TabStop = false;
            this.groupBoxAudioInfo.Text = "QUẢN LÝ THÔNG TIN FILES ÂM THANH";
            // 
            // tbmota
            // 
            this.tbmota.BackColor = System.Drawing.SystemColors.Info;
            this.tbmota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILEBindingSource, "description", true));
            this.tbmota.Enabled = false;
            this.tbmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbmota.Location = new System.Drawing.Point(237, 305);
            this.tbmota.Multiline = true;
            this.tbmota.Name = "tbmota";
            this.tbmota.Size = new System.Drawing.Size(354, 62);
            this.tbmota.TabIndex = 8;
            // 
            // tbchieudai
            // 
            this.tbchieudai.BackColor = System.Drawing.SystemColors.Info;
            this.tbchieudai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILEBindingSource, "length", true));
            this.tbchieudai.Enabled = false;
            this.tbchieudai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbchieudai.Location = new System.Drawing.Point(334, 250);
            this.tbchieudai.Name = "tbchieudai";
            this.tbchieudai.Size = new System.Drawing.Size(233, 22);
            this.tbchieudai.TabIndex = 7;
            // 
            // tbphanmorong
            // 
            this.tbphanmorong.BackColor = System.Drawing.SystemColors.Info;
            this.tbphanmorong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILEBindingSource, "ext", true));
            this.tbphanmorong.Enabled = false;
            this.tbphanmorong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbphanmorong.Location = new System.Drawing.Point(334, 208);
            this.tbphanmorong.Name = "tbphanmorong";
            this.tbphanmorong.Size = new System.Drawing.Size(257, 22);
            this.tbphanmorong.TabIndex = 6;
            // 
            // tbsize
            // 
            this.tbsize.BackColor = System.Drawing.SystemColors.Info;
            this.tbsize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILEBindingSource, "size", true));
            this.tbsize.Enabled = false;
            this.tbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbsize.Location = new System.Drawing.Point(334, 167);
            this.tbsize.Name = "tbsize";
            this.tbsize.Size = new System.Drawing.Size(209, 22);
            this.tbsize.TabIndex = 5;
            // 
            // tbpath
            // 
            this.tbpath.BackColor = System.Drawing.SystemColors.Info;
            this.tbpath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILEBindingSource, "filepath", true));
            this.tbpath.Enabled = false;
            this.tbpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbpath.Location = new System.Drawing.Point(334, 127);
            this.tbpath.Name = "tbpath";
            this.tbpath.Size = new System.Drawing.Size(257, 22);
            this.tbpath.TabIndex = 4;
            // 
            // tbnamefile
            // 
            this.tbnamefile.BackColor = System.Drawing.SystemColors.Info;
            this.tbnamefile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILEBindingSource, "filename", true));
            this.tbnamefile.Enabled = false;
            this.tbnamefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbnamefile.Location = new System.Drawing.Point(334, 84);
            this.tbnamefile.Name = "tbnamefile";
            this.tbnamefile.Size = new System.Drawing.Size(257, 22);
            this.tbnamefile.TabIndex = 3;
            // 
            // tbmaso
            // 
            this.tbmaso.BackColor = System.Drawing.SystemColors.Info;
            this.tbmaso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILEBindingSource, "ms", true));
            this.tbmaso.Enabled = false;
            this.tbmaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbmaso.Location = new System.Drawing.Point(334, 45);
            this.tbmaso.Name = "tbmaso";
            this.tbmaso.Size = new System.Drawing.Size(257, 22);
            this.tbmaso.TabIndex = 2;
            // 
            // lbmota
            // 
            this.lbmota.AutoSize = true;
            this.lbmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbmota.ForeColor = System.Drawing.Color.Ivory;
            this.lbmota.Location = new System.Drawing.Point(234, 285);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(45, 16);
            this.lbmota.TabIndex = 0;
            this.lbmota.Text = "Mô tả";
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.ForeColor = System.Drawing.Color.LightYellow;
            this.lbs.Location = new System.Drawing.Point(577, 256);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(15, 16);
            this.lbs.TabIndex = 0;
            this.lbs.Text = "s";
            // 
            // lbchieudai
            // 
            this.lbchieudai.AutoSize = true;
            this.lbchieudai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbchieudai.ForeColor = System.Drawing.Color.Ivory;
            this.lbchieudai.Location = new System.Drawing.Point(234, 256);
            this.lbchieudai.Name = "lbchieudai";
            this.lbchieudai.Size = new System.Drawing.Size(72, 16);
            this.lbchieudai.TabIndex = 0;
            this.lbchieudai.Text = "Chiều dài";
            // 
            // lbphanmorong
            // 
            this.lbphanmorong.AutoSize = true;
            this.lbphanmorong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbphanmorong.ForeColor = System.Drawing.Color.Ivory;
            this.lbphanmorong.Location = new System.Drawing.Point(234, 214);
            this.lbphanmorong.Name = "lbphanmorong";
            this.lbphanmorong.Size = new System.Drawing.Size(90, 16);
            this.lbphanmorong.TabIndex = 0;
            this.lbphanmorong.Text = "Phần mở rộng";
            // 
            // lbKB
            // 
            this.lbKB.AutoSize = true;
            this.lbKB.ForeColor = System.Drawing.Color.LightYellow;
            this.lbKB.Location = new System.Drawing.Point(549, 173);
            this.lbKB.Name = "lbKB";
            this.lbKB.Size = new System.Drawing.Size(47, 16);
            this.lbKB.TabIndex = 0;
            this.lbKB.Text = "KByte";
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbsize.ForeColor = System.Drawing.Color.Ivory;
            this.lbsize.Location = new System.Drawing.Point(234, 173);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(83, 16);
            this.lbsize.TabIndex = 3;
            this.lbsize.Text = "Kích Thước";
            // 
            // lbpath
            // 
            this.lbpath.AutoSize = true;
            this.lbpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbpath.ForeColor = System.Drawing.Color.Ivory;
            this.lbpath.Location = new System.Drawing.Point(234, 133);
            this.lbpath.Name = "lbpath";
            this.lbpath.Size = new System.Drawing.Size(81, 16);
            this.lbpath.TabIndex = 0;
            this.lbpath.Text = "Đường dẫn";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbname.ForeColor = System.Drawing.Color.Ivory;
            this.lbname.Location = new System.Drawing.Point(234, 90);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(64, 16);
            this.lbname.TabIndex = 3;
            this.lbname.Text = "Tên File";
            // 
            // lbmaso
            // 
            this.lbmaso.AutoSize = true;
            this.lbmaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbmaso.ForeColor = System.Drawing.Color.Ivory;
            this.lbmaso.Location = new System.Drawing.Point(234, 51);
            this.lbmaso.Name = "lbmaso";
            this.lbmaso.Size = new System.Drawing.Size(49, 16);
            this.lbmaso.TabIndex = 3;
            this.lbmaso.Text = "Mã số";
            // 
            // lbFileinfo
            // 
            this.lbFileinfo.AutoSize = true;
            this.lbFileinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFileinfo.Location = new System.Drawing.Point(258, 18);
            this.lbFileinfo.Name = "lbFileinfo";
            this.lbFileinfo.Size = new System.Drawing.Size(261, 17);
            this.lbFileinfo.TabIndex = 0;
            this.lbFileinfo.Text = "Thông tin chi tiết về File âm thanh ";
            // 
            // lbAudioSelect
            // 
            this.lbAudioSelect.AutoSize = true;
            this.lbAudioSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAudioSelect.Location = new System.Drawing.Point(6, 18);
            this.lbAudioSelect.Name = "lbAudioSelect";
            this.lbAudioSelect.Size = new System.Drawing.Size(148, 17);
            this.lbAudioSelect.TabIndex = 0;
            this.lbAudioSelect.Text = "Chọn File âm thanh";
            // 
            // groupBoxAudioText
            // 
            this.groupBoxAudioText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(144)))));
            this.groupBoxAudioText.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBoxAudioText.Controls.Add(this.btslower);
            this.groupBoxAudioText.Controls.Add(this.btfaster);
            this.groupBoxAudioText.Controls.Add(this.btplause);
            this.groupBoxAudioText.Controls.Add(this.btstop);
            this.groupBoxAudioText.Controls.Add(this.btnexttrack);
            this.groupBoxAudioText.Controls.Add(this.btlasttrack);
            this.groupBoxAudioText.Controls.Add(this.btprevisoustrack);
            this.groupBoxAudioText.Controls.Add(this.btfirsttrack);
            this.groupBoxAudioText.Controls.Add(this.btplay);
            this.groupBoxAudioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxAudioText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBoxAudioText.Location = new System.Drawing.Point(631, 55);
            this.groupBoxAudioText.Name = "groupBoxAudioText";
            this.groupBoxAudioText.Size = new System.Drawing.Size(573, 376);
            this.groupBoxAudioText.TabIndex = 0;
            this.groupBoxAudioText.TabStop = false;
            this.groupBoxAudioText.Text = "KIỂM (NGHE THỬ: TEST) FILES ÂM THANH";
            // 
            // btslower
            // 
            this.btslower.BackColor = System.Drawing.Color.PaleGreen;
            this.btslower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btslower.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btslower.Location = new System.Drawing.Point(454, 256);
            this.btslower.Name = "btslower";
            this.btslower.Size = new System.Drawing.Size(95, 42);
            this.btslower.TabIndex = 14;
            this.btslower.Text = "SLOWER";
            this.btslower.UseVisualStyleBackColor = false;
            this.btslower.Click += new System.EventHandler(this.btslower_Click);
            // 
            // btfaster
            // 
            this.btfaster.BackColor = System.Drawing.Color.PaleGreen;
            this.btfaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btfaster.Location = new System.Drawing.Point(341, 256);
            this.btfaster.Name = "btfaster";
            this.btfaster.Size = new System.Drawing.Size(86, 42);
            this.btfaster.TabIndex = 13;
            this.btfaster.Text = "FASTER";
            this.btfaster.UseVisualStyleBackColor = false;
            this.btfaster.Click += new System.EventHandler(this.btfaster_Click);
            // 
            // btplause
            // 
            this.btplause.BackColor = System.Drawing.Color.PaleGreen;
            this.btplause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btplause.Location = new System.Drawing.Point(123, 256);
            this.btplause.Name = "btplause";
            this.btplause.Size = new System.Drawing.Size(86, 42);
            this.btplause.TabIndex = 11;
            this.btplause.Text = "PLAUSE";
            this.btplause.UseVisualStyleBackColor = false;
            this.btplause.Click += new System.EventHandler(this.btplause_Click);
            // 
            // btstop
            // 
            this.btstop.BackColor = System.Drawing.Color.PaleGreen;
            this.btstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btstop.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btstop.Location = new System.Drawing.Point(231, 256);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(91, 42);
            this.btstop.TabIndex = 12;
            this.btstop.Text = "STOP";
            this.btstop.UseVisualStyleBackColor = false;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // btnexttrack
            // 
            this.btnexttrack.BackColor = System.Drawing.Color.SeaGreen;
            this.btnexttrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnexttrack.ForeColor = System.Drawing.Color.Ivory;
            this.btnexttrack.Location = new System.Drawing.Point(316, 319);
            this.btnexttrack.Name = "btnexttrack";
            this.btnexttrack.Size = new System.Drawing.Size(111, 43);
            this.btnexttrack.TabIndex = 17;
            this.btnexttrack.Text = "NEXT TRACK";
            this.btnexttrack.UseVisualStyleBackColor = false;
            this.btnexttrack.Click += new System.EventHandler(this.btnexttrack_Click);
            // 
            // btlasttrack
            // 
            this.btlasttrack.BackColor = System.Drawing.Color.SeaGreen;
            this.btlasttrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btlasttrack.ForeColor = System.Drawing.Color.Ivory;
            this.btlasttrack.Location = new System.Drawing.Point(446, 319);
            this.btlasttrack.Name = "btlasttrack";
            this.btlasttrack.Size = new System.Drawing.Size(103, 43);
            this.btlasttrack.TabIndex = 18;
            this.btlasttrack.Text = "LAST TRACK";
            this.btlasttrack.UseVisualStyleBackColor = false;
            this.btlasttrack.Click += new System.EventHandler(this.btlasttrack_Click);
            // 
            // btprevisoustrack
            // 
            this.btprevisoustrack.BackColor = System.Drawing.Color.SeaGreen;
            this.btprevisoustrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btprevisoustrack.ForeColor = System.Drawing.Color.Ivory;
            this.btprevisoustrack.Location = new System.Drawing.Point(151, 319);
            this.btprevisoustrack.Name = "btprevisoustrack";
            this.btprevisoustrack.Size = new System.Drawing.Size(143, 43);
            this.btprevisoustrack.TabIndex = 16;
            this.btprevisoustrack.Text = "PREVISOUS TRACK";
            this.btprevisoustrack.UseVisualStyleBackColor = false;
            this.btprevisoustrack.Click += new System.EventHandler(this.btprevisoustrack_Click);
            // 
            // btfirsttrack
            // 
            this.btfirsttrack.BackColor = System.Drawing.Color.SeaGreen;
            this.btfirsttrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btfirsttrack.ForeColor = System.Drawing.Color.Ivory;
            this.btfirsttrack.Location = new System.Drawing.Point(16, 319);
            this.btfirsttrack.Name = "btfirsttrack";
            this.btfirsttrack.Size = new System.Drawing.Size(115, 43);
            this.btfirsttrack.TabIndex = 15;
            this.btfirsttrack.Text = "FIRST TRACK";
            this.btfirsttrack.UseVisualStyleBackColor = false;
            this.btfirsttrack.Click += new System.EventHandler(this.btfirsttrack_Click);
            // 
            // btplay
            // 
            this.btplay.BackColor = System.Drawing.Color.PaleGreen;
            this.btplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btplay.Location = new System.Drawing.Point(16, 256);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(85, 45);
            this.btplay.TabIndex = 10;
            this.btplay.Text = "PLAY";
            this.btplay.UseVisualStyleBackColor = false;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Ivory;
            this.lbTitle.Location = new System.Drawing.Point(169, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(867, 25);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "08 VŨ PHI QUẢN LÝ ÂM THANH DÙNG THƯ VIỆN WINDOWS MEDIA PLAYER";
            // 
            // btnapthemfile
            // 
            this.btnapthemfile.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnapthemfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnapthemfile.Location = new System.Drawing.Point(11, 450);
            this.btnapthemfile.Name = "btnapthemfile";
            this.btnapthemfile.Size = new System.Drawing.Size(116, 43);
            this.btnapthemfile.TabIndex = 19;
            this.btnapthemfile.Text = "Nạp thêm File";
            this.btnapthemfile.UseVisualStyleBackColor = false;
            this.btnapthemfile.Click += new System.EventHandler(this.btnapthemfile_Click);
            // 
            // btsuathongtinFile
            // 
            this.btsuathongtinFile.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btsuathongtinFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btsuathongtinFile.Location = new System.Drawing.Point(203, 450);
            this.btsuathongtinFile.Name = "btsuathongtinFile";
            this.btsuathongtinFile.Size = new System.Drawing.Size(153, 43);
            this.btsuathongtinFile.TabIndex = 20;
            this.btsuathongtinFile.Text = "Sửa thông tin File";
            this.btsuathongtinFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btsuathongtinFile.UseVisualStyleBackColor = false;
            this.btsuathongtinFile.Click += new System.EventHandler(this.btsuathongtinFile_Click);
            // 
            // btGhiamfilemoi
            // 
            this.btGhiamfilemoi.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btGhiamfilemoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGhiamfilemoi.Location = new System.Drawing.Point(425, 450);
            this.btGhiamfilemoi.Name = "btGhiamfilemoi";
            this.btGhiamfilemoi.Size = new System.Drawing.Size(153, 43);
            this.btGhiamfilemoi.TabIndex = 21;
            this.btGhiamfilemoi.Text = "Ghi âm File mới";
            this.btGhiamfilemoi.UseVisualStyleBackColor = false;
            // 
            // btXoafile
            // 
            this.btXoafile.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btXoafile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btXoafile.Location = new System.Drawing.Point(648, 450);
            this.btXoafile.Name = "btXoafile";
            this.btXoafile.Size = new System.Drawing.Size(114, 43);
            this.btXoafile.TabIndex = 22;
            this.btXoafile.Text = "Xóa File";
            this.btXoafile.UseVisualStyleBackColor = false;
            this.btXoafile.Click += new System.EventHandler(this.btXoafile_Click);
            // 
            // btexitform
            // 
            this.btexitform.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btexitform.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btexitform.Location = new System.Drawing.Point(819, 450);
            this.btexitform.Name = "btexitform";
            this.btexitform.Size = new System.Drawing.Size(208, 43);
            this.btexitform.TabIndex = 23;
            this.btexitform.Text = "Đóng File về màn hình Chính";
            this.btexitform.UseVisualStyleBackColor = false;
            this.btexitform.Click += new System.EventHandler(this.btexitform_Click);
            // 
            // btexitapp
            // 
            this.btexitapp.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btexitapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btexitapp.Location = new System.Drawing.Point(1089, 450);
            this.btexitapp.Name = "btexitapp";
            this.btexitapp.Size = new System.Drawing.Size(115, 43);
            this.btexitapp.TabIndex = 24;
            this.btexitapp.Text = "Thoát khỏi App";
            this.btexitapp.UseVisualStyleBackColor = false;
            this.btexitapp.Click += new System.EventHandler(this.btexitapp_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // audiofileTableAdapter
            // 
            this.audiofileTableAdapter.ClearBeforeFill = true;
            // 
            // Fr2WMP08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 505);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.groupBoxAudioText);
            this.Controls.Add(this.groupBoxAudioInfo);
            this.Controls.Add(this.btexitapp);
            this.Controls.Add(this.btexitform);
            this.Controls.Add(this.btXoafile);
            this.Controls.Add(this.btGhiamfilemoi);
            this.Controls.Add(this.btsuathongtinFile);
            this.Controls.Add(this.btnapthemfile);
            this.DoubleBuffered = true;
            this.Name = "Fr2WMP08";
            this.Text = "08 VŨ PHI QUẢN LÝ ÂM THANH DÙNG THƯ VIỆN WINDOWS MEDIA PLAYER";
            this.Load += new System.EventHandler(this.Fr2WMP08_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aP08phiDataSet)).EndInit();
            this.groupBoxAudioInfo.ResumeLayout(false);
            this.groupBoxAudioInfo.PerformLayout();
            this.groupBoxAudioText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBoxAuFile;
        private System.Windows.Forms.BindingSource aUDIOFILEBindingSource;
        private System.Windows.Forms.GroupBox groupBoxAudioInfo;
        private System.Windows.Forms.GroupBox groupBoxAudioText;
        private System.Windows.Forms.Label lbFileinfo;
        private System.Windows.Forms.Label lbAudioSelect;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbmota;
        private System.Windows.Forms.TextBox tbchieudai;
        private System.Windows.Forms.TextBox tbphanmorong;
        private System.Windows.Forms.TextBox tbsize;
        private System.Windows.Forms.TextBox tbpath;
        private System.Windows.Forms.TextBox tbnamefile;
        private System.Windows.Forms.TextBox tbmaso;
        private System.Windows.Forms.Label lbmota;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Label lbchieudai;
        private System.Windows.Forms.Label lbphanmorong;
        private System.Windows.Forms.Label lbKB;
        private System.Windows.Forms.Label lbsize;
        private System.Windows.Forms.Label lbpath;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbmaso;
        private System.Windows.Forms.Button btslower;
        private System.Windows.Forms.Button btfaster;
        private System.Windows.Forms.Button btplause;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Button btnexttrack;
        private System.Windows.Forms.Button btlasttrack;
        private System.Windows.Forms.Button btprevisoustrack;
        private System.Windows.Forms.Button btfirsttrack;
        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button btnapthemfile;
        private System.Windows.Forms.Button btsuathongtinFile;
        private System.Windows.Forms.Button btGhiamfilemoi;
        private System.Windows.Forms.Button btXoafile;
        private System.Windows.Forms.Button btexitform;
        private System.Windows.Forms.Button btexitapp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AP08phiDataSet aP08phiDataSet;
        private AP08phiDataSetTableAdapters.AUDIOFILETableAdapter audiofileTableAdapter;
    }
}