namespace WinFormsApp1
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            lblstatus = new Label();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(55, 41);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 72);
            btn1.TabIndex = 0;
            btn1.TabStop = false;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(136, 41);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 72);
            btn2.TabIndex = 0;
            btn2.TabStop = false;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(217, 41);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 72);
            btn3.TabIndex = 0;
            btn3.TabStop = false;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.Control;
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(55, 119);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 72);
            btn4.TabIndex = 0;
            btn4.TabStop = false;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(136, 119);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 72);
            btn5.TabIndex = 0;
            btn5.TabStop = false;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(217, 119);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 72);
            btn6.TabIndex = 0;
            btn6.TabStop = false;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn1_Click;
            // 
            // btn7
            // 
            btn7.Cursor = Cursors.Hand;
            btn7.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(55, 197);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 72);
            btn7.TabIndex = 0;
            btn7.TabStop = false;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn1_Click;
            // 
            // btn8
            // 
            btn8.Cursor = Cursors.Hand;
            btn8.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(136, 197);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 72);
            btn8.TabIndex = 0;
            btn8.TabStop = false;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn1_Click;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(217, 197);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 72);
            btn9.TabIndex = 0;
            btn9.TabStop = false;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 328);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "status:";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Location = new Point(125, 328);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(0, 15);
            lblstatus.TabIndex = 1;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Cursor = Cursors.Hand;
            btnReiniciar.Location = new Point(78, 290);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(193, 23);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReiniciar);
            Controls.Add(lblstatus);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label lblstatus;
        private Button btnReiniciar;
    }
}
