namespace Make_Control
{
    partial class Make_Controls
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDate = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.MistyRose;
            this.btnDate.Font = new System.Drawing.Font("배스킨라빈스 R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDate.Location = new System.Drawing.Point(17, 24);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(221, 38);
            this.btnDate.TabIndex = 0;
            this.btnDate.Text = "날짜";
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnTime.Font = new System.Drawing.Font("배스킨라빈스 R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTime.Location = new System.Drawing.Point(17, 96);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(221, 38);
            this.btnTime.TabIndex = 0;
            this.btnTime.Text = "시간";
            this.btnTime.UseVisualStyleBackColor = false;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // Make_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnDate);
            this.Name = "Make_Controls";
            this.Size = new System.Drawing.Size(260, 157);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnTime;
    }
}
