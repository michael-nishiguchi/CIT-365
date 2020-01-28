namespace MegaDesk_Nishiguchi {
    partial class DisplayQuotes {
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
            this.addQuote = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Depth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurfaceArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addQuote.Location = new System.Drawing.Point(12, 363);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(200, 75);
            this.addQuote.TabIndex = 1;
            this.addQuote.Text = "Add New Quote";
            this.addQuote.UseVisualStyleBackColor = true;
            this.addQuote.Click += new System.EventHandler(this.addQuote_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Width,
            this.Depth,
            this.SurfaceArea,
            this.Material,
            this.ProductionTime});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 281);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Width
            // 
            this.Width.Text = "Width";
            this.Width.Width = 96;
            // 
            // Depth
            // 
            this.Depth.Text = "Depth";
            this.Depth.Width = 98;
            // 
            // SurfaceArea
            // 
            this.SurfaceArea.Text = "Surface Area";
            this.SurfaceArea.Width = 128;
            // 
            // Material
            // 
            this.Material.Text = "Material";
            this.Material.Width = 105;
            // 
            // ProductionTime
            // 
            this.ProductionTime.Text = "Production Time";
            this.ProductionTime.Width = 114;
            // 
            // backToMain
            // 
            this.backToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backToMain.Location = new System.Drawing.Point(588, 363);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(200, 75);
            this.backToMain.TabIndex = 3;
            this.backToMain.Text = "Back to Main Menu";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // DisplayQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMain);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.addQuote);
            this.Name = "DisplayQuotes";
            this.Text = "DisplayQuotes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Width;
        private System.Windows.Forms.ColumnHeader Depth;
        private System.Windows.Forms.ColumnHeader SurfaceArea;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader ProductionTime;
        private System.Windows.Forms.Button backToMain;
    }
}