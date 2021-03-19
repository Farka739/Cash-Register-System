﻿
namespace ModernFlatUI
{
    partial class ProductList
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
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnOpenTheDescription = new System.Windows.Forms.Button();
            this.btnBackToDefine = new System.Windows.Forms.Button();
            this.btnChangeTheInfo = new System.Windows.Forms.Button();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvPrice,
            this.dgvQuantity,
            this.dgvDescription});
            this.dgvProductList.Location = new System.Drawing.Point(79, 49);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(70, 40, 70, 40);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.Size = new System.Drawing.Size(855, 402);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellEndEdit);
            // 
            // btnOpenTheDescription
            // 
            this.btnOpenTheDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTheDescription.Location = new System.Drawing.Point(911, 52);
            this.btnOpenTheDescription.MaximumSize = new System.Drawing.Size(21, 21);
            this.btnOpenTheDescription.MinimumSize = new System.Drawing.Size(21, 21);
            this.btnOpenTheDescription.Name = "btnOpenTheDescription";
            this.btnOpenTheDescription.Size = new System.Drawing.Size(21, 21);
            this.btnOpenTheDescription.TabIndex = 1;
            this.btnOpenTheDescription.UseVisualStyleBackColor = true;
            this.btnOpenTheDescription.Click += new System.EventHandler(this.btnOpenTheDescription_Click);
            // 
            // btnBackToDefine
            // 
            this.btnBackToDefine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDefine.Location = new System.Drawing.Point(784, 494);
            this.btnBackToDefine.Margin = new System.Windows.Forms.Padding(3, 3, 70, 40);
            this.btnBackToDefine.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnBackToDefine.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnBackToDefine.Name = "btnBackToDefine";
            this.btnBackToDefine.Size = new System.Drawing.Size(150, 40);
            this.btnBackToDefine.TabIndex = 7;
            this.btnBackToDefine.Text = "Add New Item";
            this.btnBackToDefine.UseVisualStyleBackColor = true;
            this.btnBackToDefine.Click += new System.EventHandler(this.btnBackToDefine_Click);
            // 
            // btnChangeTheInfo
            // 
            this.btnChangeTheInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeTheInfo.Location = new System.Drawing.Point(578, 494);
            this.btnChangeTheInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.btnChangeTheInfo.MaximumSize = new System.Drawing.Size(200, 40);
            this.btnChangeTheInfo.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnChangeTheInfo.Name = "btnChangeTheInfo";
            this.btnChangeTheInfo.Size = new System.Drawing.Size(200, 40);
            this.btnChangeTheInfo.TabIndex = 8;
            this.btnChangeTheInfo.Text = "Change The Product Info";
            this.btnChangeTheInfo.UseVisualStyleBackColor = true;
            this.btnChangeTheInfo.Click += new System.EventHandler(this.btnChangeTheInfo_Click);
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvName.FillWeight = 104.8128F;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvName.Width = 200;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 85.5615F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 6;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvPrice.Width = 70;
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQuantity.FillWeight = 104.8128F;
            this.dgvQuantity.HeaderText = "Quantity";
            this.dgvQuantity.MinimumWidth = 6;
            this.dgvQuantity.Name = "dgvQuantity";
            this.dgvQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvQuantity.Width = 70;
            // 
            // dgvDescription
            // 
            this.dgvDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDescription.FillWeight = 104.8128F;
            this.dgvDescription.HeaderText = "Description";
            this.dgvDescription.MinimumWidth = 6;
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 583);
            this.Controls.Add(this.btnChangeTheInfo);
            this.Controls.Add(this.btnBackToDefine);
            this.Controls.Add(this.btnOpenTheDescription);
            this.Controls.Add(this.dgvProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnOpenTheDescription;
        private System.Windows.Forms.Button btnBackToDefine;
        private System.Windows.Forms.Button btnChangeTheInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
    }
}