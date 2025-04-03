namespace Problema0007
{
    partial class Form0007
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
            panel0007TomarDatos1 = new Panel0007TomarDatos();
            SuspendLayout();
            // 
            // panel0007TomarDatos1
            // 
            panel0007TomarDatos1.BorderStyle = BorderStyle.FixedSingle;
            panel0007TomarDatos1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel0007TomarDatos1.Location = new Point(86, 60);
            panel0007TomarDatos1.Margin = new Padding(4);
            panel0007TomarDatos1.Name = "panel0007TomarDatos1";
            panel0007TomarDatos1.Size = new Size(551, 361);
            panel0007TomarDatos1.TabIndex = 4;
            // 
            // Problema0007
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel0007TomarDatos1);
            Name = "Problema0007";
            Text = "Séptimo problema del Proyecto Euler";
            Controls.SetChildIndex(panelEnunciado1, 0);
            Controls.SetChildIndex(panelBuscando1, 0);
            Controls.SetChildIndex(panelMostrar1, 0);
            Controls.SetChildIndex(panel0007TomarDatos1, 0);
            ResumeLayout(false);
        }

        #endregion

        private Panel0007TomarDatos panel0007TomarDatos1;
    }
}
