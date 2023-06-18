namespace Kunay_Ganti_Password
{
    partial class Form2
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
            PassLama = new TextBox();
            PassBaru = new TextBox();
            KonfirPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // PassLama
            // 
            PassLama.Location = new Point(252, 108);
            PassLama.Name = "PassLama";
            PassLama.Size = new Size(267, 27);
            PassLama.TabIndex = 0;
            // 
            // PassBaru
            // 
            PassBaru.Location = new Point(252, 171);
            PassBaru.Name = "PassBaru";
            PassBaru.Size = new Size(267, 27);
            PassBaru.TabIndex = 1;
            // 
            // KonfirPass
            // 
            KonfirPass.Location = new Point(252, 231);
            KonfirPass.Name = "KonfirPass";
            KonfirPass.Size = new Size(267, 27);
            KonfirPass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 85);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Password Lama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 148);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Password Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 208);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 5;
            label3.Text = "Konfirmasi Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(379, 288);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 6;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KonfirPass);
            Controls.Add(PassBaru);
            Controls.Add(PassLama);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PassLama;
        private TextBox PassBaru;
        private TextBox KonfirPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}