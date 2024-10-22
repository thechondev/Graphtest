namespace Graphtest
{
    partial class Winicio
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
            this.components = new System.ComponentModel.Container();
            this.tmrPro = new System.Windows.Forms.Timer(this.components);
            this.cmdstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrPro
            // 
            this.tmrPro.Tick += new System.EventHandler(this.tmrPro_Tick);
            // 
            // cmdstart
            // 
            this.cmdstart.Location = new System.Drawing.Point(444, 59);
            this.cmdstart.Name = "cmdstart";
            this.cmdstart.Size = new System.Drawing.Size(75, 23);
            this.cmdstart.TabIndex = 0;
            this.cmdstart.Text = "Inicio";
            this.cmdstart.UseVisualStyleBackColor = true;
            this.cmdstart.Click += new System.EventHandler(this.cmdstart_Click);
            // 
            // Winicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.cmdstart);
            this.Name = "Winicio";
            this.Text = "Grafico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrPro;
        private System.Windows.Forms.Button cmdstart;
    }
}

