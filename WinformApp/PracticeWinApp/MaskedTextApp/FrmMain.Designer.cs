
namespace MaskedTextApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TxtHiredDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.MaskedTextBox();
            this.TxtPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.TxtIdNum = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(29, 27);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(41, 12);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "입사일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "우편번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "휴대폰번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "주민번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "이메일";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegister.Image")));
            this.BtnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegister.Location = new System.Drawing.Point(111, 276);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(96, 27);
            this.BtnRegister.TabIndex = 12;
            this.BtnRegister.Text = "  등록";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TxtHiredDate
            // 
            this.TxtHiredDate.Location = new System.Drawing.Point(111, 24);
            this.TxtHiredDate.Mask = "0000-00-00";
            this.TxtHiredDate.Name = "TxtHiredDate";
            this.TxtHiredDate.Size = new System.Drawing.Size(84, 21);
            this.TxtHiredDate.TabIndex = 13;
            this.TxtHiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.Location = new System.Drawing.Point(111, 60);
            this.TxtZipCode.Mask = "00000";
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(52, 21);
            this.TxtZipCode.TabIndex = 14;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(111, 108);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(374, 21);
            this.TxtAddress.TabIndex = 15;
            // 
            // TxtPhoneNum
            // 
            this.TxtPhoneNum.Location = new System.Drawing.Point(111, 150);
            this.TxtPhoneNum.Mask = "000-9000-0000";
            this.TxtPhoneNum.Name = "TxtPhoneNum";
            this.TxtPhoneNum.Size = new System.Drawing.Size(100, 21);
            this.TxtPhoneNum.TabIndex = 16;
            // 
            // TxtIdNum
            // 
            this.TxtIdNum.Location = new System.Drawing.Point(111, 189);
            this.TxtIdNum.Mask = "000000-0000000";
            this.TxtIdNum.Name = "TxtIdNum";
            this.TxtIdNum.Size = new System.Drawing.Size(100, 21);
            this.TxtIdNum.TabIndex = 17;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(111, 234);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 21);
            this.TxtEmail.TabIndex = 18;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 332);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtIdNum);
            this.Controls.Add(this.TxtPhoneNum);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.TxtHiredDate);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Name = "FrmMain";
            this.Text = "사원정보 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.MaskedTextBox TxtHiredDate;
        private System.Windows.Forms.MaskedTextBox TxtZipCode;
        private System.Windows.Forms.MaskedTextBox TxtAddress;
        private System.Windows.Forms.MaskedTextBox TxtPhoneNum;
        private System.Windows.Forms.MaskedTextBox TxtIdNum;
        private System.Windows.Forms.MaskedTextBox TxtEmail;
    }
}

