﻿using Anathema.Services.ProcessManager;
using Anathema.Source.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Anathema.GUI
{
    public partial class GUIProcessSelector : DockContent, IProcessSelectorView
    {
        private ProcessSelectorPresenter ProcessSelectorPresenter;

        // Column text alignment. Without this the column title lines up with the icon rather than text
        private const string Alignment = "     ";

        public GUIProcessSelector()
        {
            InitializeComponent();

            // Set custom properties for our process List View
            ProcessListView.Columns.Add(Alignment + "Processes");
            ProcessListView.View = View.Details;

            // Initialize presenter
            ProcessSelectorPresenter = new ProcessSelectorPresenter(this, ProcessSelector.GetInstance());

            // Initialize process list
            RefreshProcesses();
        }

        public void SelectProcess(Process TargetProcess)
        {
            this.Close();
        }

        public void DisplayProcesses(IEnumerable<ListViewItem> Items, ImageList ImageList)
        {
            // Clear the old items in the process list
            ProcessListView.Items.Clear();

            // Add all of the new items
            Items?.ForEach(X => ProcessListView.Items.Add(X));
            ProcessListView.SmallImageList = ImageList;
        }

        private void TrySelectingProcess()
        {
            if (ProcessListView.SelectedIndices.Count <= 0)
                return;

            try
            {
                ProcessSelectorPresenter.SelectProcess(ProcessListView.SelectedIndices[0]);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error making selection.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshProcesses()
        {
            ProcessSelectorPresenter.RefreshProcesses(this.Handle);
        }

        private void HandleResize()
        {
            ProcessListView.Columns[0].Width = ProcessListView.Width - 24;
        }

        #region Events

        private void SelectProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrySelectingProcess();
        }

        private void ProcessListView_DoubleClick(object sender, EventArgs e)
        {
            TrySelectingProcess();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        private void GUIProcessSelector_Resize(object sender, EventArgs e)
        {
            HandleResize();
        }

        #endregion

    }


}
