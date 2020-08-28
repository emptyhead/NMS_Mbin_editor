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
            this.layout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.trv_Mbins = new System.Windows.Forms.TreeView();
            this.layout_upperRight = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_MbinRelativePath = new System.Windows.Forms.Label();
            this.lbl_VarName = new System.Windows.Forms.Label();
            this.lbl_varType = new System.Windows.Forms.Label();
            this.txtB_values = new System.Windows.Forms.TextBox();
            this.lbl_libMBINType = new System.Windows.Forms.Label();
            this.layout_Main.SuspendLayout();
            this.layout_upperRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_Main
            // 
            this.layout_Main.ColumnCount = 2;
            this.layout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layout_Main.Controls.Add(this.trv_Mbins, 0, 0);
            this.layout_Main.Controls.Add(this.layout_upperRight, 1, 0);
            this.layout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Main.Location = new System.Drawing.Point(0, 0);
            this.layout_Main.Name = "layout_Main";
            this.layout_Main.RowCount = 2;
            this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.layout_Main.Size = new System.Drawing.Size(637, 491);
            this.layout_Main.TabIndex = 0;
            // 
            // trv_Mbins
            // 
            this.trv_Mbins.AllowDrop = true;
            this.trv_Mbins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_Mbins.Location = new System.Drawing.Point(3, 3);
            this.trv_Mbins.Name = "trv_Mbins";
            this.trv_Mbins.Size = new System.Drawing.Size(376, 346);
            this.trv_Mbins.TabIndex = 0;
            this.trv_Mbins.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_Mbins_AfterSelect);
            this.trv_Mbins.DragDrop += new System.Windows.Forms.DragEventHandler(this.trv_Mbins_DragDrop);
            this.trv_Mbins.DragEnter += new System.Windows.Forms.DragEventHandler(this.trv_Mbins_DragEnter);
            // 
            // layout_upperRight
            // 
            this.layout_upperRight.ColumnCount = 1;
            this.layout_upperRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_upperRight.Controls.Add(this.lbl_MbinRelativePath, 0, 0);
            this.layout_upperRight.Controls.Add(this.txtB_values, 0, 4);
            this.layout_upperRight.Controls.Add(this.lbl_VarName, 0, 3);
            this.layout_upperRight.Controls.Add(this.lbl_varType, 0, 2);
            this.layout_upperRight.Controls.Add(this.lbl_libMBINType, 0, 1);
            this.layout_upperRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_upperRight.Location = new System.Drawing.Point(385, 3);
            this.layout_upperRight.Name = "layout_upperRight";
            this.layout_upperRight.RowCount = 5;
            this.layout_upperRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_upperRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_upperRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_upperRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_upperRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.layout_upperRight.Size = new System.Drawing.Size(249, 346);
            this.layout_upperRight.TabIndex = 1;
            // 
            // lbl_MbinRelativePath
            // 
            this.lbl_MbinRelativePath.AutoSize = true;
            this.lbl_MbinRelativePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_MbinRelativePath.Location = new System.Drawing.Point(3, 0);
            this.lbl_MbinRelativePath.Name = "lbl_MbinRelativePath";
            this.lbl_MbinRelativePath.Size = new System.Drawing.Size(243, 20);
            this.lbl_MbinRelativePath.TabIndex = 0;
            this.lbl_MbinRelativePath.Text = "MBIN Relative Path";
            // 
            // lbl_VarName
            // 
            this.lbl_VarName.AutoSize = true;
            this.lbl_VarName.Location = new System.Drawing.Point(3, 60);
            this.lbl_VarName.Name = "lbl_VarName";
            this.lbl_VarName.Size = new System.Drawing.Size(76, 13);
            this.lbl_VarName.TabIndex = 1;
            this.lbl_VarName.Text = "Variable Name";
            // 
            // lbl_varType
            // 
            this.lbl_varType.AutoSize = true;
            this.lbl_varType.Location = new System.Drawing.Point(3, 40);
            this.lbl_varType.Name = "lbl_varType";
            this.lbl_varType.Size = new System.Drawing.Size(72, 13);
            this.lbl_varType.TabIndex = 2;
            this.lbl_varType.Text = "Variable Type";
            // 
            // txtB_values
            // 
            this.txtB_values.Location = new System.Drawing.Point(3, 83);
            this.txtB_values.Multiline = true;
            this.txtB_values.Name = "txtB_values";
            this.txtB_values.Size = new System.Drawing.Size(243, 118);
            this.txtB_values.TabIndex = 3;
            // 
            // lbl_libMBINType
            // 
            this.lbl_libMBINType.AutoSize = true;
            this.lbl_libMBINType.Location = new System.Drawing.Point(3, 20);
            this.lbl_libMBINType.Name = "lbl_libMBINType";
            this.lbl_libMBINType.Size = new System.Drawing.Size(71, 13);
            this.lbl_libMBINType.TabIndex = 4;
            this.lbl_libMBINType.Text = "libMBIN Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 491);
            this.Controls.Add(this.layout_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.layout_Main.ResumeLayout(false);
            this.layout_upperRight.ResumeLayout(false);
            this.layout_upperRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_Main;
        private System.Windows.Forms.TreeView trv_Mbins;
        private System.Windows.Forms.TableLayoutPanel layout_upperRight;
        private System.Windows.Forms.Label lbl_MbinRelativePath;
        private System.Windows.Forms.Label lbl_VarName;
        private System.Windows.Forms.Label lbl_varType;
        private System.Windows.Forms.TextBox txtB_values;
        private System.Windows.Forms.Label lbl_libMBINType;
    }
}

