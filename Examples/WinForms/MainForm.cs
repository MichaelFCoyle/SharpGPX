using SharpGPX;
using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
            {
                Title = "Open GPX File",
                Filter = "GPX File|*.gpx",
            };

            if (ofd.ShowDialog(this) != DialogResult.OK) return;

            GpxClass gpx = GpxClass.FromFile(ofd.FileName);

        }
    }
}
