namespace NMS_Mbin_editor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trv_Mbins = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpB_properties = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_libMBINType = new System.Windows.Forms.Label();
            this.lbl_MbinRelativePath = new System.Windows.Forms.Label();
            this.lbl_VarName = new System.Windows.Forms.Label();
            this.lbl_varType = new System.Windows.Forms.Label();
            this.txtB_values = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpB_properties.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(752, 491);
            this.splitContainer1.SplitterDistance = 416;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.trv_Mbins, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(414, 489);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // trv_Mbins
            // 
            this.trv_Mbins.AllowDrop = true;
            this.trv_Mbins.BackColor = System.Drawing.Color.Black;
            this.trv_Mbins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_Mbins.ForeColor = System.Drawing.Color.White;
            this.trv_Mbins.Location = new System.Drawing.Point(11, 11);
            this.trv_Mbins.Name = "trv_Mbins";
            this.trv_Mbins.Size = new System.Drawing.Size(392, 467);
            this.trv_Mbins.TabIndex = 0;
            this.trv_Mbins.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_Mbins_AfterSelect);
            this.trv_Mbins.DragDrop += new System.Windows.Forms.DragEventHandler(this.trv_Mbins_DragDrop);
            this.trv_Mbins.DragEnter += new System.Windows.Forms.DragEventHandler(this.trv_Mbins_DragEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtB_values, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 489);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer2.Location = new System.Drawing.Point(11, 11);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpB_properties);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbl_libMBINType);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_MbinRelativePath);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_VarName);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_varType);
            this.splitContainer2.Size = new System.Drawing.Size(308, 127);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.TabIndex = 5;
            // 
            // grpB_properties
            // 
            this.grpB_properties.Controls.Add(this.label1);
            this.grpB_properties.Controls.Add(this.label2);
            this.grpB_properties.Controls.Add(this.label3);
            this.grpB_properties.Controls.Add(this.label4);
            this.grpB_properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpB_properties.Location = new System.Drawing.Point(0, 0);
            this.grpB_properties.Name = "grpB_properties";
            this.grpB_properties.Size = new System.Drawing.Size(110, 127);
            this.grpB_properties.TabIndex = 0;
            this.grpB_properties.TabStop = false;
            this.grpB_properties.Text = "Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "libMBIN Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MBIN Relative Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Variable Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Variable Type";
            // 
            // lbl_libMBINType
            // 
            this.lbl_libMBINType.AutoSize = true;
            this.lbl_libMBINType.Location = new System.Drawing.Point(2, 16);
            this.lbl_libMBINType.Name = "lbl_libMBINType";
            this.lbl_libMBINType.Size = new System.Drawing.Size(71, 13);
            this.lbl_libMBINType.TabIndex = 4;
            this.lbl_libMBINType.Text = "libMBIN Type";
            // 
            // lbl_MbinRelativePath
            // 
            this.lbl_MbinRelativePath.AutoSize = true;
            this.lbl_MbinRelativePath.Location = new System.Drawing.Point(2, 38);
            this.lbl_MbinRelativePath.Name = "lbl_MbinRelativePath";
            this.lbl_MbinRelativePath.Size = new System.Drawing.Size(101, 13);
            this.lbl_MbinRelativePath.TabIndex = 0;
            this.lbl_MbinRelativePath.Text = "MBIN Relative Path";
            // 
            // lbl_VarName
            // 
            this.lbl_VarName.AutoSize = true;
            this.lbl_VarName.Location = new System.Drawing.Point(2, 60);
            this.lbl_VarName.Name = "lbl_VarName";
            this.lbl_VarName.Size = new System.Drawing.Size(76, 13);
            this.lbl_VarName.TabIndex = 1;
            this.lbl_VarName.Text = "Variable Name";
            // 
            // lbl_varType
            // 
            this.lbl_varType.AutoSize = true;
            this.lbl_varType.Location = new System.Drawing.Point(2, 83);
            this.lbl_varType.Name = "lbl_varType";
            this.lbl_varType.Size = new System.Drawing.Size(72, 13);
            this.lbl_varType.TabIndex = 2;
            this.lbl_varType.Text = "Variable Type";
            // 
            // txtB_values
            // 
            this.txtB_values.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtB_values.Location = new System.Drawing.Point(11, 144);
            this.txtB_values.Multiline = true;
            this.txtB_values.Name = "txtB_values";
            this.txtB_values.Size = new System.Drawing.Size(308, 334);
            this.txtB_values.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 491);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grpB_properties.ResumeLayout(false);
            this.grpB_properties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trv_Mbins;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpB_properties;
        private System.Windows.Forms.Label lbl_MbinRelativePath;
        private System.Windows.Forms.Label lbl_varType;
        private System.Windows.Forms.Label lbl_VarName;
        private System.Windows.Forms.Label lbl_libMBINType;
        private System.Windows.Forms.TextBox txtB_values;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

