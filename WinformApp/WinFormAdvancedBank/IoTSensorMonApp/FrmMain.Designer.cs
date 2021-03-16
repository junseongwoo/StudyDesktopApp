
namespace IoTSensorMonApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.시뮬레이션SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBeginSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEndSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.LblConnectTime = new System.Windows.Forms.Label();
            this.TxtSensorNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrbPhotoResister = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LsbPhotoResister = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboSerialPort = new System.Windows.Forms.ComboBox();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnDisConnect = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.ChtPhotoResister = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnZoom = new System.Windows.Forms.Button();
            this.BtnViewAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResister)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.시뮬레이션SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRoadFile,
            this.MnuSaveFile,
            this.MnuExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // MnuRoadFile
            // 
            this.MnuRoadFile.Name = "MnuRoadFile";
            this.MnuRoadFile.Size = new System.Drawing.Size(180, 22);
            this.MnuRoadFile.Text = "읽어오기(&Q)";
            // 
            // MnuSaveFile
            // 
            this.MnuSaveFile.Name = "MnuSaveFile";
            this.MnuSaveFile.Size = new System.Drawing.Size(180, 22);
            this.MnuSaveFile.Text = "저장하기(&S)";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(180, 22);
            this.MnuExit.Text = "종료(&X)";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // 시뮬레이션SToolStripMenuItem
            // 
            this.시뮬레이션SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBeginSimulation,
            this.MnuEndSimulation});
            this.시뮬레이션SToolStripMenuItem.Name = "시뮬레이션SToolStripMenuItem";
            this.시뮬레이션SToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.시뮬레이션SToolStripMenuItem.Text = "시뮬레이션(&S)";
            // 
            // MnuBeginSimulation
            // 
            this.MnuBeginSimulation.Name = "MnuBeginSimulation";
            this.MnuBeginSimulation.Size = new System.Drawing.Size(180, 22);
            this.MnuBeginSimulation.Text = "시작(&B)";
            this.MnuBeginSimulation.Click += new System.EventHandler(this.MnuBeginSimulation_Click);
            // 
            // MnuEndSimulation
            // 
            this.MnuEndSimulation.Name = "MnuEndSimulation";
            this.MnuEndSimulation.Size = new System.Drawing.Size(180, 22);
            this.MnuEndSimulation.Text = "끝(&E)";
            this.MnuEndSimulation.Click += new System.EventHandler(this.MnuEndSimulation_Click);
            // 
            // LblConnectTime
            // 
            this.LblConnectTime.AutoSize = true;
            this.LblConnectTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblConnectTime.Location = new System.Drawing.Point(12, 36);
            this.LblConnectTime.Name = "LblConnectTime";
            this.LblConnectTime.Size = new System.Drawing.Size(231, 15);
            this.LblConnectTime.TabIndex = 1;
            this.LblConnectTime.Text = "Connection Time : 2021-03-16 10:32:34:";
            // 
            // TxtSensorNum
            // 
            this.TxtSensorNum.Location = new System.Drawing.Point(261, 33);
            this.TxtSensorNum.Name = "TxtSensorNum";
            this.TxtSensorNum.ReadOnly = true;
            this.TxtSensorNum.Size = new System.Drawing.Size(100, 21);
            this.TxtSensorNum.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PrbPhotoResister);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PhotoResister";
            // 
            // PrbPhotoResister
            // 
            this.PrbPhotoResister.Location = new System.Drawing.Point(6, 36);
            this.PrbPhotoResister.Maximum = 1023;
            this.PrbPhotoResister.Name = "PrbPhotoResister";
            this.PrbPhotoResister.Size = new System.Drawing.Size(341, 23);
            this.PrbPhotoResister.TabIndex = 0;
            this.PrbPhotoResister.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "1023";
            // 
            // LsbPhotoResister
            // 
            this.LsbPhotoResister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsbPhotoResister.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LsbPhotoResister.FormattingEnabled = true;
            this.LsbPhotoResister.ItemHeight = 15;
            this.LsbPhotoResister.Location = new System.Drawing.Point(14, 161);
            this.LsbPhotoResister.Name = "LsbPhotoResister";
            this.LsbPhotoResister.ScrollAlwaysVisible = true;
            this.LsbPhotoResister.Size = new System.Drawing.Size(353, 92);
            this.LsbPhotoResister.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnConnect);
            this.groupBox2.Controls.Add(this.BtnDisConnect);
            this.groupBox2.Controls.Add(this.BtnDisplay);
            this.groupBox2.Controls.Add(this.CboSerialPort);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(373, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 228);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port";
            // 
            // CboSerialPort
            // 
            this.CboSerialPort.FormattingEnabled = true;
            this.CboSerialPort.Location = new System.Drawing.Point(6, 21);
            this.CboSerialPort.Name = "CboSerialPort";
            this.CboSerialPort.Size = new System.Drawing.Size(81, 23);
            this.CboSerialPort.TabIndex = 0;
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDisplay.Location = new System.Drawing.Point(6, 143);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(81, 69);
            this.BtnDisplay.TabIndex = 1;
            this.BtnDisplay.Text = "COM3";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            // 
            // BtnDisConnect
            // 
            this.BtnDisConnect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDisConnect.Location = new System.Drawing.Point(6, 97);
            this.BtnDisConnect.Name = "BtnDisConnect";
            this.BtnDisConnect.Size = new System.Drawing.Size(81, 40);
            this.BtnDisConnect.TabIndex = 1;
            this.BtnDisConnect.Text = "DisConnect";
            this.BtnDisConnect.UseVisualStyleBackColor = true;
            this.BtnDisConnect.Click += new System.EventHandler(this.BtnDisConnect_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(6, 55);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(81, 36);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ChtPhotoResister
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtPhotoResister.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtPhotoResister.Legends.Add(legend1);
            this.ChtPhotoResister.Location = new System.Drawing.Point(14, 262);
            this.ChtPhotoResister.Name = "ChtPhotoResister";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtPhotoResister.Series.Add(series1);
            this.ChtPhotoResister.Size = new System.Drawing.Size(458, 304);
            this.ChtPhotoResister.TabIndex = 6;
            this.ChtPhotoResister.Text = "chart1";
            // 
            // BtnZoom
            // 
            this.BtnZoom.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnZoom.Location = new System.Drawing.Point(240, 572);
            this.BtnZoom.Name = "BtnZoom";
            this.BtnZoom.Size = new System.Drawing.Size(83, 27);
            this.BtnZoom.TabIndex = 7;
            this.BtnZoom.Text = "Zoom";
            this.BtnZoom.UseVisualStyleBackColor = true;
            this.BtnZoom.Click += new System.EventHandler(this.BtnZoom_Click);
            // 
            // BtnViewAll
            // 
            this.BtnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnViewAll.Location = new System.Drawing.Point(151, 572);
            this.BtnViewAll.Name = "BtnViewAll";
            this.BtnViewAll.Size = new System.Drawing.Size(83, 27);
            this.BtnViewAll.TabIndex = 7;
            this.BtnViewAll.Text = "ViewAll";
            this.BtnViewAll.UseVisualStyleBackColor = true;
            this.BtnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.BtnViewAll);
            this.Controls.Add(this.BtnZoom);
            this.Controls.Add(this.ChtPhotoResister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LsbPhotoResister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSensorNum);
            this.Controls.Add(this.LblConnectTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT Photoresister Monitoring";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuRoadFile;
        private System.Windows.Forms.ToolStripMenuItem MnuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem 시뮬레이션SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuBeginSimulation;
        private System.Windows.Forms.ToolStripMenuItem MnuEndSimulation;
        private System.Windows.Forms.Label LblConnectTime;
        private System.Windows.Forms.TextBox TxtSensorNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PrbPhotoResister;
        private System.Windows.Forms.ListBox LsbPhotoResister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisConnect;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.ComboBox CboSerialPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtPhotoResister;
        private System.Windows.Forms.Button BtnZoom;
        private System.Windows.Forms.Button BtnViewAll;
    }
}

