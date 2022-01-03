namespace Car_Racing_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Carro2 = new System.Windows.Forms.PictureBox();
            this.Carro1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Explosão = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.RoadTrack2 = new System.Windows.Forms.PictureBox();
            this.RoadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosão)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Carro2);
            this.panel1.Controls.Add(this.Carro1);
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.Explosão);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.RoadTrack2);
            this.panel1.Controls.Add(this.RoadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 519);
            this.panel1.TabIndex = 0;
            // 
            // Carro2
            // 
            this.Carro2.Image = global::Car_Racing_Game.Properties.Resources.carGrey;
            this.Carro2.Location = new System.Drawing.Point(360, 56);
            this.Carro2.Name = "Carro2";
            this.Carro2.Size = new System.Drawing.Size(50, 100);
            this.Carro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Carro2.TabIndex = 2;
            this.Carro2.TabStop = false;
            // 
            // Carro1
            // 
            this.Carro1.Image = global::Car_Racing_Game.Properties.Resources.carGreen;
            this.Carro1.Location = new System.Drawing.Point(58, 90);
            this.Carro1.Name = "Carro1";
            this.Carro1.Size = new System.Drawing.Size(50, 101);
            this.Carro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Carro1.TabIndex = 2;
            this.Carro1.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::Car_Racing_Game.Properties.Resources.carYellow;
            this.Player.Location = new System.Drawing.Point(221, 420);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // Explosão
            // 
            this.Explosão.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.Explosão.Location = new System.Drawing.Point(58, 352);
            this.Explosão.Name = "Explosão";
            this.Explosão.Size = new System.Drawing.Size(64, 64);
            this.Explosão.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Explosão.TabIndex = 2;
            this.Explosão.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::Car_Racing_Game.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(114, 210);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 2;
            this.award.TabStop = false;
            // 
            // RoadTrack2
            // 
            this.RoadTrack2.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.RoadTrack2.Location = new System.Drawing.Point(0, 0);
            this.RoadTrack2.Name = "RoadTrack2";
            this.RoadTrack2.Size = new System.Drawing.Size(475, 519);
            this.RoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack2.TabIndex = 1;
            this.RoadTrack2.TabStop = false;
            this.RoadTrack2.Click += new System.EventHandler(this.RoadTrack2_Click);
            // 
            // RoadTrack1
            // 
            this.RoadTrack1.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.RoadTrack1.Location = new System.Drawing.Point(0, -519);
            this.RoadTrack1.Name = "RoadTrack1";
            this.RoadTrack1.Size = new System.Drawing.Size(475, 519);
            this.RoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack1.TabIndex = 0;
            this.RoadTrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(195, 570);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Jogar";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pontuação: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 140);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pressione  <- ou -> para mover o carro.\r\n\r\nNão bata em nenhum outro carro e sobre" +
    "viva o máximo que puder.\r\n\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosão)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Carro2;
        private System.Windows.Forms.PictureBox Carro1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Explosão;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox RoadTrack2;
        private System.Windows.Forms.PictureBox RoadTrack1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

