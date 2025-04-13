using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorExtraction
{
    public partial class SelectFactor : Form
    {
        public static SelectFactor Instance { get; private set; }
        private SelectFactor() => InitializeComponent();
        public static void ShowOrOpen()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new SelectFactor();
            }
            Instance.Show();
            Instance.BringToFront();
        }
        public SelectFactor(String factor)
        {
            InitializeComponent();
            this.Text = factor;
        }
    }
}
