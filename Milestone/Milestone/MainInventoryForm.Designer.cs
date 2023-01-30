namespace Milestone
{
    partial class MainInventoryForm
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
            this.title = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.reorderItemButton = new System.Windows.Forms.Button();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.sortAZButton = new System.Windows.Forms.Button();
            this.sortPriceButton = new System.Windows.Forms.Button();
            this.sortQuantityButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sortIDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(316, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(144, 33);
            this.title.TabIndex = 0;
            this.title.Text = "Inventory";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemButton.Location = new System.Drawing.Point(479, 536);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(138, 75);
            this.addItemButton.TabIndex = 9;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.editItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editItemButton.Location = new System.Drawing.Point(325, 536);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(138, 75);
            this.editItemButton.TabIndex = 8;
            this.editItemButton.Text = "Edit";
            this.editItemButton.UseVisualStyleBackColor = false;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // reorderItemButton
            // 
            this.reorderItemButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.reorderItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reorderItemButton.Location = new System.Drawing.Point(12, 536);
            this.reorderItemButton.Name = "reorderItemButton";
            this.reorderItemButton.Size = new System.Drawing.Size(138, 75);
            this.reorderItemButton.TabIndex = 6;
            this.reorderItemButton.Text = "Order";
            this.reorderItemButton.UseVisualStyleBackColor = false;
            this.reorderItemButton.Click += new System.EventHandler(this.reorderItemButton_Click);
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inventoryListBox.ColumnWidth = 20;
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.HorizontalScrollbar = true;
            this.inventoryListBox.ItemHeight = 25;
            this.inventoryListBox.Location = new System.Drawing.Point(101, 117);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.ScrollAlwaysVisible = true;
            this.inventoryListBox.Size = new System.Drawing.Size(583, 404);
            this.inventoryListBox.TabIndex = 5;
            this.inventoryListBox.Tag = "";
            // 
            // sortAZButton
            // 
            this.sortAZButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sortAZButton.Location = new System.Drawing.Point(246, 82);
            this.sortAZButton.Name = "sortAZButton";
            this.sortAZButton.Size = new System.Drawing.Size(145, 36);
            this.sortAZButton.TabIndex = 2;
            this.sortAZButton.Text = "Sort A-Z";
            this.sortAZButton.UseVisualStyleBackColor = false;
            this.sortAZButton.Click += new System.EventHandler(this.sortAZButton_Click);
            // 
            // sortPriceButton
            // 
            this.sortPriceButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sortPriceButton.Location = new System.Drawing.Point(392, 82);
            this.sortPriceButton.Name = "sortPriceButton";
            this.sortPriceButton.Size = new System.Drawing.Size(145, 36);
            this.sortPriceButton.TabIndex = 3;
            this.sortPriceButton.Text = "Sort Price";
            this.sortPriceButton.UseVisualStyleBackColor = false;
            this.sortPriceButton.Click += new System.EventHandler(this.sortPriceButton_Click);
            // 
            // sortQuantityButton
            // 
            this.sortQuantityButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sortQuantityButton.Location = new System.Drawing.Point(538, 82);
            this.sortQuantityButton.Name = "sortQuantityButton";
            this.sortQuantityButton.Size = new System.Drawing.Size(145, 36);
            this.sortQuantityButton.TabIndex = 4;
            this.sortQuantityButton.Text = "Sort Quantity";
            this.sortQuantityButton.UseVisualStyleBackColor = false;
            this.sortQuantityButton.Click += new System.EventHandler(this.sortQuantityButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(103, 51);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(460, 31);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchButton.Location = new System.Drawing.Point(562, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 33);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeItemButton.Location = new System.Drawing.Point(168, 536);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(138, 75);
            this.removeItemButton.TabIndex = 7;
            this.removeItemButton.Text = "Remove";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(634, 536);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 75);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sortIDButton
            // 
            this.sortIDButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sortIDButton.Location = new System.Drawing.Point(100, 82);
            this.sortIDButton.Name = "sortIDButton";
            this.sortIDButton.Size = new System.Drawing.Size(145, 36);
            this.sortIDButton.TabIndex = 11;
            this.sortIDButton.Text = "Sort ID";
            this.sortIDButton.UseVisualStyleBackColor = false;
            this.sortIDButton.Click += new System.EventHandler(this.sortIDButton_Click);
            // 
            // MainInventoryForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(784, 623);
            this.Controls.Add(this.sortIDButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sortQuantityButton);
            this.Controls.Add(this.sortPriceButton);
            this.Controls.Add(this.sortAZButton);
            this.Controls.Add(this.inventoryListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reorderItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button reorderItemButton;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Button sortAZButton;
        private System.Windows.Forms.Button sortPriceButton;
        private System.Windows.Forms.Button sortQuantityButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button sortIDButton;
    }
}

