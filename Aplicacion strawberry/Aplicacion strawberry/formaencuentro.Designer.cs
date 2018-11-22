namespace Aplicacion_strawberry
{
    partial class formaencuentro
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.desp1 = new System.Windows.Forms.Button();
            this.ant1 = new System.Windows.Forms.Button();
            this.lblcantidadnueva = new System.Windows.Forms.Label();
            this.lblmonedas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmon = new System.Windows.Forms.Label();
            this.lblelo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbljuego = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cbahorro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.lblahorrores = new System.Windows.Forms.Label();
            this.lblmonedasres = new System.Windows.Forms.Label();
            this.lblelores = new System.Windows.Forms.Label();
            this.lblnumerores = new System.Windows.Forms.Label();
            this.lbljuegores = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conforme el proyecto avance \r\nhabra mas juegos, mantente \r\natento";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 79);
            this.button4.TabIndex = 3;
            this.button4.Text = "Barcos en batalla";
            this.toolTip1.SetToolTip(this.button4, "Hunde los 5 barcos enemigos por turnos,\r\ntu no sabes donde estan los de tu oponen" +
                    "te");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ajedrez";
            this.toolTip1.SetToolTip(this.button3, "Clasico juego donde debes acabar \r\ncon el enemigo o su rey para ganar");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lineal letal";
            this.toolTip1.SetToolTip(this.button2, "Haz que el opontente choque con tu linea");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Un Toque";
            this.toolTip1.SetToolTip(this.button1, "Trata de hacer la mayor cantidad de clicks para ganar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(25, 42);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(244, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.trackBar1, "Debe ser entre 10% y 50 %");
            this.trackBar1.Value = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(8, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 205);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.desp1);
            this.panel2.Controls.Add(this.ant1);
            this.panel2.Controls.Add(this.lblcantidadnueva);
            this.panel2.Controls.Add(this.lblmonedas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbmoneda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblmon);
            this.panel2.Controls.Add(this.lblelo);
            this.panel2.Controls.Add(this.lblusuario);
            this.panel2.Controls.Add(this.lbljuego);
            this.panel2.Location = new System.Drawing.Point(5, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 225);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.VisibleChanged += new System.EventHandler(this.panel2_VisibleChanged);
            // 
            // desp1
            // 
            this.desp1.Enabled = false;
            this.desp1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desp1.Location = new System.Drawing.Point(285, 186);
            this.desp1.Name = "desp1";
            this.desp1.Size = new System.Drawing.Size(102, 30);
            this.desp1.TabIndex = 10;
            this.desp1.Text = "Siguiente";
            this.desp1.UseVisualStyleBackColor = true;
            this.desp1.Click += new System.EventHandler(this.desp1_Click);
            // 
            // ant1
            // 
            this.ant1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant1.Location = new System.Drawing.Point(51, 186);
            this.ant1.Name = "ant1";
            this.ant1.Size = new System.Drawing.Size(85, 30);
            this.ant1.TabIndex = 9;
            this.ant1.Text = "Anterior";
            this.ant1.UseVisualStyleBackColor = true;
            this.ant1.Click += new System.EventHandler(this.ant1_Click);
            // 
            // lblcantidadnueva
            // 
            this.lblcantidadnueva.AutoSize = true;
            this.lblcantidadnueva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadnueva.Location = new System.Drawing.Point(387, 133);
            this.lblcantidadnueva.Name = "lblcantidadnueva";
            this.lblcantidadnueva.Size = new System.Drawing.Size(16, 17);
            this.lblcantidadnueva.TabIndex = 8;
            this.lblcantidadnueva.Text = "0";
            // 
            // lblmonedas
            // 
            this.lblmonedas.AutoSize = true;
            this.lblmonedas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonedas.Location = new System.Drawing.Point(80, 74);
            this.lblmonedas.Name = "lblmonedas";
            this.lblmonedas.Size = new System.Drawing.Size(46, 17);
            this.lblmonedas.TabIndex = 7;
            this.lblmonedas.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monedas despues de la cuota:";
            // 
            // cbmoneda
            // 
            this.cbmoneda.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmoneda.FormattingEnabled = true;
            this.cbmoneda.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100",
            "200"});
            this.cbmoneda.Location = new System.Drawing.Point(15, 134);
            this.cbmoneda.Name = "cbmoneda";
            this.cbmoneda.Size = new System.Drawing.Size(121, 25);
            this.cbmoneda.TabIndex = 5;
            this.cbmoneda.SelectedIndexChanged += new System.EventHandler(this.cbmoneda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione una cuota:";
            // 
            // lblmon
            // 
            this.lblmon.AutoSize = true;
            this.lblmon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmon.Location = new System.Drawing.Point(12, 74);
            this.lblmon.Name = "lblmon";
            this.lblmon.Size = new System.Drawing.Size(67, 17);
            this.lblmon.TabIndex = 3;
            this.lblmon.Text = "Monedas";
            // 
            // lblelo
            // 
            this.lblelo.AutoSize = true;
            this.lblelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelo.Location = new System.Drawing.Point(312, 55);
            this.lblelo.Name = "lblelo";
            this.lblelo.Size = new System.Drawing.Size(38, 17);
            this.lblelo.TabIndex = 2;
            this.lblelo.Text = "ELO";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(312, 19);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(58, 17);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario";
            // 
            // lbljuego
            // 
            this.lbljuego.AutoSize = true;
            this.lbljuego.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljuego.Location = new System.Drawing.Point(12, 22);
            this.lbljuego.Name = "lbljuego";
            this.lbljuego.Size = new System.Drawing.Size(63, 22);
            this.lbljuego.TabIndex = 0;
            this.lbljuego.Text = "Juego";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.cbahorro);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Location = new System.Drawing.Point(5, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 224);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(328, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "siguiente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(25, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "atras";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbahorro
            // 
            this.cbahorro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbahorro.FormattingEnabled = true;
            this.cbahorro.Location = new System.Drawing.Point(21, 125);
            this.cbahorro.Name = "cbahorro";
            this.cbahorro.Size = new System.Drawing.Size(188, 28);
            this.cbahorro.TabIndex = 3;
            this.cbahorro.SelectedIndexChanged += new System.EventHandler(this.cbahorro_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ahorros disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Seleccione cuanto quiere donar";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.lblahorrores);
            this.panel4.Controls.Add(this.lblmonedasres);
            this.panel4.Controls.Add(this.lblelores);
            this.panel4.Controls.Add(this.lblnumerores);
            this.panel4.Controls.Add(this.lbljuegores);
            this.panel4.Controls.Add(this.lblresultado);
            this.panel4.Location = new System.Drawing.Point(5, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 210);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(204, 172);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblahorrores
            // 
            this.lblahorrores.AutoSize = true;
            this.lblahorrores.Location = new System.Drawing.Point(215, 146);
            this.lblahorrores.Name = "lblahorrores";
            this.lblahorrores.Size = new System.Drawing.Size(35, 13);
            this.lblahorrores.TabIndex = 5;
            this.lblahorrores.Text = "label6";
            // 
            // lblmonedasres
            // 
            this.lblmonedasres.AutoSize = true;
            this.lblmonedasres.Location = new System.Drawing.Point(215, 123);
            this.lblmonedasres.Name = "lblmonedasres";
            this.lblmonedasres.Size = new System.Drawing.Size(35, 13);
            this.lblmonedasres.TabIndex = 4;
            this.lblmonedasres.Text = "label6";
            // 
            // lblelores
            // 
            this.lblelores.AutoSize = true;
            this.lblelores.Location = new System.Drawing.Point(215, 99);
            this.lblelores.Name = "lblelores";
            this.lblelores.Size = new System.Drawing.Size(35, 13);
            this.lblelores.TabIndex = 3;
            this.lblelores.Text = "label6";
            // 
            // lblnumerores
            // 
            this.lblnumerores.AutoSize = true;
            this.lblnumerores.Location = new System.Drawing.Point(215, 74);
            this.lblnumerores.Name = "lblnumerores";
            this.lblnumerores.Size = new System.Drawing.Size(35, 13);
            this.lblnumerores.TabIndex = 2;
            this.lblnumerores.Text = "label6";
            // 
            // lbljuegores
            // 
            this.lbljuegores.AutoSize = true;
            this.lbljuegores.Location = new System.Drawing.Point(215, 53);
            this.lbljuegores.Name = "lbljuegores";
            this.lbljuegores.Size = new System.Drawing.Size(35, 13);
            this.lbljuegores.TabIndex = 1;
            this.lbljuegores.Text = "label6";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(199, 16);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(70, 25);
            this.lblresultado.TabIndex = 0;
            this.lblresultado.Text = "label6";
            // 
            // formaencuentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 259);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "formaencuentro";
            this.Text = "formaencuentro";
            this.Load += new System.EventHandler(this.formaencuentro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button desp1;
        private System.Windows.Forms.Button ant1;
        private System.Windows.Forms.Label lblcantidadnueva;
        private System.Windows.Forms.Label lblmonedas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmon;
        private System.Windows.Forms.Label lblelo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbljuego;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbahorro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblahorrores;
        private System.Windows.Forms.Label lblmonedasres;
        private System.Windows.Forms.Label lblelores;
        private System.Windows.Forms.Label lblnumerores;
        private System.Windows.Forms.Label lbljuegores;
        private System.Windows.Forms.Label lblresultado;
    }
}