namespace van1067fixer
{
    partial class van1067fixer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fix = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(634, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Release Channel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "VALORANT VAN 1067 Error Fixer";
            // 
            // fix
            // 
            this.fix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fix.Location = new System.Drawing.Point(12, 185);
            this.fix.Name = "fix";
            this.fix.Size = new System.Drawing.Size(733, 27);
            this.fix.TabIndex = 10;
            this.fix.Text = "Fix and Reboot";
            this.fix.UseVisualStyleBackColor = true;
            this.fix.Click += new System.EventHandler(this.fix_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "⚠️ 주의해주세요, 아래 버튼 클릭시 해결후 자동으로 재부팅됩니다.\r\n진행중인 작업을 종료하고 실행해주세요.";
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(12, 218);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(733, 27);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel Reboot";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // van1067fixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(757, 257);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fix);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "van1067fixer";
            this.ShowIcon = false;
            this.Text = "van1067 error Fixer";
            this.Load += new System.EventHandler(this.van1067fixer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel;
    }
}

