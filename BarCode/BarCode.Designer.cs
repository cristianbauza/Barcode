namespace BarCode
{
    partial class BarCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.mizql = new System.Windows.Forms.Label();
            this.mderl = new System.Windows.Forms.Label();
            this.msupl = new System.Windows.Forms.Label();
            this.minfl = new System.Windows.Forms.Label();
            this.columnasl = new System.Windows.Forms.Label();
            this.filasl = new System.Windows.Forms.Label();
            this.mizq = new System.Windows.Forms.TextBox();
            this.mder = new System.Windows.Forms.TextBox();
            this.msup = new System.Windows.Forms.TextBox();
            this.minf = new System.Windows.Forms.TextBox();
            this.filas = new System.Windows.Forms.TextBox();
            this.columnas = new System.Windows.Forms.TextBox();
            this.nhasta = new System.Windows.Forms.TextBox();
            this.ndesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generar = new System.Windows.Forms.Button();
            this.tcodigol = new System.Windows.Forms.Label();
            this.tipoCodigo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Generador de Etiquetas de códigos de barra";
            // 
            // mizql
            // 
            this.mizql.AutoSize = true;
            this.mizql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mizql.Location = new System.Drawing.Point(104, 106);
            this.mizql.Name = "mizql";
            this.mizql.Size = new System.Drawing.Size(166, 16);
            this.mizql.TabIndex = 16;
            this.mizql.Text = "Margen Izquierdo (cm):";
            // 
            // mderl
            // 
            this.mderl.AutoSize = true;
            this.mderl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mderl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mderl.Location = new System.Drawing.Point(109, 133);
            this.mderl.Name = "mderl";
            this.mderl.Size = new System.Drawing.Size(161, 16);
            this.mderl.TabIndex = 17;
            this.mderl.Text = "Margen Derecho (cm):";
            // 
            // msupl
            // 
            this.msupl.AutoSize = true;
            this.msupl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msupl.Location = new System.Drawing.Point(109, 160);
            this.msupl.Name = "msupl";
            this.msupl.Size = new System.Drawing.Size(161, 16);
            this.msupl.TabIndex = 18;
            this.msupl.Text = "Margen Superior (cm):";
            // 
            // minfl
            // 
            this.minfl.AutoSize = true;
            this.minfl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minfl.Location = new System.Drawing.Point(120, 187);
            this.minfl.Name = "minfl";
            this.minfl.Size = new System.Drawing.Size(150, 16);
            this.minfl.TabIndex = 19;
            this.minfl.Text = "Margen Inferior (cm):";
            // 
            // columnasl
            // 
            this.columnasl.AutoSize = true;
            this.columnasl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnasl.Location = new System.Drawing.Point(136, 217);
            this.columnasl.Name = "columnasl";
            this.columnasl.Size = new System.Drawing.Size(134, 16);
            this.columnasl.TabIndex = 7;
            this.columnasl.Text = "Cantidad de Filas:";
            // 
            // filasl
            // 
            this.filasl.AutoSize = true;
            this.filasl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filasl.Location = new System.Drawing.Point(102, 244);
            this.filasl.Name = "filasl";
            this.filasl.Size = new System.Drawing.Size(168, 16);
            this.filasl.TabIndex = 8;
            this.filasl.Text = "Cantidad de Columnas:";
            // 
            // mizq
            // 
            this.mizq.Location = new System.Drawing.Point(294, 102);
            this.mizq.Name = "mizq";
            this.mizq.Size = new System.Drawing.Size(121, 20);
            this.mizq.TabIndex = 9;
            this.mizq.Text = "1";
            // 
            // mder
            // 
            this.mder.Location = new System.Drawing.Point(294, 129);
            this.mder.Name = "mder";
            this.mder.Size = new System.Drawing.Size(121, 20);
            this.mder.TabIndex = 10;
            this.mder.Text = "1";
            // 
            // msup
            // 
            this.msup.Location = new System.Drawing.Point(294, 156);
            this.msup.Name = "msup";
            this.msup.Size = new System.Drawing.Size(121, 20);
            this.msup.TabIndex = 11;
            this.msup.Text = "1";
            // 
            // minf
            // 
            this.minf.Location = new System.Drawing.Point(294, 183);
            this.minf.Name = "minf";
            this.minf.Size = new System.Drawing.Size(121, 20);
            this.minf.TabIndex = 12;
            this.minf.Text = "1";
            // 
            // filas
            // 
            this.filas.Location = new System.Drawing.Point(294, 213);
            this.filas.Name = "filas";
            this.filas.Size = new System.Drawing.Size(121, 20);
            this.filas.TabIndex = 15;
            // 
            // columnas
            // 
            this.columnas.Location = new System.Drawing.Point(294, 240);
            this.columnas.Name = "columnas";
            this.columnas.Size = new System.Drawing.Size(121, 20);
            this.columnas.TabIndex = 16;
            // 
            // nhasta
            // 
            this.nhasta.Location = new System.Drawing.Point(294, 298);
            this.nhasta.Name = "nhasta";
            this.nhasta.Size = new System.Drawing.Size(121, 20);
            this.nhasta.TabIndex = 20;
            // 
            // ndesde
            // 
            this.ndesde.Location = new System.Drawing.Point(294, 271);
            this.ndesde.Name = "ndesde";
            this.ndesde.Size = new System.Drawing.Size(121, 20);
            this.ndesde.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Númeor Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Número Desde:";
            // 
            // generar
            // 
            this.generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generar.Location = new System.Drawing.Point(73, 343);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(321, 23);
            this.generar.TabIndex = 22;
            this.generar.Text = "G E N E R A R";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // tcodigol
            // 
            this.tcodigol.AutoSize = true;
            this.tcodigol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcodigol.Location = new System.Drawing.Point(150, 80);
            this.tcodigol.Name = "tcodigol";
            this.tcodigol.Size = new System.Drawing.Size(120, 16);
            this.tcodigol.TabIndex = 23;
            this.tcodigol.Text = "Tipo de Código:";
            // 
            // tipoCodigo
            // 
            this.tipoCodigo.FormattingEnabled = true;
            this.tipoCodigo.Items.AddRange(new object[] {
            "BARCODE_39",
            "BARCODE_128"});
            this.tipoCodigo.Location = new System.Drawing.Point(294, 75);
            this.tipoCodigo.Name = "tipoCodigo";
            this.tipoCodigo.Size = new System.Drawing.Size(121, 21);
            this.tipoCodigo.TabIndex = 24;
            this.tipoCodigo.Text = "BARCODE_39";
            // 
            // BarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 386);
            this.Controls.Add(this.tipoCodigo);
            this.Controls.Add(this.tcodigol);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.nhasta);
            this.Controls.Add(this.ndesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.columnas);
            this.Controls.Add(this.minf);
            this.Controls.Add(this.msup);
            this.Controls.Add(this.mder);
            this.Controls.Add(this.mizq);
            this.Controls.Add(this.filasl);
            this.Controls.Add(this.columnasl);
            this.Controls.Add(this.minfl);
            this.Controls.Add(this.msupl);
            this.Controls.Add(this.mderl);
            this.Controls.Add(this.mizql);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filas);
            this.Name = "BarCode";
            this.Text = "BarCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mizql;
        private System.Windows.Forms.Label mderl;
        private System.Windows.Forms.Label msupl;
        private System.Windows.Forms.Label minfl;
        private System.Windows.Forms.Label columnasl;
        private System.Windows.Forms.Label filasl;
        private System.Windows.Forms.TextBox mizq;
        private System.Windows.Forms.TextBox mder;
        private System.Windows.Forms.TextBox msup;
        private System.Windows.Forms.TextBox minf;
        private System.Windows.Forms.TextBox filas;
        private System.Windows.Forms.TextBox columnas;
        private System.Windows.Forms.TextBox nhasta;
        private System.Windows.Forms.TextBox ndesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Label tcodigol;
        private System.Windows.Forms.ComboBox tipoCodigo;
    }
}

