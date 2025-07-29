namespace WinForm2
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
            label4 = new Label();
            label5 = new Label();
            lb_Contains = new Label();
            lb_Equals = new Label();
            lb_Length = new Label();
            lb_ToLower = new Label();
            lb_ToUpper = new Label();
            TextBox = new TextBox();
            bt_Contains = new Button();
            bt_Init = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 47);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Contain";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 92);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Equals";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 134);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Length";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 181);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "ToLower";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 228);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 0;
            label5.Text = "ToUpper";
            // 
            // lb_Contains
            // 
            lb_Contains.AutoSize = true;
            lb_Contains.Location = new Point(110, 47);
            lb_Contains.Name = "lb_Contains";
            lb_Contains.Size = new Size(12, 15);
            lb_Contains.TabIndex = 0;
            lb_Contains.Text = "-";
            // 
            // lb_Equals
            // 
            lb_Equals.AutoSize = true;
            lb_Equals.Location = new Point(110, 92);
            lb_Equals.Name = "lb_Equals";
            lb_Equals.Size = new Size(12, 15);
            lb_Equals.TabIndex = 0;
            lb_Equals.Text = "-";
            // 
            // lb_Length
            // 
            lb_Length.AutoSize = true;
            lb_Length.Location = new Point(110, 134);
            lb_Length.Name = "lb_Length";
            lb_Length.Size = new Size(12, 15);
            lb_Length.TabIndex = 0;
            lb_Length.Text = "-";
            // 
            // lb_ToLower
            // 
            lb_ToLower.AutoSize = true;
            lb_ToLower.Location = new Point(110, 181);
            lb_ToLower.Name = "lb_ToLower";
            lb_ToLower.Size = new Size(12, 15);
            lb_ToLower.TabIndex = 0;
            lb_ToLower.Text = "-";
            // 
            // lb_ToUpper
            // 
            lb_ToUpper.AutoSize = true;
            lb_ToUpper.Location = new Point(110, 228);
            lb_ToUpper.Name = "lb_ToUpper";
            lb_ToUpper.Size = new Size(12, 15);
            lb_ToUpper.TabIndex = 0;
            lb_ToUpper.Text = "-";
            // 
            // TextBox
            // 
            TextBox.Location = new Point(55, 282);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(576, 82);
            TextBox.TabIndex = 1;
            // 
            // bt_Contains
            // 
            bt_Contains.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Contains.ForeColor = SystemColors.MenuHighlight;
            bt_Contains.Location = new Point(510, 47);
            bt_Contains.Name = "bt_Contains";
            bt_Contains.Size = new Size(121, 42);
            bt_Contains.TabIndex = 2;
            bt_Contains.Text = "Transform";
            bt_Contains.UseVisualStyleBackColor = true;
            bt_Contains.Click += bt_Contains_Click;
            // 
            // bt_Init
            // 
            bt_Init.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Init.ForeColor = SystemColors.MenuHighlight;
            bt_Init.Location = new Point(510, 107);
            bt_Init.Name = "bt_Init";
            bt_Init.Size = new Size(121, 42);
            bt_Init.TabIndex = 2;
            bt_Init.Text = "초기화";
            bt_Init.UseVisualStyleBackColor = true;
            bt_Init.Click += bt_Init_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(bt_Init);
            Controls.Add(bt_Contains);
            Controls.Add(TextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb_ToUpper);
            Controls.Add(lb_ToLower);
            Controls.Add(lb_Length);
            Controls.Add(lb_Equals);
            Controls.Add(lb_Contains);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lb_Contains;
        private Label lb_Equals;
        private Label lb_Length;
        private Label lb_ToLower;
        private Label lb_ToUpper;
        private TextBox TextBox;
        private Button bt_Contains;
        private Button bt_Init;
    }
}
