namespace WinForm3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_order = new Label();
            ckbPencil = new CheckBox();
            ckbSharp = new CheckBox();
            ckbPen = new CheckBox();
            ckbColor = new CheckBox();
            ckbNote = new CheckBox();
            btnEvent = new Button();
            btnCheck = new Button();
            groupBox1 = new GroupBox();
            Radio_no = new RadioButton();
            radio_yes = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("핑크퐁 아기상어 Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(160, 26);
            label1.TabIndex = 0;
            label1.Text = "구매하실 상품을 체크하세요";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("핑크퐁 아기상어 Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 197);
            label2.Name = "label2";
            label2.Size = new Size(57, 26);
            label2.TabIndex = 0;
            label2.Text = "주문결과";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("핑크퐁 아기상어 Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(379, 197);
            label3.Name = "label3";
            label3.Size = new Size(148, 26);
            label3.TabIndex = 0;
            label3.Text = "봉투를 구매하시겠습니까?";
            // 
            // lb_order
            // 
            lb_order.AutoSize = true;
            lb_order.Location = new Point(50, 232);
            lb_order.Name = "lb_order";
            lb_order.Size = new Size(12, 15);
            lb_order.TabIndex = 0;
            lb_order.Text = "-";
            // 
            // ckbPencil
            // 
            ckbPencil.AutoSize = true;
            ckbPencil.Location = new Point(50, 76);
            ckbPencil.Name = "ckbPencil";
            ckbPencil.Size = new Size(50, 19);
            ckbPencil.TabIndex = 1;
            ckbPencil.Text = "연필";
            ckbPencil.UseVisualStyleBackColor = true;
            // 
            // ckbSharp
            // 
            ckbSharp.AutoSize = true;
            ckbSharp.Location = new Point(162, 76);
            ckbSharp.Name = "ckbSharp";
            ckbSharp.Size = new Size(50, 19);
            ckbSharp.TabIndex = 1;
            ckbSharp.Text = "샤프";
            ckbSharp.UseVisualStyleBackColor = true;
            // 
            // ckbPen
            // 
            ckbPen.AutoSize = true;
            ckbPen.Location = new Point(266, 76);
            ckbPen.Name = "ckbPen";
            ckbPen.Size = new Size(50, 19);
            ckbPen.TabIndex = 1;
            ckbPen.Text = "볼펜";
            ckbPen.UseVisualStyleBackColor = true;
            // 
            // ckbColor
            // 
            ckbColor.AutoSize = true;
            ckbColor.Location = new Point(370, 76);
            ckbColor.Name = "ckbColor";
            ckbColor.Size = new Size(62, 19);
            ckbColor.TabIndex = 1;
            ckbColor.Text = "색종이";
            ckbColor.UseVisualStyleBackColor = true;
            // 
            // ckbNote
            // 
            ckbNote.AutoSize = true;
            ckbNote.Location = new Point(475, 76);
            ckbNote.Name = "ckbNote";
            ckbNote.Size = new Size(50, 19);
            ckbNote.TabIndex = 1;
            ckbNote.Text = "노트";
            ckbNote.UseVisualStyleBackColor = true;
            // 
            // btnEvent
            // 
            btnEvent.Font = new Font("핑크퐁 아기상어 Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnEvent.Location = new Point(50, 119);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(162, 37);
            btnEvent.TabIndex = 2;
            btnEvent.Text = "구매하기";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("핑크퐁 아기상어 Bold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.Location = new Point(379, 309);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(90, 42);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "확인";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Radio_no);
            groupBox1.Controls.Add(radio_yes);
            groupBox1.Location = new Point(379, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 77);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "봉투구매";
            // 
            // Radio_no
            // 
            Radio_no.AutoSize = true;
            Radio_no.Location = new Point(105, 35);
            Radio_no.Name = "Radio_no";
            Radio_no.Size = new Size(61, 19);
            Radio_no.TabIndex = 0;
            Radio_no.TabStop = true;
            Radio_no.Text = "아니오";
            Radio_no.UseVisualStyleBackColor = true;
            // 
            // radio_yes
            // 
            radio_yes.AutoSize = true;
            radio_yes.Location = new Point(29, 35);
            radio_yes.Name = "radio_yes";
            radio_yes.Size = new Size(37, 19);
            radio_yes.TabIndex = 0;
            radio_yes.TabStop = true;
            radio_yes.Text = "예";
            radio_yes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnCheck);
            Controls.Add(btnEvent);
            Controls.Add(ckbNote);
            Controls.Add(ckbColor);
            Controls.Add(ckbPen);
            Controls.Add(ckbSharp);
            Controls.Add(ckbPencil);
            Controls.Add(label3);
            Controls.Add(lb_order);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_order;
        private CheckBox ckbPencil;
        private CheckBox ckbSharp;
        private CheckBox ckbPen;
        private CheckBox ckbColor;
        private CheckBox ckbNote;
        private Button btnEvent;
        private Button btnCheck;
        private GroupBox groupBox1;
        private RadioButton Radio_no;
        private RadioButton radio_yes;
    }
}
