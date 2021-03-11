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

namespace DigitalAlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime setDay;
        private DateTime setTime;
        private bool IsSetAlarm;
        private Timer MyTimer = new Timer();
        WindowsMediaPlayer mediaPlayer;
        
        public FrmAlarm()
        {
            InitializeComponent();

            // 초기화 작업
        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            mediaPlayer = new WindowsMediaPlayer();

            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text = ""; // 시작할때 글자를 지워줌

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.CustomFormat = "hh:mm:ss";

            MyTimer.Interval = 1000; // 1sec
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Enabled = true;
            MyTimer.Start();

            TabClock.SelectedTab = TapDigitalClock;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            LblDate.Text = curDate.ToShortDateString();
            LblTime.Text = curDate.ToLongTimeString();

            if (IsSetAlarm)
            {
                // 알람 시간하고 현재시간 일치하면 알람울림
                if (setDay == DateTime.Today &&
                    setTime.Hour == curDate.Hour &&
                    setTime.Minute == curDate.Minute &&
                    setTime.Second == curDate.Second)
                {
                    IsSetAlarm = false; // 알람 설정 종료
                    BtnRelease_Click(sender, e);
                    mediaPlayer.URL = @".\medias\alarm.mp3";
                    mediaPlayer.controls.play();
                    MessageBox.Show("알람!!!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            setDay = DateTime.Parse(DtpAlarmDate.Text);
            setTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {setDay.ToShortTimeString()} {setTime.ToString("hh:mm:ss")}";
            LblAlarm.ForeColor = Color.Red;

            TabClock.SelectedTab = TapDigitalClock;
            IsSetAlarm = true;
        }

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            IsSetAlarm = false;
            LblAlarm.Text = "Alarm :";
            LblAlarm.ForeColor = Color.Gray;
            TabClock.SelectedTab = TapDigitalClock;
        }
    }
}
