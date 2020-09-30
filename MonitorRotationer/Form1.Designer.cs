namespace MonitorRotationer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.M1Clock90 = new System.Windows.Forms.Button();
            this.M1Clock180 = new System.Windows.Forms.Button();
            this.M1Clock270 = new System.Windows.Forms.Button();
            this.M1Clock0 = new System.Windows.Forms.Button();
            this.Monitor1 = new System.Windows.Forms.Label();
            this.Monitor2 = new System.Windows.Forms.Label();
            this.M2Clock0 = new System.Windows.Forms.Button();
            this.M2Clock270 = new System.Windows.Forms.Button();
            this.M2Clock180 = new System.Windows.Forms.Button();
            this.M2Clock90 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // M1Clock90
            // 
            this.M1Clock90.Location = new System.Drawing.Point(120, 12);
            this.M1Clock90.Name = "M1Clock90";
            this.M1Clock90.Size = new System.Drawing.Size(52, 28);
            this.M1Clock90.TabIndex = 0;
            this.M1Clock90.Text = "90도";
            this.M1Clock90.UseVisualStyleBackColor = true;
            this.M1Clock90.Click += new System.EventHandler(this.M1Clock90_Click);
            // 
            // M1Clock180
            // 
            this.M1Clock180.Location = new System.Drawing.Point(178, 12);
            this.M1Clock180.Name = "M1Clock180";
            this.M1Clock180.Size = new System.Drawing.Size(52, 28);
            this.M1Clock180.TabIndex = 1;
            this.M1Clock180.Text = "180도";
            this.M1Clock180.UseVisualStyleBackColor = true;
            this.M1Clock180.Click += new System.EventHandler(this.M1Clock180_Click);
            // 
            // M1Clock270
            // 
            this.M1Clock270.Location = new System.Drawing.Point(236, 12);
            this.M1Clock270.Name = "M1Clock270";
            this.M1Clock270.Size = new System.Drawing.Size(52, 28);
            this.M1Clock270.TabIndex = 2;
            this.M1Clock270.Text = "270도";
            this.M1Clock270.UseVisualStyleBackColor = true;
            this.M1Clock270.Click += new System.EventHandler(this.M1Clock270_Click);
            // 
            // M1Clock0
            // 
            this.M1Clock0.Location = new System.Drawing.Point(62, 12);
            this.M1Clock0.Name = "M1Clock0";
            this.M1Clock0.Size = new System.Drawing.Size(52, 28);
            this.M1Clock0.TabIndex = 3;
            this.M1Clock0.Text = "0도";
            this.M1Clock0.UseVisualStyleBackColor = true;
            this.M1Clock0.Click += new System.EventHandler(this.M1Clock0_Click);
            // 
            // Monitor1
            // 
            this.Monitor1.AutoSize = true;
            this.Monitor1.Location = new System.Drawing.Point(9, 20);
            this.Monitor1.Name = "Monitor1";
            this.Monitor1.Size = new System.Drawing.Size(47, 12);
            this.Monitor1.TabIndex = 4;
            this.Monitor1.Text = "모니터1";
            // 
            // Monitor2
            // 
            this.Monitor2.AutoSize = true;
            this.Monitor2.Location = new System.Drawing.Point(9, 58);
            this.Monitor2.Name = "Monitor2";
            this.Monitor2.Size = new System.Drawing.Size(47, 12);
            this.Monitor2.TabIndex = 5;
            this.Monitor2.Text = "모니터2";
            // 
            // M2Clock0
            // 
            this.M2Clock0.Location = new System.Drawing.Point(62, 50);
            this.M2Clock0.Name = "M2Clock0";
            this.M2Clock0.Size = new System.Drawing.Size(52, 28);
            this.M2Clock0.TabIndex = 9;
            this.M2Clock0.Text = "0도";
            this.M2Clock0.UseVisualStyleBackColor = true;
            this.M2Clock0.Click += new System.EventHandler(this.M2Clock0_Click);
            // 
            // M2Clock270
            // 
            this.M2Clock270.Location = new System.Drawing.Point(236, 50);
            this.M2Clock270.Name = "M2Clock270";
            this.M2Clock270.Size = new System.Drawing.Size(52, 28);
            this.M2Clock270.TabIndex = 8;
            this.M2Clock270.Text = "270도";
            this.M2Clock270.UseVisualStyleBackColor = true;
            this.M2Clock270.Click += new System.EventHandler(this.M2Clock270_Click);
            // 
            // M2Clock180
            // 
            this.M2Clock180.Location = new System.Drawing.Point(178, 50);
            this.M2Clock180.Name = "M2Clock180";
            this.M2Clock180.Size = new System.Drawing.Size(52, 28);
            this.M2Clock180.TabIndex = 7;
            this.M2Clock180.Text = "180도";
            this.M2Clock180.UseVisualStyleBackColor = true;
            this.M2Clock180.Click += new System.EventHandler(this.M2Clock180_Click);
            // 
            // M2Clock90
            // 
            this.M2Clock90.Location = new System.Drawing.Point(120, 50);
            this.M2Clock90.Name = "M2Clock90";
            this.M2Clock90.Size = new System.Drawing.Size(52, 28);
            this.M2Clock90.TabIndex = 6;
            this.M2Clock90.Text = "90도";
            this.M2Clock90.UseVisualStyleBackColor = true;
            this.M2Clock90.Click += new System.EventHandler(this.M2Clock90_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(299, 92);
            this.Controls.Add(this.M2Clock0);
            this.Controls.Add(this.M2Clock270);
            this.Controls.Add(this.M2Clock180);
            this.Controls.Add(this.M2Clock90);
            this.Controls.Add(this.Monitor2);
            this.Controls.Add(this.Monitor1);
            this.Controls.Add(this.M1Clock0);
            this.Controls.Add(this.M1Clock270);
            this.Controls.Add(this.M1Clock180);
            this.Controls.Add(this.M1Clock90);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "모니터 회전";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button M1Clock90;
        private System.Windows.Forms.Button M1Clock180;
        private System.Windows.Forms.Button M1Clock270;
        private System.Windows.Forms.Button M1Clock0;
        private System.Windows.Forms.Label Monitor1;
        private System.Windows.Forms.Label Monitor2;
        private System.Windows.Forms.Button M2Clock0;
        private System.Windows.Forms.Button M2Clock270;
        private System.Windows.Forms.Button M2Clock180;
        private System.Windows.Forms.Button M2Clock90;
    }
}

