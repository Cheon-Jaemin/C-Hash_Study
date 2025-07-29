namespace WinForm3
{
    partial class Form10
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
            TreeNode treeNode1 = new TreeNode("IT도서");
            treeView1 = new TreeView();
            tbNode = new TextBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnExpand = new Button();
            btnCollapse = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(24, 30);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Root";
            treeNode1.Text = "IT도서";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeView1.Size = new Size(298, 388);
            treeView1.TabIndex = 0;
            // 
            // tbNode
            // 
            tbNode.Location = new Point(356, 30);
            tbNode.Multiline = true;
            tbNode.Name = "tbNode";
            tbNode.Size = new Size(278, 48);
            tbNode.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.Location = new Point(356, 93);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(278, 51);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ControlLight;
            btnDel.Location = new Point(356, 182);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(278, 51);
            btnDel.TabIndex = 2;
            btnDel.Text = "삭제";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnExpand
            // 
            btnExpand.BackColor = SystemColors.ControlLight;
            btnExpand.Location = new Point(356, 278);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(278, 51);
            btnExpand.TabIndex = 2;
            btnExpand.Text = "확장";
            btnExpand.UseVisualStyleBackColor = false;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.BackColor = SystemColors.ControlLight;
            btnCollapse.Location = new Point(356, 367);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(278, 51);
            btnCollapse.TabIndex = 2;
            btnCollapse.Text = "축소";
            btnCollapse.UseVisualStyleBackColor = false;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(btnCollapse);
            Controls.Add(btnExpand);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(tbNode);
            Controls.Add(treeView1);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private TextBox tbNode;
        private Button btnAdd;
        private Button btnDel;
        private Button btnExpand;
        private Button btnCollapse;
    }
}