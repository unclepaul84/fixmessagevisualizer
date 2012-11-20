using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixMessageVisualizer.WinForms
{
    public partial class FixMessageVisualizerDialog : Form
    {
        public FixMessageVisualizerDialog()
        {
            InitializeComponent();
        }

        public static void Show(string msg, IWin32Window owner)
        {
            Show(msg, new ConventionBasedFixDictionarySource(), owner);
        }

        public static void Show(string msg, IFixDictionarySource dicSource, IWin32Window owner)
        {

            FixMessageVisualizer vis = new FixMessageVisualizer(msg, dicSource);

            var desr = vis.GetDescriptor();

            FixMessageVisualizerDialog diag = new FixMessageVisualizerDialog();

            if (desr != null)
                diag.fixMessageVisualizerControl1.SetFixMessageDescriptor(desr);

            diag.ShowDialog(owner);

        }

        private void FixMessageVisualizerDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
