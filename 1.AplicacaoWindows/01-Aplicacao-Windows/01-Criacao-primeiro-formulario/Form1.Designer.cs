namespace _01_Aplicacao_Windows._01_Criacao_primeiro_formulario
{
    partial class lb_teste
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
            btn_txt = new Button();
            label_teste = new Label();
            tBox_teste = new TextBox();
            SuspendLayout();
            // 
            // btn_txt
            // 
            btn_txt.BackColor = SystemColors.ActiveCaptionText;
            btn_txt.ForeColor = Color.Gray;
            btn_txt.Location = new Point(12, 54);
            btn_txt.Name = "btn_txt";
            btn_txt.Size = new Size(175, 23);
            btn_txt.TabIndex = 0;
            btn_txt.Text = "OK";
            btn_txt.UseVisualStyleBackColor = false;
            // 
            // label_teste
            // 
            label_teste.AutoSize = true;
            label_teste.BackColor = SystemColors.ActiveBorder;
            label_teste.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_teste.ForeColor = Color.Black;
            label_teste.Location = new Point(42, 91);
            label_teste.Name = "label_teste";
            label_teste.Size = new Size(102, 25);
            label_teste.TabIndex = 1;
            label_teste.Text = "Label teste";
            label_teste.Click += label1_Click;
            // 
            // tBox_teste
            // 
            tBox_teste.Location = new Point(12, 12);
            tBox_teste.Name = "tBox_teste";
            tBox_teste.Size = new Size(175, 23);
            tBox_teste.TabIndex = 2;
            // 
            // lb_teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(tBox_teste);
            Controls.Add(label_teste);
            Controls.Add(btn_txt);
            ForeColor = Color.Cornsilk;
            Name = "lb_teste";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_txt;
        private Label label_teste;
        private TextBox tBox_teste;
    }
}