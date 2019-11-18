namespace Traductor_Ascii
{
    partial class Form1
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
            this.btn_Traducir = new System.Windows.Forms.Button();
            this.lbl_Traducido = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarArchivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarArchivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_A_Traducir = new System.Windows.Forms.TextBox();
            this.lbl_Alert = new System.Windows.Forms.Label();
            this.traduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCIIACaracterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caracterAASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Traducir
            // 
            this.btn_Traducir.Enabled = false;
            this.btn_Traducir.Location = new System.Drawing.Point(176, 136);
            this.btn_Traducir.Name = "btn_Traducir";
            this.btn_Traducir.Size = new System.Drawing.Size(75, 22);
            this.btn_Traducir.TabIndex = 0;
            this.btn_Traducir.Text = "Traducir";
            this.btn_Traducir.UseVisualStyleBackColor = true;
            this.btn_Traducir.Click += new System.EventHandler(this.btn_Traducir_Click);
            // 
            // lbl_Traducido
            // 
            this.lbl_Traducido.AllowDrop = true;
            this.lbl_Traducido.AutoEllipsis = true;
            this.lbl_Traducido.Enabled = false;
            this.lbl_Traducido.Location = new System.Drawing.Point(257, 24);
            this.lbl_Traducido.Name = "lbl_Traducido";
            this.lbl_Traducido.Size = new System.Drawing.Size(192, 266);
            this.lbl_Traducido.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traduccionToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarArchivoToolStripMenuItem1,
            this.exportarArchivoToolStripMenuItem1});
            this.accionesToolStripMenuItem.Enabled = false;
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // importarArchivoToolStripMenuItem1
            // 
            this.importarArchivoToolStripMenuItem1.Name = "importarArchivoToolStripMenuItem1";
            this.importarArchivoToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.importarArchivoToolStripMenuItem1.Text = "Importar Archivo";
            this.importarArchivoToolStripMenuItem1.Click += new System.EventHandler(this.importarArchivoToolStripMenuItem1_Click);
            // 
            // exportarArchivoToolStripMenuItem1
            // 
            this.exportarArchivoToolStripMenuItem1.Name = "exportarArchivoToolStripMenuItem1";
            this.exportarArchivoToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.exportarArchivoToolStripMenuItem1.Text = "Exportar Archivo";
            this.exportarArchivoToolStripMenuItem1.Click += new System.EventHandler(this.exportarArchivoToolStripMenuItem1_Click);
            // 
            // txt_A_Traducir
            // 
            this.txt_A_Traducir.AllowDrop = true;
            this.txt_A_Traducir.Enabled = false;
            this.txt_A_Traducir.Location = new System.Drawing.Point(0, 27);
            this.txt_A_Traducir.Multiline = true;
            this.txt_A_Traducir.Name = "txt_A_Traducir";
            this.txt_A_Traducir.Size = new System.Drawing.Size(170, 275);
            this.txt_A_Traducir.TabIndex = 3;
            // 
            // lbl_Alert
            // 
            this.lbl_Alert.AutoSize = true;
            this.lbl_Alert.Enabled = false;
            this.lbl_Alert.Location = new System.Drawing.Point(176, 183);
            this.lbl_Alert.Name = "lbl_Alert";
            this.lbl_Alert.Size = new System.Drawing.Size(0, 13);
            this.lbl_Alert.TabIndex = 4;
            // 
            // traduccionToolStripMenuItem
            // 
            this.traduccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCIIACaracterToolStripMenuItem,
            this.caracterAASCIIToolStripMenuItem});
            this.traduccionToolStripMenuItem.Name = "traduccionToolStripMenuItem";
            this.traduccionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.traduccionToolStripMenuItem.Text = "Traduccion";
            // 
            // aSCIIACaracterToolStripMenuItem
            // 
            this.aSCIIACaracterToolStripMenuItem.Name = "aSCIIACaracterToolStripMenuItem";
            this.aSCIIACaracterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aSCIIACaracterToolStripMenuItem.Text = "ASCII a Caracter";
            this.aSCIIACaracterToolStripMenuItem.Click += new System.EventHandler(this.aSCIIACaracterToolStripMenuItem_Click);
            // 
            // caracterAASCIIToolStripMenuItem
            // 
            this.caracterAASCIIToolStripMenuItem.Name = "caracterAASCIIToolStripMenuItem";
            this.caracterAASCIIToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.caracterAASCIIToolStripMenuItem.Text = "Caracter a ASCII";
            this.caracterAASCIIToolStripMenuItem.Click += new System.EventHandler(this.caracterAASCIIToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 311);
            this.Controls.Add(this.lbl_Alert);
            this.Controls.Add(this.txt_A_Traducir);
            this.Controls.Add(this.lbl_Traducido);
            this.Controls.Add(this.btn_Traducir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Traducir;
        private System.Windows.Forms.Label lbl_Traducido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txt_A_Traducir;
        private System.Windows.Forms.Label lbl_Alert;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarArchivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportarArchivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem traduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCIIACaracterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caracterAASCIIToolStripMenuItem;
    }
}

