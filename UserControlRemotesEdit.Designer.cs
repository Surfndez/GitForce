﻿namespace GitForce
{
    partial class RemotesEdit
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
            this.btRename = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userControlRemoteEdit = new RemoteEdit();
            this.listRemotes = new System.Windows.Forms.ListBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRename
            // 
            this.btRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRename.Enabled = false;
            this.btRename.Location = new System.Drawing.Point(168, 168);
            this.btRename.Name = "btRename";
            this.btRename.Size = new System.Drawing.Size(75, 23);
            this.btRename.TabIndex = 3;
            this.btRename.Text = "Rename";
            this.btRename.UseVisualStyleBackColor = true;
            this.btRename.Click += new System.EventHandler(this.BtRenameClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userControlRemoteEdit);
            this.groupBox2.Controls.Add(this.btRename);
            this.groupBox2.Controls.Add(this.listRemotes);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 197);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote repositories registered with a current repo";
            // 
            // _userControlRemoteEdit
            // 
            this.userControlRemoteEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlRemoteEdit.Location = new System.Drawing.Point(140, 19);
            this.userControlRemoteEdit.MinimumSize = new System.Drawing.Size(309, 119);
            this.userControlRemoteEdit.Name = "userControlRemoteEdit";
            this.userControlRemoteEdit.Size = new System.Drawing.Size(398, 146);
            this.userControlRemoteEdit.TabIndex = 5;
            // 
            // listRemotes
            // 
            this.listRemotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listRemotes.FormattingEnabled = true;
            this.listRemotes.IntegralHeight = false;
            this.listRemotes.Location = new System.Drawing.Point(6, 19);
            this.listRemotes.Name = "listRemotes";
            this.listRemotes.Size = new System.Drawing.Size(128, 144);
            this.listRemotes.TabIndex = 0;
            this.listRemotes.SelectedIndexChanged += new System.EventHandler(this.ListRemotesSelectedIndexChanged);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(249, 168);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDeleteClick);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.Location = new System.Drawing.Point(6, 168);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAddClick);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEdit.Enabled = false;
            this.btEdit.Location = new System.Drawing.Point(87, 168);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.BtEditClick);
            // 
            // RemotesEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(493, 197);
            this.Name = "RemotesEdit";
            this.Size = new System.Drawing.Size(544, 197);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listRemotes;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private RemoteEdit userControlRemoteEdit;
    }
}
