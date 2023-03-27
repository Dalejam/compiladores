namespace AdjuntarArchivo
{
    partial class LeerArchivo
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
            opcionIngDatos = new GroupBox();
            adjuntarDoc = new RadioButton();
            ingresarTexto = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            botonAdjuntar = new Button();
            rutaArchivo = new TextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            leerTextoIng = new Button();
            opcionIngDatos.SuspendLayout();
            SuspendLayout();
            // 
            // opcionIngDatos
            // 
            opcionIngDatos.Controls.Add(adjuntarDoc);
            opcionIngDatos.Controls.Add(ingresarTexto);
            opcionIngDatos.Location = new Point(132, 2);
            opcionIngDatos.Name = "opcionIngDatos";
            opcionIngDatos.Size = new Size(444, 56);
            opcionIngDatos.TabIndex = 0;
            opcionIngDatos.TabStop = false;
            opcionIngDatos.Text = "Opciones de Ingreso de datos";
            opcionIngDatos.Enter += opcionIngDatos_Enter;
            // 
            // adjuntarDoc
            // 
            adjuntarDoc.AutoSize = true;
            adjuntarDoc.Location = new Point(22, 22);
            adjuntarDoc.Name = "adjuntarDoc";
            adjuntarDoc.Size = new Size(137, 19);
            adjuntarDoc.TabIndex = 1;
            adjuntarDoc.TabStop = true;
            adjuntarDoc.Text = "Adjuntar Documento";
            adjuntarDoc.UseVisualStyleBackColor = true;
            adjuntarDoc.CheckedChanged += adjuntarDoc_CheckedChanged;
            // 
            // ingresarTexto
            // 
            ingresarTexto.AutoSize = true;
            ingresarTexto.Location = new Point(186, 22);
            ingresarTexto.Name = "ingresarTexto";
            ingresarTexto.Size = new Size(98, 19);
            ingresarTexto.TabIndex = 0;
            ingresarTexto.TabStop = true;
            ingresarTexto.Text = "Ingresar Texto";
            ingresarTexto.UseVisualStyleBackColor = true;
            ingresarTexto.CheckedChanged += ingresarTexto_CheckedChanged_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos (*.txt)|*.txt|Archivo HTML (*.HTML)|*.html|Archivo XML (*.XML)|*.xml";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // botonAdjuntar
            // 
            botonAdjuntar.Location = new Point(501, 63);
            botonAdjuntar.Name = "botonAdjuntar";
            botonAdjuntar.Size = new Size(75, 23);
            botonAdjuntar.TabIndex = 1;
            botonAdjuntar.Text = "...";
            botonAdjuntar.UseVisualStyleBackColor = true;
            botonAdjuntar.Click += botonAdjuntar_Click;
            // 
            // rutaArchivo
            // 
            rutaArchivo.Location = new Point(132, 64);
            rutaArchivo.Name = "rutaArchivo";
            rutaArchivo.Size = new Size(363, 23);
            rutaArchivo.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(132, 185);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(444, 253);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(132, 64);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(363, 71);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // leerTextoIng
            // 
            leerTextoIng.Location = new Point(501, 111);
            leerTextoIng.Name = "leerTextoIng";
            leerTextoIng.Size = new Size(75, 23);
            leerTextoIng.TabIndex = 5;
            leerTextoIng.Text = "Leer";
            leerTextoIng.UseVisualStyleBackColor = true;
            leerTextoIng.Click += leerTextoIng_Click;
            // 
            // LeerArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(leerTextoIng);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(rutaArchivo);
            Controls.Add(botonAdjuntar);
            Controls.Add(opcionIngDatos);
            Name = "LeerArchivo";
            Text = "Form1";
            Load += Form1_Load;
            opcionIngDatos.ResumeLayout(false);
            opcionIngDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox opcionIngDatos;
        private OpenFileDialog openFileDialog1;
        private Button botonAdjuntar;
        private TextBox rutaArchivo;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RadioButton adjuntarDoc;
        private RadioButton ingresarTexto;
        private Button leerTextoIng;
    }
}