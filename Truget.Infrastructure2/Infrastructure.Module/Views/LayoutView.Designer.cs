//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add Foundational Module" recipe.
//
// The LayoutView usercontrol defines a layout decoupled from the shell. 
// It provides a left and right workspace, menu bar, tool bar and status bar.
// These ui elements are added as extension sites.
//
// For more information see:
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.practices.scsf.2007may/SCSF/html/03-01-030-How_to_Create_a_Foundational_Module.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

namespace ACOT.Infrastructure.Module
{
    partial class LayoutView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutView));
            this._moduleWorkspace = new Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace();
            this._startdir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._selFolderBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showSplash = new System.Windows.Forms.CheckBox();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _moduleWorkspace
            // 
            this._moduleWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._moduleWorkspace.Location = new System.Drawing.Point(0, 0);
            this._moduleWorkspace.Name = "_moduleWorkspace";
            this._moduleWorkspace.Size = new System.Drawing.Size(469, 507);
            this._moduleWorkspace.TabIndex = 1;
            this._moduleWorkspace.Text = "_moduleWorkspace";
            // 
            // _startdir
            // 
            this._startdir.Location = new System.Drawing.Point(192, 19);
            this._startdir.Name = "_startdir";
            this._startdir.Size = new System.Drawing.Size(239, 20);
            this._startdir.TabIndex = 1;
            this._startdir.Leave += new System.EventHandler(this._startdir_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "���� � �������� ����:";
            // 
            // _selFolderBtn
            // 
            this._selFolderBtn.BackgroundImage = global::ACOT.Infrastructure.Module.Properties.Resources.Open_Folder;
            this._selFolderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._selFolderBtn.FlatAppearance.BorderSize = 0;
            this._selFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._selFolderBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._selFolderBtn.Location = new System.Drawing.Point(435, 18);
            this._selFolderBtn.Name = "_selFolderBtn";
            this._selFolderBtn.Size = new System.Drawing.Size(20, 20);
            this._selFolderBtn.TabIndex = 2;
            this._selFolderBtn.UseVisualStyleBackColor = true;
            this._selFolderBtn.Click += new System.EventHandler(this._selFolderBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 507);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._selFolderBtn);
            this.groupBox1.Controls.Add(this._startdir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // showSplash
            // 
            this.showSplash.AutoSize = true;
            this.showSplash.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showSplash.Checked = global::ACOT.Infrastructure.Module.Properties.Settings.Default.ShowSplash;
            this.showSplash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSplash.Location = new System.Drawing.Point(12, 482);
            this.showSplash.Name = "showSplash";
            this.showSplash.Size = new System.Drawing.Size(154, 17);
            this.showSplash.TabIndex = 4;
            this.showSplash.Text = "���������� ��� �������";
            this.showSplash.UseVisualStyleBackColor = true;
            this.showSplash.CheckedChanged += new System.EventHandler(this.showSplash_CheckedChanged);
            // 
            // _folderBrowserDialog
            // 
            this._folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this._folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(297, 476);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "&������";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(378, 476);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "�&����";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // LayoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.showSplash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._moduleWorkspace);
            this.Name = "LayoutView";
            this.Size = new System.Drawing.Size(469, 507);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace _moduleWorkspace;
        private System.Windows.Forms.TextBox _startdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _selFolderBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox showSplash;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;

    }
}
