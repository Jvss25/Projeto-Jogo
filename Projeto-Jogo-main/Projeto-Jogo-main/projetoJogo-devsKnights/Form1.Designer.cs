namespace projetoJogo_devsKnights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_jogar = new Button();
            lbl_titulo = new Label();
            SuspendLayout();
            // 
            // btn_jogar
            // 
            btn_jogar.BackColor = Color.SeaGreen;
            btn_jogar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_jogar.ForeColor = Color.White;
            btn_jogar.Location = new Point(480, 331);
            btn_jogar.Margin = new Padding(2, 2, 2, 2);
            btn_jogar.Name = "btn_jogar";
            btn_jogar.Size = new Size(366, 41);
            btn_jogar.TabIndex = 0;
            btn_jogar.Text = "Jogar";
            btn_jogar.UseVisualStyleBackColor = false;
            btn_jogar.Click += btn_jogar_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = Color.Honeydew;
            lbl_titulo.Location = new Point(379, 156);
            lbl_titulo.Margin = new Padding(2, 0, 2, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(570, 86);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "Capivara no Jutsu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1329, 614);
            Controls.Add(lbl_titulo);
            Controls.Add(btn_jogar);
            ForeColor = Color.Black;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_jogar;
        private Label lbl_titulo;
    }
}
