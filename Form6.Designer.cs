namespace FirstFormApplication
{
    partial class Form6
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
            richTextBox1 = new RichTextBox();
            bt_For = new Button();
            bt_Foreach = new Button();
            bt_While = new Button();
            bt_DoWhile = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(42, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(409, 405);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // bt_For
            // 
            bt_For.BackColor = SystemColors.ControlDark;
            bt_For.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bt_For.ForeColor = SystemColors.ControlText;
            bt_For.Location = new Point(482, 12);
            bt_For.Name = "bt_For";
            bt_For.Size = new Size(133, 77);
            bt_For.TabIndex = 1;
            bt_For.Text = "For 문";
            bt_For.UseVisualStyleBackColor = false;
            bt_For.Click += bt_For_Click;
            // 
            // bt_Foreach
            // 
            bt_Foreach.BackColor = SystemColors.ControlDark;
            bt_Foreach.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Foreach.ForeColor = SystemColors.ControlText;
            bt_Foreach.Location = new Point(482, 114);
            bt_Foreach.Name = "bt_Foreach";
            bt_Foreach.Size = new Size(133, 81);
            bt_Foreach.TabIndex = 1;
            bt_Foreach.Text = "Foreach 문";
            bt_Foreach.UseVisualStyleBackColor = false;
            bt_Foreach.Click += bt_Foreach_Click;
            // 
            // bt_While
            // 
            bt_While.BackColor = SystemColors.ControlDark;
            bt_While.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bt_While.ForeColor = SystemColors.ControlText;
            bt_While.Location = new Point(482, 225);
            bt_While.Name = "bt_While";
            bt_While.Size = new Size(133, 82);
            bt_While.TabIndex = 1;
            bt_While.Text = "While 문";
            bt_While.UseVisualStyleBackColor = false;
            bt_While.Click += bt_While_Click;
            // 
            // bt_DoWhile
            // 
            bt_DoWhile.BackColor = SystemColors.ControlDark;
            bt_DoWhile.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bt_DoWhile.ForeColor = SystemColors.ControlText;
            bt_DoWhile.Location = new Point(482, 336);
            bt_DoWhile.Name = "bt_DoWhile";
            bt_DoWhile.Size = new Size(133, 81);
            bt_DoWhile.TabIndex = 1;
            bt_DoWhile.Text = "doWhile 문";
            bt_DoWhile.UseVisualStyleBackColor = false;
            bt_DoWhile.Click += bt_DoWhile_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(bt_DoWhile);
            Controls.Add(bt_While);
            Controls.Add(bt_Foreach);
            Controls.Add(bt_For);
            Controls.Add(richTextBox1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button bt_For;
        private Button bt_Foreach;
        private Button bt_While;
        private Button bt_DoWhile;
    }
}