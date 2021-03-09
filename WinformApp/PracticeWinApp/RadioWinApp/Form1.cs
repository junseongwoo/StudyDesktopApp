using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            if (RdbKorea.Checked == false && RdbJapan.Checked == false &&
                RdbChina.Checked == false && RdbAther.Checked == false)
            {
                MessageBox.Show("국가를 선택하세요");
                return;
            }

            if (Rdbmale.Checked == false && Rdbfemale.Checked == false)
            {
                MessageBox.Show("성별을 선택하세요");
                return;
            }

            if (RdbKorea.Checked)
            {
                result = "국적 : 대한민국\n";
            }
            else if(RdbChina.Checked)
            {
                result = "국적 : 중국\n";
            }
            else if (RdbJapan.Checked)
            {
                result = "국적 : 일본\n";
            }
            else if (RdbAther.Checked)
            {
                result = "국적 : 그 외 국가\n";
            }

            if(Rdbmale.Checked)
            {
                result = "성별 : 남자\n";
            }
            else if (Rdbfemale.Checked)
            {
                result = "성별 : 여자\n";
            }

            MessageBox.Show(result, "결과");
        }
    }
}
