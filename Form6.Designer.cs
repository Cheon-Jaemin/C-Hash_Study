namespace WinForm3
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
            btnAdd = new Button();
            btnDel = new Button();
            domainUpDown1 = new DomainUpDown();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lb_Price1 = new Label();
            label4 = new Label();
            lb_Price2 = new Label();
            label6 = new Label();
            lb_Price3 = new Label();
            label8 = new Label();
            lb_Price4 = new Label();
            label10 = new Label();
            lb_Price5 = new Label();
            label12 = new Label();
            lb_Price6 = new Label();
            label14 = new Label();
            lb_Price7 = new Label();
            btnResult = new Button();
            label16 = new Label();
            lb_Price8 = new Label();
            label18 = new Label();
            lb_Price9 = new Label();
            label3 = new Label();
            lb_result_price = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("핑크퐁 아기상어 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(54, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 70);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "메뉴추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("핑크퐁 아기상어 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnDel.Location = new Point(54, 146);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(122, 70);
            btnDel.TabIndex = 0;
            btnDel.Text = "메뉴삭제";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            domainUpDown1.Items.Add("짜장면");
            domainUpDown1.Items.Add("짬뽕");
            domainUpDown1.Items.Add("간짜장");
            domainUpDown1.Items.Add("쟁반짜장");
            domainUpDown1.Items.Add("해물짬뽕");
            domainUpDown1.Items.Add("꿔바로우");
            domainUpDown1.Items.Add("탕수육");
            domainUpDown1.Items.Add("깐쇼새우");
            domainUpDown1.Items.Add("깐풍기");
            domainUpDown1.Location = new Point(259, 44);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 1;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(423, 44);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("핑크퐁 아기상어 Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(767, 15);
            label1.Name = "label1";
            label1.Size = new Size(63, 33);
            label1.TabIndex = 3;
            label1.Text = "메뉴판";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(748, 53);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 4;
            label2.Text = "짜장면";
            // 
            // lb_Price1
            // 
            lb_Price1.AutoSize = true;
            lb_Price1.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price1.Location = new Point(809, 53);
            lb_Price1.Name = "lb_Price1";
            lb_Price1.Size = new Size(41, 23);
            lb_Price1.TabIndex = 4;
            lb_Price1.Text = "7000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(748, 77);
            label4.Name = "label4";
            label4.Size = new Size(33, 23);
            label4.TabIndex = 4;
            label4.Text = "짬뽕";
            // 
            // lb_Price2
            // 
            lb_Price2.AutoSize = true;
            lb_Price2.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price2.Location = new Point(809, 77);
            lb_Price2.Name = "lb_Price2";
            lb_Price2.Size = new Size(42, 23);
            lb_Price2.TabIndex = 4;
            lb_Price2.Text = "9000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(748, 103);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 4;
            label6.Text = "간짜장";
            // 
            // lb_Price3
            // 
            lb_Price3.AutoSize = true;
            lb_Price3.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price3.Location = new Point(809, 103);
            lb_Price3.Name = "lb_Price3";
            lb_Price3.Size = new Size(42, 23);
            lb_Price3.TabIndex = 4;
            lb_Price3.Text = "9000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(748, 130);
            label8.Name = "label8";
            label8.Size = new Size(59, 23);
            label8.TabIndex = 4;
            label8.Text = "쟁반짜장";
            // 
            // lb_Price4
            // 
            lb_Price4.AutoSize = true;
            lb_Price4.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price4.Location = new Point(809, 130);
            lb_Price4.Name = "lb_Price4";
            lb_Price4.Size = new Size(48, 23);
            lb_Price4.TabIndex = 4;
            lb_Price4.Text = "11000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(748, 157);
            label10.Name = "label10";
            label10.Size = new Size(55, 23);
            label10.TabIndex = 4;
            label10.Text = "해물짬뽕";
            // 
            // lb_Price5
            // 
            lb_Price5.AutoSize = true;
            lb_Price5.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price5.Location = new Point(809, 157);
            lb_Price5.Name = "lb_Price5";
            lb_Price5.Size = new Size(49, 23);
            lb_Price5.TabIndex = 4;
            lb_Price5.Text = "10000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(748, 182);
            label12.Name = "label12";
            label12.Size = new Size(54, 23);
            label12.TabIndex = 4;
            label12.Text = "꿔바로우";
            // 
            // lb_Price6
            // 
            lb_Price6.AutoSize = true;
            lb_Price6.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price6.Location = new Point(809, 182);
            lb_Price6.Name = "lb_Price6";
            lb_Price6.Size = new Size(49, 23);
            lb_Price6.TabIndex = 4;
            lb_Price6.Text = "15000";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(748, 208);
            label14.Name = "label14";
            label14.Size = new Size(42, 23);
            label14.TabIndex = 4;
            label14.Text = "탕수육";
            // 
            // lb_Price7
            // 
            lb_Price7.AutoSize = true;
            lb_Price7.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price7.Location = new Point(809, 208);
            lb_Price7.Name = "lb_Price7";
            lb_Price7.Size = new Size(48, 23);
            lb_Price7.TabIndex = 4;
            lb_Price7.Text = "17000";
            // 
            // btnResult
            // 
            btnResult.Font = new Font("핑크퐁 아기상어 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnResult.Location = new Point(54, 246);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(122, 70);
            btnResult.TabIndex = 0;
            btnResult.Text = "주문하기";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(748, 233);
            label16.Name = "label16";
            label16.Size = new Size(55, 23);
            label16.TabIndex = 4;
            label16.Text = "깐쇼새우";
            // 
            // lb_Price8
            // 
            lb_Price8.AutoSize = true;
            lb_Price8.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price8.Location = new Point(809, 233);
            lb_Price8.Name = "lb_Price8";
            lb_Price8.Size = new Size(50, 23);
            lb_Price8.TabIndex = 4;
            lb_Price8.Text = "20000";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(748, 258);
            label18.Name = "label18";
            label18.Size = new Size(44, 23);
            label18.TabIndex = 4;
            label18.Text = "깐풍기";
            // 
            // lb_Price9
            // 
            lb_Price9.AutoSize = true;
            lb_Price9.Font = new Font("핑크퐁 아기상어 Regular", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Price9.Location = new Point(809, 258);
            lb_Price9.Name = "lb_Price9";
            lb_Price9.Size = new Size(50, 23);
            lb_Price9.TabIndex = 4;
            lb_Price9.Text = "22000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("핑크퐁 아기상어 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(562, 41);
            label3.Name = "label3";
            label3.Size = new Size(70, 26);
            label3.TabIndex = 4;
            label3.Text = "총 주문금액";
            // 
            // lb_result_price
            // 
            lb_result_price.AutoSize = true;
            lb_result_price.Font = new Font("핑크퐁 아기상어 Regular", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lb_result_price.Location = new Point(639, 41);
            lb_result_price.Name = "lb_result_price";
            lb_result_price.Size = new Size(19, 26);
            lb_result_price.TabIndex = 4;
            lb_result_price.Text = "-";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(882, 361);
            Controls.Add(lb_Price9);
            Controls.Add(lb_Price8);
            Controls.Add(lb_Price7);
            Controls.Add(lb_Price6);
            Controls.Add(lb_Price5);
            Controls.Add(lb_Price4);
            Controls.Add(lb_Price3);
            Controls.Add(lb_Price2);
            Controls.Add(lb_result_price);
            Controls.Add(lb_Price1);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(domainUpDown1);
            Controls.Add(btnResult);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDel;
        private DomainUpDown domainUpDown1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label lb_Price1;
        private Label label4;
        private Label lb_Price2;
        private Label label6;
        private Label lb_Price3;
        private Label label8;
        private Label lb_Price4;
        private Label label10;
        private Label lb_Price5;
        private Label label12;
        private Label lb_Price6;
        private Label label14;
        private Label lb_Price7;
        private Button btnResult;
        private Label label16;
        private Label lb_Price8;
        private Label label18;
        private Label lb_Price9;
        private Label label3;
        private Label lb_result_price;
    }
}