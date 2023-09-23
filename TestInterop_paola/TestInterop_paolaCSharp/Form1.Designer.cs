namespace TestInterop_paolaCSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnGuardarExcel = new System.Windows.Forms.Button();
            this.bttnGuardarWord = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnGuardarExcel
            // 
            this.bttnGuardarExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnGuardarExcel.BackgroundImage")));
            this.bttnGuardarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnGuardarExcel.Location = new System.Drawing.Point(505, 226);
            this.bttnGuardarExcel.Name = "bttnGuardarExcel";
            this.bttnGuardarExcel.Size = new System.Drawing.Size(104, 91);
            this.bttnGuardarExcel.TabIndex = 11;
            this.bttnGuardarExcel.UseVisualStyleBackColor = true;
            this.bttnGuardarExcel.Click += new System.EventHandler(this.bttnGuardarExcel_Click);
            // 
            // bttnGuardarWord
            // 
            this.bttnGuardarWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnGuardarWord.BackgroundImage")));
            this.bttnGuardarWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnGuardarWord.Location = new System.Drawing.Point(385, 226);
            this.bttnGuardarWord.Name = "bttnGuardarWord";
            this.bttnGuardarWord.Size = new System.Drawing.Size(104, 91);
            this.bttnGuardarWord.TabIndex = 10;
            this.bttnGuardarWord.UseVisualStyleBackColor = true;
            this.bttnGuardarWord.Click += new System.EventHandler(this.bttnGuardarWord_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(360, 133);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(264, 29);
            this.TextBox1.TabIndex = 9;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(177, 135);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(177, 25);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Ingresa tu texto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnGuardarExcel);
            this.Controls.Add(this.bttnGuardarWord);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bttnGuardarExcel;
        internal System.Windows.Forms.Button bttnGuardarWord;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
    }
}

