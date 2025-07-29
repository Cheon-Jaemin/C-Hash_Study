namespace WinForm4
{
    partial class Form9
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuColor = new ToolStripMenuItem();
            toolStripMenuFront = new ToolStripMenuItem();
            toolStripMenuBack = new ToolStripMenuItem();
            toolStripMenuFont = new ToolStripMenuItem();
            button1 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuColor, toolStripMenuFont });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // toolStripMenuColor
            // 
            toolStripMenuColor.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuFront, toolStripMenuBack });
            toolStripMenuColor.Name = "toolStripMenuColor";
            toolStripMenuColor.Size = new Size(103, 22);
            toolStripMenuColor.Text = "Color";
            // 
            // toolStripMenuFront
            // 
            toolStripMenuFront.Name = "toolStripMenuFront";
            toolStripMenuFront.Size = new Size(180, 22);
            toolStripMenuFront.Text = "Front";
            toolStripMenuFront.Click += toolStripMenuFront_Click;
            // 
            // toolStripMenuBack
            // 
            toolStripMenuBack.Name = "toolStripMenuBack";
            toolStripMenuBack.Size = new Size(180, 22);
            toolStripMenuBack.Text = "Back";
            toolStripMenuBack.Click += toolStripMenuBack_Click;
            // 
            // toolStripMenuFont
            // 
            toolStripMenuFont.Name = "toolStripMenuFont";
            toolStripMenuFont.Size = new Size(103, 22);
            toolStripMenuFont.Text = "Font";
            toolStripMenuFont.Click += toolStripMenuFont_Click;
            // 
            // button1
            // 
            button1.Font = new Font("배스킨라빈스 B", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(196, 213);
            button1.Name = "button1";
            button1.Size = new Size(259, 153);
            button1.TabIndex = 1;
            button1.Text = "버튼";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(button1);
            Name = "Form9";
            Text = "Form9";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuColor;
        private ToolStripMenuItem toolStripMenuFont;
        private Button button1;
        private ToolStripMenuItem toolStripMenuFront;
        private ToolStripMenuItem toolStripMenuBack;
    }
}