namespace UserInterface
{
    partial class MenuPrincipalUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonAddButton = new System.Windows.Forms.Button();
            this.buttonViewBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(393, 638);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(301, 115);
            this.buttonQuit.TabIndex = 0;
            this.buttonQuit.Text = "Salir";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.mainButton_Click);
            this.buttonQuit.Enter += new System.EventHandler(this.mainButton_Enter);
            this.buttonQuit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainButton_MouseClick);
            this.buttonQuit.MouseHover += new System.EventHandler(this.mainButton_MouseHover);
            // 
            // buttonAddButton
            // 
            this.buttonAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddButton.Location = new System.Drawing.Point(393, 84);
            this.buttonAddButton.Name = "buttonAddButton";
            this.buttonAddButton.Size = new System.Drawing.Size(313, 80);
            this.buttonAddButton.TabIndex = 1;
            this.buttonAddButton.Text = "Agregar Libro";
            this.buttonAddButton.UseVisualStyleBackColor = true;
            this.buttonAddButton.Click += new System.EventHandler(this.buttonAddButton_Click);
            // 
            // buttonViewBooks
            // 
            this.buttonViewBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewBooks.Location = new System.Drawing.Point(393, 334);
            this.buttonViewBooks.Name = "buttonViewBooks";
            this.buttonViewBooks.Size = new System.Drawing.Size(323, 91);
            this.buttonViewBooks.TabIndex = 2;
            this.buttonViewBooks.Text = "Ver libros";
            this.buttonViewBooks.UseVisualStyleBackColor = true;
            this.buttonViewBooks.Click += new System.EventHandler(this.buttonViewBooks_Click);
            // 
            // MenuPrincipalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonViewBooks);
            this.Controls.Add(this.buttonAddButton);
            this.Controls.Add(this.buttonQuit);
            this.Name = "MenuPrincipalUserControl";
            this.Size = new System.Drawing.Size(1074, 860);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonAddButton;
        private System.Windows.Forms.Button buttonViewBooks;
    }
}
