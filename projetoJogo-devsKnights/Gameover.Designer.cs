namespace projetoJogo_devsKnights
{
    partial class Gameover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameover));
            TxtTitulo = new Label();
            btn_jogarNovamente = new Button();
            btn_inicio = new Button();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.BackColor = Color.Transparent;
            TxtTitulo.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.ForeColor = Color.Red;
            TxtTitulo.Location = new Point(504, 237);
            TxtTitulo.Margin = new Padding(2, 0, 2, 0);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(363, 73);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.Text = "Game Over";
            TxtTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_jogarNovamente
            // 
            btn_jogarNovamente.BackColor = Color.SeaGreen;
            btn_jogarNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_jogarNovamente.ForeColor = Color.White;
            btn_jogarNovamente.Location = new Point(504, 407);
            btn_jogarNovamente.Margin = new Padding(2, 2, 2, 2);
            btn_jogarNovamente.Name = "btn_jogarNovamente";
            btn_jogarNovamente.Size = new Size(366, 41);
            btn_jogarNovamente.TabIndex = 1;
            btn_jogarNovamente.Text = "Jogar Novamente";
            btn_jogarNovamente.UseVisualStyleBackColor = false;
            btn_jogarNovamente.Click += btn_jogarNovamente_Click;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.SeaGreen;
            btn_inicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inicio.ForeColor = Color.White;
            btn_inicio.Location = new Point(504, 345);
            btn_inicio.Margin = new Padding(2, 2, 2, 2);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(366, 41);
            btn_inicio.TabIndex = 2;
            btn_inicio.Text = "Voltar ao Inicío";
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // Gameover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1329, 614);
            Controls.Add(btn_inicio);
            Controls.Add(btn_jogarNovamente);
            Controls.Add(TxtTitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Gameover";
            Text = "Pontuacaocs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtTitulo;
        private Button btn_jogarNovamente;
        private Button btn_inicio;
    }
}