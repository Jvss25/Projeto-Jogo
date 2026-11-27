namespace projetoJogo_devsKnights
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            timer1 = new System.Windows.Forms.Timer(components);
            TxtVida = new Label();
            TxtPoints = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // TxtVida
            // 
            TxtVida.AutoSize = true;
            TxtVida.BackColor = Color.Transparent;
            TxtVida.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtVida.Location = new Point(175, 19);
            TxtVida.Name = "TxtVida";
            TxtVida.Size = new Size(33, 35);
            TxtVida.TabIndex = 1;
            TxtVida.Text = "0";
            // 
            // TxtPoints
            // 
            TxtPoints.AutoSize = true;
            TxtPoints.BackColor = Color.Transparent;
            TxtPoints.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPoints.Location = new Point(175, 84);
            TxtPoints.Name = "TxtPoints";
            TxtPoints.Size = new Size(33, 35);
            TxtPoints.TabIndex = 2;
            TxtPoints.Text = "0";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1899, 1023);
            Controls.Add(TxtPoints);
            Controls.Add(TxtVida);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label TxtVida;
        private Label TxtPoints;
    }
}