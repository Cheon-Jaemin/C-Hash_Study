namespace FirstFormApplication
{
    partial class Form4
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
            text_Result = new TextBox();
            text_Num1 = new TextBox();
            text_Num2 = new TextBox();
            bt_Plus = new Button();
            bt_Minus = new Button();
            bt_Multi = new Button();
            bt_Division = new Button();
            bt_Clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "결과";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(46, 30);
            label2.TabIndex = 0;
            label2.Text = "값1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 95);
            label3.Name = "label3";
            label3.Size = new Size(46, 30);
            label3.TabIndex = 0;
            label3.Text = "값2";
            // 
            // text_Result
            // 
            text_Result.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_Result.Location = new Point(88, 40);
            text_Result.Name = "text_Result";
            text_Result.Size = new Size(318, 25);
            text_Result.TabIndex = 1;
            // 
            // text_Num1
            // 
            text_Num1.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_Num1.Location = new Point(88, 100);
            text_Num1.Name = "text_Num1";
            text_Num1.Size = new Size(126, 25);
            text_Num1.TabIndex = 1;
            // 
            // text_Num2
            // 
            text_Num2.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_Num2.Location = new Point(272, 100);
            text_Num2.Name = "text_Num2";
            text_Num2.Size = new Size(134, 25);
            text_Num2.TabIndex = 1;
            // 
            // bt_Plus
            // 
            bt_Plus.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Plus.Location = new Point(89, 141);
            bt_Plus.Name = "bt_Plus";
            bt_Plus.Size = new Size(75, 39);
            bt_Plus.TabIndex = 2;
            bt_Plus.Text = "+";
            bt_Plus.UseVisualStyleBackColor = true;
            bt_Plus.Click += bt_Plus_Click;
            // 
            // bt_Minus
            // 
            bt_Minus.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Minus.Location = new Point(170, 141);
            bt_Minus.Name = "bt_Minus";
            bt_Minus.Size = new Size(75, 39);
            bt_Minus.TabIndex = 2;
            bt_Minus.Text = "-";
            bt_Minus.UseVisualStyleBackColor = true;
            bt_Minus.Click += bt_Minus_Click;
            // 
            // bt_Multi
            // 
            bt_Multi.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Multi.Location = new Point(251, 141);
            bt_Multi.Name = "bt_Multi";
            bt_Multi.Size = new Size(75, 39);
            bt_Multi.TabIndex = 2;
            bt_Multi.Text = "*";
            bt_Multi.UseVisualStyleBackColor = true;
            bt_Multi.Click += bt_Multi_Click;
            // 
            // bt_Division
            // 
            bt_Division.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Division.Location = new Point(332, 141);
            bt_Division.Name = "bt_Division";
            bt_Division.Size = new Size(75, 39);
            bt_Division.TabIndex = 2;
            bt_Division.Text = "/";
            bt_Division.UseVisualStyleBackColor = true;
            bt_Division.Click += bt_Division_Click;
            // 
            // bt_Clear
            // 
            bt_Clear.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Clear.Location = new Point(200, 186);
            bt_Clear.Name = "bt_Clear";
            bt_Clear.Size = new Size(95, 39);
            bt_Clear.TabIndex = 2;
            bt_Clear.Text = "초기화";
            bt_Clear.UseVisualStyleBackColor = true;
            bt_Clear.Click += bt_Clear_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 250);
            Controls.Add(bt_Division);
            Controls.Add(bt_Multi);
            Controls.Add(bt_Minus);
            Controls.Add(bt_Clear);
            Controls.Add(bt_Plus);
            Controls.Add(text_Num2);
            Controls.Add(text_Num1);
            Controls.Add(text_Result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_Result;
        private TextBox text_Num1;
        private TextBox text_Num2;
        private Button bt_Plus;
        private Button bt_Minus;
        private Button bt_Multi;
        private Button bt_Division;
        private Button bt_Clear;
    }
}