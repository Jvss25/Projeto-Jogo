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
            TxtTitulo = new Label();
            btn_jogarNovamente = new Button();
            btn_inicio = new Button();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.ForeColor = Color.Red;
            TxtTitulo.Location = new Point(720, 395);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(574, 119);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.Text = "Game Over";
            TxtTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_jogarNovamente
            // 
            btn_jogarNovamente.BackColor = Color.SeaGreen;
            btn_jogarNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_jogarNovamente.ForeColor = Color.White;
            btn_jogarNovamente.Location = new Point(720, 678);
            btn_jogarNovamente.Name = "btn_jogarNovamente";
            btn_jogarNovamente.Size = new Size(523, 68);
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
            btn_inicio.Location = new Point(720, 575);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(523, 68);
            btn_inicio.TabIndex = 2;
            btn_inicio.Text = "Voltar ao Inicío";
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // Gameover
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 1023);
            Controls.Add(btn_inicio);
            Controls.Add(btn_jogarNovamente);
            Controls.Add(TxtTitulo);
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