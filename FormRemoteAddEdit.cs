﻿using System.Windows.Forms;

namespace GitForce
{
    public partial class FormRemoteAddEdit : Form
    {
        /// <summary>
        /// Specifies one of 3 main functions that this form supports
        /// </summary>
        public enum Function { Add, Edit, Rename };

        public FormRemoteAddEdit()
        {
            InitializeComponent();
            ClassWinGeometry.Restore(this);
        }

        /// <summary>
        /// Form is closing.
        /// </summary>
        private void FormRemoteAddEditFormClosing(object sender, FormClosingEventArgs e)
        {
            ClassWinGeometry.Save(this);
        }

        public void Prepare(Function fn, ClassRemotes.Remote remote)
        {
            remoteEdit.Clear();
            remoteEdit.AnyTextChanged += SomeTextChanged;

            // Do things differently basen on whether we are using this
            // form to add a new remote repo, rename it or we are editing
            // an existing remote repo

            switch (fn)
            {
                case Function.Add:
                    remoteEdit.Enable(true, true);
                    remote.Name = "origin";
                    remote.PushCmd = "";
                    remoteEdit.Set(remote);
                    Text = "Add a new remote repository";
                    btOK.Enabled = false;
                    break;
                case Function.Edit:
                    Text = "Edit remote repository '" + remote.Name + "'";
                    remoteEdit.Enable(false, true);
                    remoteEdit.Set(remote);
                    break;
                case Function.Rename:
                    Text = "Rename remote repository '" + remote.Name + "'";
                    remoteEdit.Enable(true, false);
                    remoteEdit.Set(remote);
                    break;
            }
        }

        /// <summary>
        /// Return the content of the remote repo specification structure
        /// </summary>
        /// <returns>Remote repo values</returns>
        public ClassRemotes.Remote Get()
        {
            return remoteEdit.Get();
        }

        /// <summary>
        /// Callback function called when text in the remote repo editing
        /// has changed. Enable or disable OK button based on some simple
        /// checks.
        /// </summary>
        private void SomeTextChanged(bool valid)
        {
            btOK.Enabled = valid;
        }
    }
}
