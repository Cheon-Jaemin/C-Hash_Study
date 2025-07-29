namespace Use_Custom_Button
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.make_Controls1 = new Make_Control.Make_Controls();
            this.make_Controls21 = new Make_Control.Make_Controls2();
            this.SuspendLayout();
            // 
            // make_Controls1
            // 
            this.make_Controls1.Location = new System.Drawing.Point(188, 187);
            this.make_Controls1.Name = "make_Controls1";
            this.make_Controls1.Size = new System.Drawing.Size(260, 157);
            this.make_Controls1.TabIndex = 0;
            // 
            // make_Controls21
            // 
            this.make_Controls21.Location = new System.Drawing.Point(191, 60);
            this.make_Controls21.Name = "make_Controls21";
            this.make_Controls21.Size = new System.Drawing.Size(253, 121);
            this.make_Controls21.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.make_Controls21);
            this.Controls.Add(this.make_Controls1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Make_Control.Make_Controls make_Controls1;
        private Make_Control.Make_Controls2 make_Controls21;
    }
}

