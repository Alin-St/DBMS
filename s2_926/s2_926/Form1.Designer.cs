namespace s2_926
{
    partial class Form1
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
            this.locationsDGV = new System.Windows.Forms.DataGridView();
            this.festivalsDGV = new System.Windows.Forms.DataGridView();
            this.recordNameTB = new System.Windows.Forms.TextBox();
            this.recordNameL = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.locationsL = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.festivalsL = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.saveChangesB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.locationsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festivalsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // locationsDGV
            // 
            this.locationsDGV.AllowUserToAddRows = false;
            this.locationsDGV.AllowUserToDeleteRows = false;
            this.locationsDGV.AllowUserToOrderColumns = true;
            this.locationsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationsDGV.Location = new System.Drawing.Point(2, 32);
            this.locationsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.locationsDGV.MultiSelect = false;
            this.locationsDGV.Name = "locationsDGV";
            this.locationsDGV.ReadOnly = true;
            this.locationsDGV.RowHeadersWidth = 51;
            this.locationsDGV.RowTemplate.Height = 24;
            this.locationsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.locationsDGV.Size = new System.Drawing.Size(489, 539);
            this.locationsDGV.TabIndex = 0;
            // 
            // festivalsDGV
            // 
            this.festivalsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.festivalsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.festivalsDGV.Location = new System.Drawing.Point(2, 32);
            this.festivalsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.festivalsDGV.MultiSelect = false;
            this.festivalsDGV.Name = "festivalsDGV";
            this.festivalsDGV.RowHeadersWidth = 51;
            this.festivalsDGV.RowTemplate.Height = 24;
            this.festivalsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.festivalsDGV.Size = new System.Drawing.Size(553, 502);
            this.festivalsDGV.TabIndex = 1;
            this.festivalsDGV.SelectionChanged += new System.EventHandler(this.FestivalsDGV_SelectionChanged);
            // 
            // recordNameTB
            // 
            this.recordNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.recordNameTB.Location = new System.Drawing.Point(91, 2);
            this.recordNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.recordNameTB.Name = "recordNameTB";
            this.recordNameTB.ReadOnly = true;
            this.recordNameTB.Size = new System.Drawing.Size(458, 27);
            this.recordNameTB.TabIndex = 4;
            // 
            // recordNameL
            // 
            this.recordNameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recordNameL.AutoSize = true;
            this.recordNameL.Location = new System.Drawing.Point(2, 5);
            this.recordNameL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recordNameL.Name = "recordNameL";
            this.recordNameL.Size = new System.Drawing.Size(85, 20);
            this.recordNameL.TabIndex = 5;
            this.recordNameL.Text = "Record 0/0:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 573);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.locationsDGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.locationsL, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // locationsL
            // 
            this.locationsL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.locationsL.AutoSize = true;
            this.locationsL.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationsL.Location = new System.Drawing.Point(3, 0);
            this.locationsL.Name = "locationsL";
            this.locationsL.Size = new System.Drawing.Size(104, 30);
            this.locationsL.TabIndex = 1;
            this.locationsL.Text = "Locations";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.festivalsDGV, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 573);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.recordNameL, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.recordNameTB, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 539);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(551, 31);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // festivalsL
            // 
            this.festivalsL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.festivalsL.AutoSize = true;
            this.festivalsL.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.festivalsL.Location = new System.Drawing.Point(3, 0);
            this.festivalsL.Name = "festivalsL";
            this.festivalsL.Size = new System.Drawing.Size(93, 30);
            this.festivalsL.TabIndex = 2;
            this.festivalsL.Text = "Festivals";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.festivalsL, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.saveChangesB, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(557, 30);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // saveChangesB
            // 
            this.saveChangesB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveChangesB.AutoSize = true;
            this.saveChangesB.Location = new System.Drawing.Point(444, 0);
            this.saveChangesB.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.saveChangesB.Name = "saveChangesB";
            this.saveChangesB.Size = new System.Drawing.Size(110, 30);
            this.saveChangesB.TabIndex = 3;
            this.saveChangesB.Text = "Save Changes";
            this.saveChangesB.UseVisualStyleBackColor = true;
            this.saveChangesB.Click += new System.EventHandler(this.SaveChanges);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 605);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "Festivals Management App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveChanges);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.locationsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festivalsDGV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView locationsDGV;
        private System.Windows.Forms.DataGridView festivalsDGV;
        private System.Windows.Forms.TextBox recordNameTB;
        private System.Windows.Forms.Label recordNameL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label locationsL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label festivalsL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button saveChangesB;
    }
}

