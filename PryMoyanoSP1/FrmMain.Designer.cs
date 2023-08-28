namespace PryMoyanoSP1
{
    partial class FrmMain
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
            this.BtnCrear = new System.Windows.Forms.Button();
            this.btnleer = new System.Windows.Forms.Button();
            this.txttextito = new System.Windows.Forms.TextBox();
            this.btngrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(12, 334);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(157, 60);
            this.BtnCrear.TabIndex = 0;
            this.BtnCrear.Text = "Crear Archivo";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(254, 334);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(157, 60);
            this.btnleer.TabIndex = 1;
            this.btnleer.Text = "Leer Archivo";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // txttextito
            // 
            this.txttextito.Location = new System.Drawing.Point(23, 45);
            this.txttextito.Multiline = true;
            this.txttextito.Name = "txttextito";
            this.txttextito.Size = new System.Drawing.Size(388, 181);
            this.txttextito.TabIndex = 2;
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(254, 232);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(157, 60);
            this.btngrabar.TabIndex = 3;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.txttextito);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.BtnCrear);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.TextBox txttextito;
        private System.Windows.Forms.Button btngrabar;
    }
}

