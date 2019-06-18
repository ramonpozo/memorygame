namespace Memory
{
    partial class Dificultad
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
            this.buttonJugar = new System.Windows.Forms.Button();
            this.tableLayoutPanelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonNumeros = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimales = new System.Windows.Forms.RadioButton();
            this.radioButtonColores = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelDecoracion = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxIzq = new System.Windows.Forms.PictureBox();
            this.pictureBoxDer = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelContenedor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelDecoracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJugar
            // 
            this.buttonJugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(236)))), ((int)(((byte)(106)))));
            this.buttonJugar.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJugar.Location = new System.Drawing.Point(215, 544);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(300, 100);
            this.buttonJugar.TabIndex = 0;
            this.buttonJugar.Text = "¡A jugar!";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // tableLayoutPanelContenedor
            // 
            this.tableLayoutPanelContenedor.ColumnCount = 1;
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContenedor.Controls.Add(this.buttonJugar, 0, 4);
            this.tableLayoutPanelContenedor.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanelContenedor.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanelContenedor.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContenedor.Location = new System.Drawing.Point(371, 3);
            this.tableLayoutPanelContenedor.Name = "tableLayoutPanelContenedor";
            this.tableLayoutPanelContenedor.RowCount = 5;
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContenedor.Size = new System.Drawing.Size(730, 661);
            this.tableLayoutPanelContenedor.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonNumeros, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonAnimales, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonColores, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 399);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 126);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // radioButtonNumeros
            // 
            this.radioButtonNumeros.AutoSize = true;
            this.radioButtonNumeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonNumeros.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNumeros.Location = new System.Drawing.Point(485, 3);
            this.radioButtonNumeros.Name = "radioButtonNumeros";
            this.radioButtonNumeros.Size = new System.Drawing.Size(236, 120);
            this.radioButtonNumeros.TabIndex = 2;
            this.radioButtonNumeros.TabStop = true;
            this.radioButtonNumeros.Text = "Los numeros";
            this.radioButtonNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonNumeros.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnimales
            // 
            this.radioButtonAnimales.AutoSize = true;
            this.radioButtonAnimales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonAnimales.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnimales.Location = new System.Drawing.Point(244, 3);
            this.radioButtonAnimales.Name = "radioButtonAnimales";
            this.radioButtonAnimales.Size = new System.Drawing.Size(235, 120);
            this.radioButtonAnimales.TabIndex = 1;
            this.radioButtonAnimales.TabStop = true;
            this.radioButtonAnimales.Text = "Los animales";
            this.radioButtonAnimales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAnimales.UseVisualStyleBackColor = true;
            // 
            // radioButtonColores
            // 
            this.radioButtonColores.AutoSize = true;
            this.radioButtonColores.Checked = true;
            this.radioButtonColores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonColores.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonColores.Location = new System.Drawing.Point(3, 3);
            this.radioButtonColores.Name = "radioButtonColores";
            this.radioButtonColores.Size = new System.Drawing.Size(235, 120);
            this.radioButtonColores.TabIndex = 0;
            this.radioButtonColores.TabStop = true;
            this.radioButtonColores.Text = "Los colores";
            this.radioButtonColores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonColores.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(724, 132);
            this.label2.TabIndex = 3;
            this.label2.Text = "¿Que quieres aprender?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 132);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelDecoracion
            // 
            this.tableLayoutPanelDecoracion.ColumnCount = 3;
            this.tableLayoutPanelDecoracion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDecoracion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDecoracion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDecoracion.Controls.Add(this.pictureBoxIzq, 0, 0);
            this.tableLayoutPanelDecoracion.Controls.Add(this.tableLayoutPanelContenedor, 1, 0);
            this.tableLayoutPanelDecoracion.Controls.Add(this.pictureBoxDer, 2, 0);
            this.tableLayoutPanelDecoracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDecoracion.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDecoracion.Name = "tableLayoutPanelDecoracion";
            this.tableLayoutPanelDecoracion.RowCount = 1;
            this.tableLayoutPanelDecoracion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDecoracion.Size = new System.Drawing.Size(1473, 667);
            this.tableLayoutPanelDecoracion.TabIndex = 2;
            // 
            // pictureBoxIzq
            // 
            this.pictureBoxIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIzq.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIzq.Name = "pictureBoxIzq";
            this.pictureBoxIzq.Size = new System.Drawing.Size(362, 661);
            this.pictureBoxIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIzq.TabIndex = 16;
            this.pictureBoxIzq.TabStop = false;
            // 
            // pictureBoxDer
            // 
            this.pictureBoxDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDer.Location = new System.Drawing.Point(1107, 3);
            this.pictureBoxDer.Name = "pictureBoxDer";
            this.pictureBoxDer.Size = new System.Drawing.Size(363, 661);
            this.pictureBoxDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDer.TabIndex = 17;
            this.pictureBoxDer.TabStop = false;
            // 
            // Dificultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1473, 667);
            this.Controls.Add(this.tableLayoutPanelDecoracion);
            this.Name = "Dificultad";
            this.Text = "Memory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelContenedor.ResumeLayout(false);
            this.tableLayoutPanelContenedor.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelDecoracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDecoracion;
        private System.Windows.Forms.PictureBox pictureBoxIzq;
        private System.Windows.Forms.PictureBox pictureBoxDer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonNumeros;
        private System.Windows.Forms.RadioButton radioButtonAnimales;
        private System.Windows.Forms.RadioButton radioButtonColores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

