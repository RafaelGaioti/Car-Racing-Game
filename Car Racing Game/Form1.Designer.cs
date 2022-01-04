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
            this.player = new System.Windows.Forms.PictureBox();
            this.explosão = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosão)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Carro2);
            this.panel1.Controls.Add(this.Carro1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.explosão);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
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
            this.Carro2.Tag = "carRight";
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
            this.Carro1.Tag = "carLeft";
            // 
            // player
            // 
            this.player.Image = global::Car_Racing_Game.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(221, 420);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // explosão
            // 
            this.explosão.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.explosão.Location = new System.Drawing.Point(58, 352);
            this.explosão.Name = "explosão";
            this.explosão.Size = new System.Drawing.Size(64, 64);
            this.explosão.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosão.TabIndex = 2;
            this.explosão.TabStop = false;
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
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(475, 519);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            this.roadTrack2.Click += new System.EventHandler(this.RoadTrack2_Click);
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -519);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(475, 519);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosão)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Carro2;
        private System.Windows.Forms.PictureBox Carro1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox explosão;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

