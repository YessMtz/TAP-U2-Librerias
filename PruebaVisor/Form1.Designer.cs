
namespace PruebaVisor
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
            this.userCtrl1 = new Unidad_2_Librerias.UserCtrl();
            this.SuspendLayout();
            // 
            // userCtrl1
            // 
            this.userCtrl1.Dimension = 0;
            this.userCtrl1.Directorio = "C:\\Users\\admin\\Desktop\\REPOSITORIOS GIT HUB\\TAP-U2-Librerias\\Unidad 2 Librerias\\b" +
    "in\\Debug";
            this.userCtrl1.Location = new System.Drawing.Point(60, 72);
            this.userCtrl1.Margin = new System.Windows.Forms.Padding(4);
            this.userCtrl1.Name = "userCtrl1";
            this.userCtrl1.Sepracion = 10;
            this.userCtrl1.Size = new System.Drawing.Size(594, 332);
            this.userCtrl1.TabIndex = 0;
            this.userCtrl1.Load += new System.EventHandler(this.userCtrl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userCtrl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Unidad_2_Librerias.UserCtrl userCtrl1;
    }
}

