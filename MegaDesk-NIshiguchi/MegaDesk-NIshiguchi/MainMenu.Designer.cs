namespace MegaDesk_Nishiguchi {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuoteButton = new System.Windows.Forms.Button();
            this.SearchQuoteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Location = new System.Drawing.Point(41, 64);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(200, 75);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "Add Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // ViewQuoteButton
            // 
            this.ViewQuoteButton.Location = new System.Drawing.Point(41, 185);
            this.ViewQuoteButton.Name = "ViewQuoteButton";
            this.ViewQuoteButton.Size = new System.Drawing.Size(200, 75);
            this.ViewQuoteButton.TabIndex = 1;
            this.ViewQuoteButton.Text = "View Quote";
            this.ViewQuoteButton.UseVisualStyleBackColor = true;
            this.ViewQuoteButton.Click += new System.EventHandler(this.ViewQuoteButton_Click);
            // 
            // SearchQuoteButton
            // 
            this.SearchQuoteButton.Location = new System.Drawing.Point(41, 319);
            this.SearchQuoteButton.Name = "SearchQuoteButton";
            this.SearchQuoteButton.Size = new System.Drawing.Size(200, 75);
            this.SearchQuoteButton.TabIndex = 2;
            this.SearchQuoteButton.Text = "Search";
            this.SearchQuoteButton.UseVisualStyleBackColor = true;
            this.SearchQuoteButton.Click += new System.EventHandler(this.SearchQuoteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(528, 319);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 75);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuoteButton);
            this.Controls.Add(this.ViewQuoteButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button ViewQuoteButton;
        private System.Windows.Forms.Button SearchQuoteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

