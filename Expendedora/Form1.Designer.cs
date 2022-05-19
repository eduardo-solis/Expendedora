
namespace Expendedora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCambio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.surtirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnManzanita = new System.Windows.Forms.RadioButton();
            this.rbtnSprite = new System.Windows.Forms.RadioButton();
            this.rbtnFanta = new System.Windows.Forms.RadioButton();
            this.rbtnFresca = new System.Windows.Forms.RadioButton();
            this.rbtnCoca = new System.Windows.Forms.RadioButton();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.lbCoca = new System.Windows.Forms.Label();
            this.lbFresca = new System.Windows.Forms.Label();
            this.lbFanta = new System.Windows.Forms.Label();
            this.lbSprite = new System.Windows.Forms.Label();
            this.lbManzanita = new System.Windows.Forms.Label();
            this.cocaColaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frescaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fantaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expendedora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(305, 108);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(22, 13);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "4,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inserte moneda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "(.50, 1, 2, 5, 10)";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(207, 152);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtMoneda.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(340, 150);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(459, 155);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(22, 13);
            this.lbSaldo.TabIndex = 7;
            this.lbSaldo.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Su cambio: ";
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Location = new System.Drawing.Point(462, 205);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(22, 13);
            this.lbCambio.TabIndex = 9;
            this.lbCambio.Text = "0.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surtirToolStripMenuItem,
            this.precioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // surtirToolStripMenuItem
            // 
            this.surtirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cocaColaToolStripMenuItem,
            this.frescaToolStripMenuItem,
            this.fantaToolStripMenuItem,
            this.spriteToolStripMenuItem,
            this.manzanitaToolStripMenuItem});
            this.surtirToolStripMenuItem.Name = "surtirToolStripMenuItem";
            this.surtirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.surtirToolStripMenuItem.Text = "Surtir";
            // 
            // precioToolStripMenuItem
            // 
            this.precioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarToolStripMenuItem});
            this.precioToolStripMenuItem.Name = "precioToolStripMenuItem";
            this.precioToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.precioToolStripMenuItem.Text = "Precio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbManzanita);
            this.groupBox1.Controls.Add(this.lbSprite);
            this.groupBox1.Controls.Add(this.lbFanta);
            this.groupBox1.Controls.Add(this.lbFresca);
            this.groupBox1.Controls.Add(this.lbCoca);
            this.groupBox1.Controls.Add(this.rbtnManzanita);
            this.groupBox1.Controls.Add(this.rbtnSprite);
            this.groupBox1.Controls.Add(this.rbtnFanta);
            this.groupBox1.Controls.Add(this.rbtnFresca);
            this.groupBox1.Controls.Add(this.rbtnCoca);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(30, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refrescos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnManzanita
            // 
            this.rbtnManzanita.AutoSize = true;
            this.rbtnManzanita.Location = new System.Drawing.Point(82, 133);
            this.rbtnManzanita.Name = "rbtnManzanita";
            this.rbtnManzanita.Size = new System.Drawing.Size(74, 17);
            this.rbtnManzanita.TabIndex = 4;
            this.rbtnManzanita.TabStop = true;
            this.rbtnManzanita.Text = "Manzanita";
            this.rbtnManzanita.UseVisualStyleBackColor = true;
            // 
            // rbtnSprite
            // 
            this.rbtnSprite.AutoSize = true;
            this.rbtnSprite.Location = new System.Drawing.Point(82, 109);
            this.rbtnSprite.Name = "rbtnSprite";
            this.rbtnSprite.Size = new System.Drawing.Size(52, 17);
            this.rbtnSprite.TabIndex = 3;
            this.rbtnSprite.TabStop = true;
            this.rbtnSprite.Text = "Sprite";
            this.rbtnSprite.UseVisualStyleBackColor = true;
            // 
            // rbtnFanta
            // 
            this.rbtnFanta.AutoSize = true;
            this.rbtnFanta.Location = new System.Drawing.Point(82, 85);
            this.rbtnFanta.Name = "rbtnFanta";
            this.rbtnFanta.Size = new System.Drawing.Size(52, 17);
            this.rbtnFanta.TabIndex = 2;
            this.rbtnFanta.TabStop = true;
            this.rbtnFanta.Text = "Fanta";
            this.rbtnFanta.UseVisualStyleBackColor = true;
            // 
            // rbtnFresca
            // 
            this.rbtnFresca.AutoSize = true;
            this.rbtnFresca.Location = new System.Drawing.Point(82, 61);
            this.rbtnFresca.Name = "rbtnFresca";
            this.rbtnFresca.Size = new System.Drawing.Size(57, 17);
            this.rbtnFresca.TabIndex = 1;
            this.rbtnFresca.TabStop = true;
            this.rbtnFresca.Text = "Fresca";
            this.rbtnFresca.UseVisualStyleBackColor = true;
            // 
            // rbtnCoca
            // 
            this.rbtnCoca.AutoSize = true;
            this.rbtnCoca.Location = new System.Drawing.Point(82, 37);
            this.rbtnCoca.Name = "rbtnCoca";
            this.rbtnCoca.Size = new System.Drawing.Size(80, 17);
            this.rbtnCoca.TabIndex = 0;
            this.rbtnCoca.TabStop = true;
            this.rbtnCoca.Text = "Coca - Cola";
            this.rbtnCoca.UseVisualStyleBackColor = true;
            // 
            // btnDespachar
            // 
            this.btnDespachar.Enabled = false;
            this.btnDespachar.Location = new System.Drawing.Point(94, 491);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(340, 23);
            this.btnDespachar.TabIndex = 12;
            this.btnDespachar.Text = "Seleccione su refresco";
            this.btnDespachar.UseVisualStyleBackColor = true;
            // 
            // lbCoca
            // 
            this.lbCoca.AutoSize = true;
            this.lbCoca.Location = new System.Drawing.Point(27, 41);
            this.lbCoca.Name = "lbCoca";
            this.lbCoca.Size = new System.Drawing.Size(19, 13);
            this.lbCoca.TabIndex = 5;
            this.lbCoca.Text = "10";
            // 
            // lbFresca
            // 
            this.lbFresca.AutoSize = true;
            this.lbFresca.Location = new System.Drawing.Point(27, 65);
            this.lbFresca.Name = "lbFresca";
            this.lbFresca.Size = new System.Drawing.Size(13, 13);
            this.lbFresca.TabIndex = 6;
            this.lbFresca.Text = "5";
            // 
            // lbFanta
            // 
            this.lbFanta.AutoSize = true;
            this.lbFanta.Location = new System.Drawing.Point(27, 89);
            this.lbFanta.Name = "lbFanta";
            this.lbFanta.Size = new System.Drawing.Size(13, 13);
            this.lbFanta.TabIndex = 7;
            this.lbFanta.Text = "5";
            // 
            // lbSprite
            // 
            this.lbSprite.AutoSize = true;
            this.lbSprite.Location = new System.Drawing.Point(27, 113);
            this.lbSprite.Name = "lbSprite";
            this.lbSprite.Size = new System.Drawing.Size(13, 13);
            this.lbSprite.TabIndex = 8;
            this.lbSprite.Text = "5";
            // 
            // lbManzanita
            // 
            this.lbManzanita.AutoSize = true;
            this.lbManzanita.Location = new System.Drawing.Point(27, 137);
            this.lbManzanita.Name = "lbManzanita";
            this.lbManzanita.Size = new System.Drawing.Size(13, 13);
            this.lbManzanita.TabIndex = 9;
            this.lbManzanita.Text = "5";
            // 
            // cocaColaToolStripMenuItem
            // 
            this.cocaColaToolStripMenuItem.Name = "cocaColaToolStripMenuItem";
            this.cocaColaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cocaColaToolStripMenuItem.Text = "Coca - Cola";
            this.cocaColaToolStripMenuItem.Click += new System.EventHandler(this.cocaColaToolStripMenuItem_Click);
            // 
            // frescaToolStripMenuItem
            // 
            this.frescaToolStripMenuItem.Name = "frescaToolStripMenuItem";
            this.frescaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frescaToolStripMenuItem.Text = "Fresca";
            this.frescaToolStripMenuItem.Click += new System.EventHandler(this.frescaToolStripMenuItem_Click);
            // 
            // fantaToolStripMenuItem
            // 
            this.fantaToolStripMenuItem.Name = "fantaToolStripMenuItem";
            this.fantaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fantaToolStripMenuItem.Text = "Fanta";
            this.fantaToolStripMenuItem.Click += new System.EventHandler(this.fantaToolStripMenuItem_Click);
            // 
            // spriteToolStripMenuItem
            // 
            this.spriteToolStripMenuItem.Name = "spriteToolStripMenuItem";
            this.spriteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spriteToolStripMenuItem.Text = "Sprite";
            this.spriteToolStripMenuItem.Click += new System.EventHandler(this.spriteToolStripMenuItem_Click);
            // 
            // manzanitaToolStripMenuItem
            // 
            this.manzanitaToolStripMenuItem.Name = "manzanitaToolStripMenuItem";
            this.manzanitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manzanitaToolStripMenuItem.Text = "Manzanita";
            this.manzanitaToolStripMenuItem.Click += new System.EventHandler(this.manzanitaToolStripMenuItem_Click);
            // 
            // cambiarToolStripMenuItem
            // 
            this.cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            this.cambiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarToolStripMenuItem.Text = "Cambiar";
            this.cambiarToolStripMenuItem.Click += new System.EventHandler(this.cambiarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 543);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCambio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem surtirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precioToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnManzanita;
        private System.Windows.Forms.RadioButton rbtnSprite;
        private System.Windows.Forms.RadioButton rbtnFanta;
        private System.Windows.Forms.RadioButton rbtnFresca;
        private System.Windows.Forms.RadioButton rbtnCoca;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Label lbManzanita;
        private System.Windows.Forms.Label lbSprite;
        private System.Windows.Forms.Label lbFanta;
        private System.Windows.Forms.Label lbFresca;
        private System.Windows.Forms.Label lbCoca;
        private System.Windows.Forms.ToolStripMenuItem cocaColaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frescaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fantaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manzanitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarToolStripMenuItem;
    }
}

