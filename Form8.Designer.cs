namespace WinForm3
{
    partial class Form8
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
            listView1 = new ListView();
            chName = new ColumnHeader();
            chPhone = new ColumnHeader();
            chOrg = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbOrg = new TextBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnChange = new Button();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { chName, chPhone, chOrg });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(27, 175);
            listView1.Name = "listView1";
            listView1.Size = new Size(544, 191);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chName
            // 
            chName.Text = "이름";
            chName.Width = 150;
            // 
            // chPhone
            // 
            chPhone.Text = "휴대폰";
            chPhone.Width = 200;
            // 
            // chOrg
            // 
            chOrg.Text = "소속";
            chOrg.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "이름 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "휴대폰 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 113);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "소속 : ";
            // 
            // tbName
            // 
            tbName.Location = new Point(99, 21);
            tbName.Name = "tbName";
            tbName.Size = new Size(359, 23);
            tbName.TabIndex = 0;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(99, 64);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(359, 23);
            tbPhone.TabIndex = 1;
            // 
            // tbOrg
            // 
            tbOrg.Location = new Point(99, 108);
            tbOrg.Name = "tbOrg";
            tbOrg.Size = new Size(359, 23);
            tbOrg.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(493, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 22);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "입력";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(493, 51);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(78, 22);
            btnDel.TabIndex = 4;
            btnDel.Text = "삭제";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(493, 79);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(78, 22);
            btnChange.TabIndex = 5;
            btnChange.Text = "수정";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(493, 107);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(78, 22);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "삽입";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 378);
            Controls.Add(btnInsert);
            Controls.Add(btnChange);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(tbOrg);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbOrg;
        private Button btnAdd;
        private Button btnDel;
        private Button btnChange;
        private Button btnInsert;
        private ColumnHeader chName;
        private ColumnHeader chPhone;
        private ColumnHeader chOrg;
    }
}