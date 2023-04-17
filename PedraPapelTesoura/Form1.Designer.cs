namespace PedraPapelTesoura
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
            BtPedra = new Button();
            BtPapel = new Button();
            BtTesoura = new Button();
            PicJogador = new PictureBox();
            PicAdversario = new PictureBox();
            LbDescricaoJogador1 = new Label();
            LbDescricaoJogador2 = new Label();
            lbjogador = new Label();
            LbAdversario = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PicJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicAdversario).BeginInit();
            SuspendLayout();
            // 
            // BtPedra
            // 
            BtPedra.BackColor = SystemColors.ButtonHighlight;
            BtPedra.BackgroundImage = (Image)resources.GetObject("BtPedra.BackgroundImage");
            BtPedra.BackgroundImageLayout = ImageLayout.Stretch;
            BtPedra.Location = new Point(64, 35);
            BtPedra.Name = "BtPedra";
            BtPedra.Size = new Size(150, 150);
            BtPedra.TabIndex = 0;
            BtPedra.Tag = "0";
            BtPedra.UseVisualStyleBackColor = false;
            BtPedra.Click += ClickJogada;
            // 
            // BtPapel
            // 
            BtPapel.BackColor = SystemColors.ButtonHighlight;
            BtPapel.BackgroundImage = (Image)resources.GetObject("BtPapel.BackgroundImage");
            BtPapel.BackgroundImageLayout = ImageLayout.Stretch;
            BtPapel.Location = new Point(64, 220);
            BtPapel.Name = "BtPapel";
            BtPapel.Size = new Size(150, 150);
            BtPapel.TabIndex = 1;
            BtPapel.Tag = "1";
            BtPapel.UseVisualStyleBackColor = false;
            BtPapel.Click += ClickJogada;
            // 
            // BtTesoura
            // 
            BtTesoura.BackColor = SystemColors.ButtonHighlight;
            BtTesoura.BackgroundImage = (Image)resources.GetObject("BtTesoura.BackgroundImage");
            BtTesoura.BackgroundImageLayout = ImageLayout.Stretch;
            BtTesoura.Location = new Point(64, 408);
            BtTesoura.Name = "BtTesoura";
            BtTesoura.Size = new Size(150, 150);
            BtTesoura.TabIndex = 2;
            BtTesoura.Tag = "2";
            BtTesoura.UseVisualStyleBackColor = false;
            BtTesoura.Click += ClickJogada;
            // 
            // PicJogador
            // 
            PicJogador.BorderStyle = BorderStyle.Fixed3D;
            PicJogador.Location = new Point(305, 188);
            PicJogador.Name = "PicJogador";
            PicJogador.Size = new Size(150, 150);
            PicJogador.SizeMode = PictureBoxSizeMode.StretchImage;
            PicJogador.TabIndex = 3;
            PicJogador.TabStop = false;
            // 
            // PicAdversario
            // 
            PicAdversario.BorderStyle = BorderStyle.Fixed3D;
            PicAdversario.ErrorImage = null;
            PicAdversario.Location = new Point(587, 188);
            PicAdversario.Name = "PicAdversario";
            PicAdversario.Size = new Size(150, 150);
            PicAdversario.SizeMode = PictureBoxSizeMode.StretchImage;
            PicAdversario.TabIndex = 4;
            PicAdversario.TabStop = false;
            // 
            // LbDescricaoJogador1
            // 
            LbDescricaoJogador1.AutoSize = true;
            LbDescricaoJogador1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LbDescricaoJogador1.Location = new Point(305, 152);
            LbDescricaoJogador1.Name = "LbDescricaoJogador1";
            LbDescricaoJogador1.Size = new Size(123, 37);
            LbDescricaoJogador1.TabIndex = 5;
            LbDescricaoJogador1.Text = "Jogador";
            // 
            // LbDescricaoJogador2
            // 
            LbDescricaoJogador2.AutoSize = true;
            LbDescricaoJogador2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LbDescricaoJogador2.Location = new Point(580, 152);
            LbDescricaoJogador2.Name = "LbDescricaoJogador2";
            LbDescricaoJogador2.Size = new Size(157, 37);
            LbDescricaoJogador2.TabIndex = 6;
            LbDescricaoJogador2.Text = "Adversário";
            // 
            // lbjogador
            // 
            lbjogador.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbjogador.ForeColor = Color.Red;
            lbjogador.Location = new Point(295, 408);
            lbjogador.Name = "lbjogador";
            lbjogador.Size = new Size(84, 52);
            lbjogador.TabIndex = 7;
            lbjogador.Text = "0";
            lbjogador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbAdversario
            // 
            LbAdversario.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            LbAdversario.ForeColor = Color.Red;
            LbAdversario.Location = new Point(642, 408);
            LbAdversario.Name = "LbAdversario";
            LbAdversario.Size = new Size(86, 57);
            LbAdversario.TabIndex = 8;
            LbAdversario.Text = "0";
            LbAdversario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(826, 408);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 11;
            button1.Tag = "2";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(826, 220);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 10;
            button2.Tag = "1";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(826, 35);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 9;
            button3.Tag = "0";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 415);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 12;
            label1.Text = "<-PONTUAÇÃO->";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1077, 715);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(LbAdversario);
            Controls.Add(lbjogador);
            Controls.Add(LbDescricaoJogador2);
            Controls.Add(LbDescricaoJogador1);
            Controls.Add(PicAdversario);
            Controls.Add(PicJogador);
            Controls.Add(BtTesoura);
            Controls.Add(BtPapel);
            Controls.Add(BtPedra);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedra Papel Tesoura";
            ((System.ComponentModel.ISupportInitialize)PicJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicAdversario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtPedra;
        private Button BtPapel;
        private Button BtTesoura;
        private PictureBox PicJogador;
        private PictureBox PicAdversario;
        private Label LbDescricaoJogador1;
        private Label LbDescricaoJogador2;
        private Label lbjogador;
        private Label LbAdversario;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}