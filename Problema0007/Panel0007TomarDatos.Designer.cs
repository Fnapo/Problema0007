namespace Problema0007
{
    partial class Panel0007TomarDatos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelLugar = new Panel();
            labelDato = new Label();
            controlNumericoLugar = new NumericUpDown();
            panelBuscar.SuspendLayout();
            panelCentro.SuspendLayout();
            panelBajo.SuspendLayout();
            panelLugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)controlNumericoLugar).BeginInit();
            SuspendLayout();
            // 
            // labelFichero
            // 
            labelFichero.Dock = DockStyle.Top;
            labelFichero.Size = new Size(655, 252);
            labelFichero.Text = "Debes cargar la lista de Números Primos ...";
            // 
            // panelBuscar
            // 
            panelBuscar.Location = new Point(0, 252);
            panelBuscar.Size = new Size(655, 39);
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(218, 4);
            // 
            // labelTop
            // 
            labelTop.Size = new Size(655, 38);
            // 
            // panelCentro
            // 
            panelCentro.Controls.Add(panelLugar);
            panelCentro.Size = new Size(657, 332);
            panelCentro.Controls.SetChildIndex(panelLugar, 0);
            panelCentro.Controls.SetChildIndex(panelBuscar, 0);
            // 
            // botonSolucionar
            // 
            botonSolucionar.Location = new Point(241, 9);
            // 
            // panelBajo
            // 
            panelBajo.Location = new Point(0, 372);
            panelBajo.Size = new Size(657, 50);
            // 
            // panelLugar
            // 
            panelLugar.Controls.Add(labelDato);
            panelLugar.Controls.Add(controlNumericoLugar);
            panelLugar.Dock = DockStyle.Bottom;
            panelLugar.Location = new Point(0, 291);
            panelLugar.Name = "panelLugar";
            panelLugar.Size = new Size(655, 39);
            panelLugar.TabIndex = 2;
            // 
            // labelDato
            // 
            labelDato.Location = new Point(177, 5);
            labelDato.Name = "labelDato";
            labelDato.Size = new Size(149, 29);
            labelDato.TabIndex = 2;
            labelDato.Text = "label1";
            labelDato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // controlNumericoLugar
            // 
            controlNumericoLugar.Anchor = AnchorStyles.None;
            controlNumericoLugar.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            controlNumericoLugar.Location = new Point(355, 5);
            controlNumericoLugar.Maximum = new decimal(new int[] { 75000, 0, 0, 0 });
            controlNumericoLugar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            controlNumericoLugar.Name = "controlNumericoLugar";
            controlNumericoLugar.Size = new Size(122, 29);
            controlNumericoLugar.TabIndex = 1;
            controlNumericoLugar.ThousandsSeparator = true;
            controlNumericoLugar.Value = new decimal(new int[] { 10001, 0, 0, 0 });
            controlNumericoLugar.ValueChanged += ControlNumericoLugar_ValueChanged;
            // 
            // Panel0007TomarDatos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "Panel0007TomarDatos";
            Size = new Size(657, 422);
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            panelCentro.ResumeLayout(false);
            panelBajo.ResumeLayout(false);
            panelLugar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)controlNumericoLugar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLugar;
        protected NumericUpDown controlNumericoLugar;
        protected Label labelDato;
        //protected Label label1;
    }
}
