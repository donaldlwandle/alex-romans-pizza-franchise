namespace Alexandra_romans_pizza
{
    partial class OrderForm
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemPrizeLabel = new System.Windows.Forms.Label();
            this.firstOptionLabel = new System.Windows.Forms.Label();
            this.secondOptionLabel = new System.Windows.Forms.Label();
            this.addToBagButton = new System.Windows.Forms.Button();
            this.firstOptionBox = new System.Windows.Forms.ComboBox();
            this.secondOptionBox = new System.Windows.Forms.ComboBox();
            this.quantityBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(631, 85);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(389, 86);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Meal  Name";
            // 
            // itemPrizeLabel
            // 
            this.itemPrizeLabel.AutoSize = true;
            this.itemPrizeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrizeLabel.Location = new System.Drawing.Point(642, 183);
            this.itemPrizeLabel.Name = "itemPrizeLabel";
            this.itemPrizeLabel.Size = new System.Drawing.Size(78, 40);
            this.itemPrizeLabel.TabIndex = 2;
            this.itemPrizeLabel.Text = "R 68";
            // 
            // firstOptionLabel
            // 
            this.firstOptionLabel.AutoSize = true;
            this.firstOptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstOptionLabel.Location = new System.Drawing.Point(652, 302);
            this.firstOptionLabel.Name = "firstOptionLabel";
            this.firstOptionLabel.Size = new System.Drawing.Size(77, 17);
            this.firstOptionLabel.TabIndex = 3;
            this.firstOptionLabel.Text = "first Option";
            // 
            // secondOptionLabel
            // 
            this.secondOptionLabel.AutoSize = true;
            this.secondOptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondOptionLabel.Location = new System.Drawing.Point(652, 352);
            this.secondOptionLabel.Name = "secondOptionLabel";
            this.secondOptionLabel.Size = new System.Drawing.Size(97, 17);
            this.secondOptionLabel.TabIndex = 4;
            this.secondOptionLabel.Text = "second Option";
            // 
            // addToBagButton
            // 
            this.addToBagButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addToBagButton.FlatAppearance.BorderSize = 0;
            this.addToBagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToBagButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBagButton.Location = new System.Drawing.Point(787, 488);
            this.addToBagButton.Name = "addToBagButton";
            this.addToBagButton.Size = new System.Drawing.Size(153, 39);
            this.addToBagButton.TabIndex = 5;
            this.addToBagButton.Text = "Add to bag";
            this.addToBagButton.UseVisualStyleBackColor = false;
            this.addToBagButton.Click += new System.EventHandler(this.addToBagButton_Click);
            // 
            // firstOptionBox
            // 
            this.firstOptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.firstOptionBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstOptionBox.ForeColor = System.Drawing.SystemColors.Window;
            this.firstOptionBox.FormattingEnabled = true;
            this.firstOptionBox.Location = new System.Drawing.Point(768, 294);
            this.firstOptionBox.Name = "firstOptionBox";
            this.firstOptionBox.Size = new System.Drawing.Size(172, 25);
            this.firstOptionBox.TabIndex = 6;
            this.firstOptionBox.SelectedIndexChanged += new System.EventHandler(this.firstOptionBox_SelectedIndexChanged);
            // 
            // secondOptionBox
            // 
            this.secondOptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.secondOptionBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondOptionBox.ForeColor = System.Drawing.SystemColors.Window;
            this.secondOptionBox.FormattingEnabled = true;
            this.secondOptionBox.Location = new System.Drawing.Point(768, 344);
            this.secondOptionBox.Name = "secondOptionBox";
            this.secondOptionBox.Size = new System.Drawing.Size(172, 25);
            this.secondOptionBox.TabIndex = 7;
            this.secondOptionBox.SelectedIndexChanged += new System.EventHandler(this.secondOptionBox_SelectedIndexChanged);
            // 
            // quantityBox
            // 
            this.quantityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.quantityBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.quantityBox.FormattingEnabled = true;
            this.quantityBox.Location = new System.Drawing.Point(768, 393);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(172, 25);
            this.quantityBox.TabIndex = 11;
            this.quantityBox.SelectedIndexChanged += new System.EventHandler(this.quantityBox_SelectedIndexChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(652, 401);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Quantity";
            // 
            // itemPicture
            // 
            this.itemPicture.Location = new System.Drawing.Point(57, 103);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Size = new System.Drawing.Size(473, 424);
            this.itemPicture.TabIndex = 12;
            this.itemPicture.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::Alexandra_romans_pizza.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(1039, 22);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(15, 15);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 13;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1081, 586);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.itemPicture);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.secondOptionBox);
            this.Controls.Add(this.firstOptionBox);
            this.Controls.Add(this.addToBagButton);
            this.Controls.Add(this.secondOptionLabel);
            this.Controls.Add(this.firstOptionLabel);
            this.Controls.Add(this.itemPrizeLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Romans Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemPrizeLabel;
        private System.Windows.Forms.Label firstOptionLabel;
        private System.Windows.Forms.Label secondOptionLabel;
        private System.Windows.Forms.Button addToBagButton;
        private System.Windows.Forms.ComboBox firstOptionBox;
        private System.Windows.Forms.ComboBox secondOptionBox;
        private System.Windows.Forms.ComboBox quantityBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}