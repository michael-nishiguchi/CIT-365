namespace MegaDesk_Nishiguchi {
    partial class AddQuote {
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
            this.backToMain = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerNumberLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.drawerNumberInput = new System.Windows.Forms.ComboBox();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.shippingDaysInput = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMain
            // 
            this.backToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backToMain.Location = new System.Drawing.Point(588, 363);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(200, 75);
            this.backToMain.TabIndex = 0;
            this.backToMain.Text = "Back to Main Menu";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerNameLabel.Location = new System.Drawing.Point(12, 62);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(124, 20);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerNameBox.Location = new System.Drawing.Point(202, 64);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(173, 26);
            this.customerNameBox.TabIndex = 2;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.widthLabel.Location = new System.Drawing.Point(12, 113);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(142, 20);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Desk Width(24-96)";
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.widthInput.Location = new System.Drawing.Point(202, 115);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(173, 26);
            this.widthInput.TabIndex = 4;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depthInput.Location = new System.Drawing.Point(202, 159);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(173, 26);
            this.depthInput.TabIndex = 6;
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.depthInput_Validating);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.depthLabel.Location = new System.Drawing.Point(12, 159);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(145, 20);
            this.depthLabel.TabIndex = 5;
            this.depthLabel.Text = "Desk Depth(12-48)";
            // 
            // drawerNumberLabel
            // 
            this.drawerNumberLabel.AutoSize = true;
            this.drawerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drawerNumberLabel.Location = new System.Drawing.Point(454, 62);
            this.drawerNumberLabel.Name = "drawerNumberLabel";
            this.drawerNumberLabel.Size = new System.Drawing.Size(183, 20);
            this.drawerNumberLabel.TabIndex = 8;
            this.drawerNumberLabel.Text = "Number of Drawers (0-7)";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialLabel.Location = new System.Drawing.Point(454, 113);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(125, 20);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Surface Material";
            // 
            // materialInput
            // 
            this.materialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialInput.Location = new System.Drawing.Point(667, 115);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(121, 28);
            this.materialInput.TabIndex = 10;
            // 
            // drawerNumberInput
            // 
            this.drawerNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drawerNumberInput.FormattingEnabled = true;
            this.drawerNumberInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerNumberInput.Location = new System.Drawing.Point(667, 64);
            this.drawerNumberInput.Name = "drawerNumberInput";
            this.drawerNumberInput.Size = new System.Drawing.Size(121, 28);
            this.drawerNumberInput.TabIndex = 11;
            this.drawerNumberInput.Text = "0";
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rushOrderLabel.Location = new System.Drawing.Point(454, 159);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(91, 20);
            this.rushOrderLabel.TabIndex = 12;
            this.rushOrderLabel.Text = "Rush Order";
            // 
            // shippingDaysInput
            // 
            this.shippingDaysInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shippingDaysInput.FormattingEnabled = true;
            this.shippingDaysInput.Items.AddRange(new object[] {
            "14",
            "7",
            "5",
            "3"});
            this.shippingDaysInput.Location = new System.Drawing.Point(667, 161);
            this.shippingDaysInput.Name = "shippingDaysInput";
            this.shippingDaysInput.Size = new System.Drawing.Size(121, 28);
            this.shippingDaysInput.TabIndex = 13;
            this.shippingDaysInput.Text = "14";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.Location = new System.Drawing.Point(12, 363);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(200, 75);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.shippingDaysInput);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.drawerNumberInput);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.drawerNumberLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.backToMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMain;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawerNumberLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.ComboBox drawerNumberInput;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.ComboBox shippingDaysInput;
        private System.Windows.Forms.Button submit;
    }
}