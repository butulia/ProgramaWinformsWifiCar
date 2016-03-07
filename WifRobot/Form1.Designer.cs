namespace WifiVideo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbComandos = new System.Windows.Forms.GroupBox();
            this.gbControlCoche = new System.Windows.Forms.GroupBox();
            this.buttonLeft1 = new System.Windows.Forms.Button();
            this.btnCocheAvanzar = new System.Windows.Forms.Button();
            this.btnCocheIzquierda = new System.Windows.Forms.Button();
            this.btnCocheDerecha = new System.Windows.Forms.Button();
            this.btnCocheRetroceder = new System.Windows.Forms.Button();
            this.buttonRight2 = new System.Windows.Forms.Button();
            this.btnCocheParar = new System.Windows.Forms.Button();
            this.buttonLeft2 = new System.Windows.Forms.Button();
            this.buttonRight1 = new System.Windows.Forms.Button();
            this.gbVarios = new System.Windows.Forms.GroupBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLucesOn = new System.Windows.Forms.Button();
            this.btnLucesOff = new System.Windows.Forms.Button();
            this.gbControlCamara = new System.Windows.Forms.GroupBox();
            this.btnCamaraArriba = new System.Windows.Forms.Button();
            this.btnCamaraAbajo = new System.Windows.Forms.Button();
            this.btnCamaraIzquierda = new System.Windows.Forms.Button();
            this.btnCamaraDerecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbComandos.SuspendLayout();
            this.gbControlCoche.SuspendLayout();
            this.gbVarios.SuspendLayout();
            this.gbControlCamara.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbComandos
            // 
            this.gbComandos.Controls.Add(this.gbControlCoche);
            this.gbComandos.Controls.Add(this.gbVarios);
            this.gbComandos.Controls.Add(this.gbControlCamara);
            this.gbComandos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbComandos.Location = new System.Drawing.Point(0, 512);
            this.gbComandos.Name = "gbComandos";
            this.gbComandos.Size = new System.Drawing.Size(690, 207);
            this.gbComandos.TabIndex = 10;
            this.gbComandos.TabStop = false;
            this.gbComandos.Text = "Cuadro de comandos";
            // 
            // gbControlCoche
            // 
            this.gbControlCoche.Controls.Add(this.buttonLeft1);
            this.gbControlCoche.Controls.Add(this.btnCocheAvanzar);
            this.gbControlCoche.Controls.Add(this.btnCocheIzquierda);
            this.gbControlCoche.Controls.Add(this.btnCocheDerecha);
            this.gbControlCoche.Controls.Add(this.btnCocheRetroceder);
            this.gbControlCoche.Controls.Add(this.buttonRight2);
            this.gbControlCoche.Controls.Add(this.btnCocheParar);
            this.gbControlCoche.Controls.Add(this.buttonLeft2);
            this.gbControlCoche.Controls.Add(this.buttonRight1);
            this.gbControlCoche.Location = new System.Drawing.Point(12, 19);
            this.gbControlCoche.Name = "gbControlCoche";
            this.gbControlCoche.Size = new System.Drawing.Size(216, 176);
            this.gbControlCoche.TabIndex = 29;
            this.gbControlCoche.TabStop = false;
            this.gbControlCoche.Text = "Control Coche";
            // 
            // buttonLeft1
            // 
            this.buttonLeft1.Location = new System.Drawing.Point(6, 19);
            this.buttonLeft1.Name = "buttonLeft1";
            this.buttonLeft1.Size = new System.Drawing.Size(64, 46);
            this.buttonLeft1.TabIndex = 19;
            this.buttonLeft1.Text = "左\r\n(Q)";
            this.buttonLeft1.UseVisualStyleBackColor = true;
            this.buttonLeft1.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnCocheAvanzar
            // 
            this.btnCocheAvanzar.Location = new System.Drawing.Point(76, 19);
            this.btnCocheAvanzar.Name = "btnCocheAvanzar";
            this.btnCocheAvanzar.Size = new System.Drawing.Size(63, 46);
            this.btnCocheAvanzar.TabIndex = 11;
            this.btnCocheAvanzar.Text = "Avanzar \r\n（W）";
            this.btnCocheAvanzar.UseVisualStyleBackColor = true;
            // 
            // btnCocheIzquierda
            // 
            this.btnCocheIzquierda.Location = new System.Drawing.Point(6, 71);
            this.btnCocheIzquierda.Name = "btnCocheIzquierda";
            this.btnCocheIzquierda.Size = new System.Drawing.Size(64, 46);
            this.btnCocheIzquierda.TabIndex = 12;
            this.btnCocheIzquierda.Text = "Izquierda \r\n(A)";
            this.btnCocheIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnCocheDerecha
            // 
            this.btnCocheDerecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCocheDerecha.Location = new System.Drawing.Point(145, 71);
            this.btnCocheDerecha.Name = "btnCocheDerecha";
            this.btnCocheDerecha.Size = new System.Drawing.Size(64, 46);
            this.btnCocheDerecha.TabIndex = 13;
            this.btnCocheDerecha.Text = "Derecha \r\n(D)";
            this.btnCocheDerecha.UseVisualStyleBackColor = true;
            // 
            // btnCocheRetroceder
            // 
            this.btnCocheRetroceder.Location = new System.Drawing.Point(76, 123);
            this.btnCocheRetroceder.Name = "btnCocheRetroceder";
            this.btnCocheRetroceder.Size = new System.Drawing.Size(63, 46);
            this.btnCocheRetroceder.TabIndex = 14;
            this.btnCocheRetroceder.Text = "Atras \r\n(S)";
            this.btnCocheRetroceder.UseVisualStyleBackColor = true;
            // 
            // buttonRight2
            // 
            this.buttonRight2.Location = new System.Drawing.Point(145, 123);
            this.buttonRight2.Name = "buttonRight2";
            this.buttonRight2.Size = new System.Drawing.Size(64, 46);
            this.buttonRight2.TabIndex = 22;
            this.buttonRight2.Text = "右\r\n(C)";
            this.buttonRight2.UseVisualStyleBackColor = true;
            this.buttonRight2.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnCocheParar
            // 
            this.btnCocheParar.Location = new System.Drawing.Point(76, 73);
            this.btnCocheParar.Name = "btnCocheParar";
            this.btnCocheParar.Size = new System.Drawing.Size(63, 46);
            this.btnCocheParar.TabIndex = 16;
            this.btnCocheParar.Text = "Parar";
            this.btnCocheParar.UseVisualStyleBackColor = true;
            // 
            // buttonLeft2
            // 
            this.buttonLeft2.Location = new System.Drawing.Point(6, 123);
            this.buttonLeft2.Name = "buttonLeft2";
            this.buttonLeft2.Size = new System.Drawing.Size(64, 46);
            this.buttonLeft2.TabIndex = 21;
            this.buttonLeft2.Text = "左\r\n(Z)";
            this.buttonLeft2.UseVisualStyleBackColor = true;
            this.buttonLeft2.Click += new System.EventHandler(this.button12_Click);
            // 
            // buttonRight1
            // 
            this.buttonRight1.Location = new System.Drawing.Point(145, 19);
            this.buttonRight1.Name = "buttonRight1";
            this.buttonRight1.Size = new System.Drawing.Size(64, 46);
            this.buttonRight1.TabIndex = 20;
            this.buttonRight1.Text = "右\r\n(E)";
            this.buttonRight1.UseVisualStyleBackColor = true;
            this.buttonRight1.Click += new System.EventHandler(this.button11_Click);
            // 
            // gbVarios
            // 
            this.gbVarios.Controls.Add(this.btnVideo);
            this.gbVarios.Controls.Add(this.button6);
            this.gbVarios.Controls.Add(this.btnLucesOn);
            this.gbVarios.Controls.Add(this.btnLucesOff);
            this.gbVarios.Location = new System.Drawing.Point(234, 19);
            this.gbVarios.Name = "gbVarios";
            this.gbVarios.Size = new System.Drawing.Size(216, 176);
            this.gbVarios.TabIndex = 28;
            this.gbVarios.TabStop = false;
            this.gbVarios.Text = "Controles Varios";
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(6, 19);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(81, 30);
            this.btnVideo.TabIndex = 10;
            this.btnVideo.Text = "Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 30);
            this.button6.TabIndex = 15;
            this.button6.Text = "Configuración";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnLucesOn
            // 
            this.btnLucesOn.Location = new System.Drawing.Point(129, 19);
            this.btnLucesOn.Name = "btnLucesOn";
            this.btnLucesOn.Size = new System.Drawing.Size(81, 30);
            this.btnLucesOn.TabIndex = 25;
            this.btnLucesOn.Text = "Luces ON";
            this.btnLucesOn.UseVisualStyleBackColor = true;
            this.btnLucesOn.Click += new System.EventHandler(this.ledon_Click);
            // 
            // btnLucesOff
            // 
            this.btnLucesOff.Location = new System.Drawing.Point(129, 68);
            this.btnLucesOff.Name = "btnLucesOff";
            this.btnLucesOff.Size = new System.Drawing.Size(81, 30);
            this.btnLucesOff.TabIndex = 26;
            this.btnLucesOff.Text = "Luces OFF";
            this.btnLucesOff.UseVisualStyleBackColor = true;
            this.btnLucesOff.Click += new System.EventHandler(this.ledoff_Click);
            // 
            // gbControlCamara
            // 
            this.gbControlCamara.Controls.Add(this.btnCamaraArriba);
            this.gbControlCamara.Controls.Add(this.btnCamaraAbajo);
            this.gbControlCamara.Controls.Add(this.btnCamaraIzquierda);
            this.gbControlCamara.Controls.Add(this.btnCamaraDerecha);
            this.gbControlCamara.Location = new System.Drawing.Point(456, 19);
            this.gbControlCamara.Name = "gbControlCamara";
            this.gbControlCamara.Size = new System.Drawing.Size(220, 176);
            this.gbControlCamara.TabIndex = 27;
            this.gbControlCamara.TabStop = false;
            this.gbControlCamara.Text = "Control Cámara";
            // 
            // btnCamaraArriba
            // 
            this.btnCamaraArriba.Location = new System.Drawing.Point(78, 21);
            this.btnCamaraArriba.Name = "btnCamaraArriba";
            this.btnCamaraArriba.Size = new System.Drawing.Size(63, 46);
            this.btnCamaraArriba.TabIndex = 17;
            this.btnCamaraArriba.Text = "Arriba (I)";
            this.btnCamaraArriba.UseVisualStyleBackColor = true;
            this.btnCamaraArriba.Click += new System.EventHandler(this.btnEngineUp_Click);
            // 
            // btnCamaraAbajo
            // 
            this.btnCamaraAbajo.Location = new System.Drawing.Point(78, 73);
            this.btnCamaraAbajo.Name = "btnCamaraAbajo";
            this.btnCamaraAbajo.Size = new System.Drawing.Size(63, 46);
            this.btnCamaraAbajo.TabIndex = 18;
            this.btnCamaraAbajo.Text = "Abajo (K)";
            this.btnCamaraAbajo.UseVisualStyleBackColor = true;
            this.btnCamaraAbajo.Click += new System.EventHandler(this.btnEngineDown_Click);
            // 
            // btnCamaraIzquierda
            // 
            this.btnCamaraIzquierda.Location = new System.Drawing.Point(9, 73);
            this.btnCamaraIzquierda.Name = "btnCamaraIzquierda";
            this.btnCamaraIzquierda.Size = new System.Drawing.Size(63, 46);
            this.btnCamaraIzquierda.TabIndex = 23;
            this.btnCamaraIzquierda.Text = "Izquierda (J)";
            this.btnCamaraIzquierda.UseVisualStyleBackColor = true;
            this.btnCamaraIzquierda.Click += new System.EventHandler(this.btnEngineleft_Click);
            // 
            // btnCamaraDerecha
            // 
            this.btnCamaraDerecha.Location = new System.Drawing.Point(147, 73);
            this.btnCamaraDerecha.Name = "btnCamaraDerecha";
            this.btnCamaraDerecha.Size = new System.Drawing.Size(63, 46);
            this.btnCamaraDerecha.TabIndex = 24;
            this.btnCamaraDerecha.Text = "Derecha (L)";
            this.btnCamaraDerecha.UseVisualStyleBackColor = true;
            this.btnCamaraDerecha.Click += new System.EventHandler(this.btnEngineright_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 719);
            this.Controls.Add(this.gbComandos);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coche WIFI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbComandos.ResumeLayout(false);
            this.gbControlCoche.ResumeLayout(false);
            this.gbVarios.ResumeLayout(false);
            this.gbControlCamara.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbComandos;
        private System.Windows.Forms.Button btnCamaraAbajo;
        private System.Windows.Forms.Button btnCamaraArriba;
        private System.Windows.Forms.Button btnCocheParar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnCocheRetroceder;
        private System.Windows.Forms.Button btnCocheDerecha;
        private System.Windows.Forms.Button btnCocheIzquierda;
        private System.Windows.Forms.Button btnCocheAvanzar;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button buttonRight1;
        private System.Windows.Forms.Button buttonLeft1;
        private System.Windows.Forms.Button btnLucesOff;
        private System.Windows.Forms.Button btnLucesOn;
        private System.Windows.Forms.Button btnCamaraDerecha;
        private System.Windows.Forms.Button btnCamaraIzquierda;
        private System.Windows.Forms.Button buttonRight2;
        private System.Windows.Forms.Button buttonLeft2;
        private System.Windows.Forms.GroupBox gbControlCamara;
        private System.Windows.Forms.GroupBox gbControlCoche;
        private System.Windows.Forms.GroupBox gbVarios;
    }
}

