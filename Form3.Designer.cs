namespace FirstFormApplication
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lb_short = new Label();
            lb_int = new Label();
            lb_double = new Label();
            lb_Exception = new Label();
            txt_Number = new TextBox();
            Btn_short = new Button();
            Btn_int = new Button();
            Btn_double = new Button();
            Btn_All = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 31);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 0;
            label1.Text = "WinForm_DataType Test";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 83);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "short";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 126);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 0;
            label3.Text = "int";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 174);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 0;
            label4.Text = "double";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 218);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Exception";
            // 
            // lb_short
            // 
            lb_short.AutoSize = true;
            lb_short.Location = new Point(148, 83);
            lb_short.Name = "lb_short";
            lb_short.Size = new Size(12, 15);
            lb_short.TabIndex = 0;
            lb_short.Text = "-";
            // 
            // lb_int
            // 
            lb_int.AutoSize = true;
            lb_int.Location = new Point(148, 126);
            lb_int.Name = "lb_int";
            lb_int.Size = new Size(12, 15);
            lb_int.TabIndex = 0;
            lb_int.Text = "-";
            // 
            // lb_double
            // 
            lb_double.AutoSize = true;
            lb_double.Location = new Point(148, 174);
            lb_double.Name = "lb_double";
            lb_double.Size = new Size(12, 15);
            lb_double.TabIndex = 0;
            lb_double.Text = "-";
            // 
            // lb_Exception
            // 
            lb_Exception.AutoSize = true;
            lb_Exception.Location = new Point(148, 218);
            lb_Exception.Name = "lb_Exception";
            lb_Exception.Size = new Size(12, 15);
            lb_Exception.TabIndex = 0;
            lb_Exception.Text = "-";
            // 
            // txt_Number
            // 
            txt_Number.Location = new Point(78, 333);
            txt_Number.Name = "txt_Number";
            txt_Number.Size = new Size(379, 23);
            txt_Number.TabIndex = 1;
            // 
            // Btn_short
            // 
            Btn_short.Location = new Point(479, 75);
            Btn_short.Name = "Btn_short";
            Btn_short.Size = new Size(109, 23);
            Btn_short.TabIndex = 2;
            Btn_short.Text = "short 변환";
            Btn_short.UseVisualStyleBackColor = true;
            Btn_short.Click += Btn_short_Click;
            // 
            // Btn_int
            // 
            Btn_int.Location = new Point(479, 118);
            Btn_int.Name = "Btn_int";
            Btn_int.Size = new Size(109, 23);
            Btn_int.TabIndex = 2;
            Btn_int.Text = "int 변환";
            Btn_int.UseVisualStyleBackColor = true;
            Btn_int.Click += Btn_int_Click;
            // 
            // Btn_double
            // 
            Btn_double.Location = new Point(479, 166);
            Btn_double.Name = "Btn_double";
            Btn_double.Size = new Size(109, 23);
            Btn_double.TabIndex = 2;
            Btn_double.Text = "double 변환";
            Btn_double.UseVisualStyleBackColor = true;
            Btn_double.Click += Btn_double_Click;
            // 
            // Btn_All
            // 
            Btn_All.Location = new Point(479, 332);
            Btn_All.Name = "Btn_All";
            Btn_All.Size = new Size(109, 23);
            Btn_All.TabIndex = 2;
            Btn_All.Text = "전체변환";
            Btn_All.UseVisualStyleBackColor = true;
            Btn_All.Click += Btn_All_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_All);
            Controls.Add(Btn_double);
            Controls.Add(Btn_int);
            Controls.Add(Btn_short);
            Controls.Add(txt_Number);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lb_Exception);
            Controls.Add(lb_double);
            Controls.Add(lb_int);
            Controls.Add(lb_short);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lb_short;
        private Label lb_int;
        private Label lb_double;
        private Label lb_Exception;
        private TextBox txt_Number;
        private Button Btn_short;
        private Button Btn_int;
        private Button Btn_double;
        private Button Btn_All;
    }
}