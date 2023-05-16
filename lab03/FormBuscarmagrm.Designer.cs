namespace lab03
{
    partial class FormBuscarmagrm
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
            this.pictureBoxscreen = new System.Windows.Forms.PictureBox();
            this.openFileDialogbuscar = new System.Windows.Forms.OpenFileDialog();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxscreen
            // 
            this.pictureBoxscreen.Location = new System.Drawing.Point(27, -1);
            this.pictureBoxscreen.Name = "pictureBoxscreen";
            this.pictureBoxscreen.Size = new System.Drawing.Size(750, 316);
            this.pictureBoxscreen.TabIndex = 0;
            this.pictureBoxscreen.TabStop = false;
            // 
            // openFileDialogbuscar
            // 
            this.openFileDialogbuscar.FileName = "openFileDialogbuscar";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(301, 321);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(196, 40);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // FormBuscarmagrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pictureBoxscreen);
            this.MaximizeBox = false;
            this.Name = "FormBuscarmagrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxscreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxscreen;
        private OpenFileDialog openFileDialogbuscar;
        private Button btn1;
    }
}