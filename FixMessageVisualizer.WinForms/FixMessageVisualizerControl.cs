using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixMessageVisualizer.WinForms
{
    public partial class FixMessageVisualizerControl : UserControl
    {
        public FixMessageVisualizerControl()
        {
            InitializeComponent();
        }

        private QuickFix.FixMessageDescriptor _desr;


        public void SetFixMessageDescriptor(QuickFix.FixMessageDescriptor desr)
        {
            _desr = desr;

        }

        private void PopulateTree(TreeNode parentNode, List<QuickFix.FixFieldInfo> list)
        {

            foreach (var ffi in list)
            {

                if (parentNode == null)
                {
                    var createdNode = treeViewMain.Nodes.Add(ffi.ToString());

                    if (ffi is QuickFix.GroupFixFieldInfo)
                    {
                        PopulateTree(createdNode, (ffi as QuickFix.GroupFixFieldInfo).Fields);
                    }
                }
                else
                {

                    var createdNode = parentNode.Nodes.Add(ffi.ToString());

                    if (ffi is QuickFix.GroupFixFieldInfo)
                    {
                        PopulateTree(createdNode, (ffi as QuickFix.GroupFixFieldInfo).Fields);
                    }
                }

            }

        }

        private void treeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FixMessageVisualizerControl_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;

            InitializeTree();
        }

        private void InitializeTree()
        {
            if (_desr != null)
            {

                treeViewMain.Nodes.Clear();

                if (!string.IsNullOrWhiteSpace(_desr.MessageType))
                {
                    lblMessageName.Text = string.Format("{0} ({1})", _desr.MessageType, _desr.FixVersion);
                }
                else
                {

                    lblMessageName.Text = "Unknown Message (Dictionary not found)";
                }

                PopulateTree(null, _desr.Fields);
            }
        }
    }
}
