using SharpGPX;
using System;
using System.Windows.Forms;
using Utility;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listBox1.Items.Add(new CreateModel("Track", Examples.CreateTrack));
            listBox1.Items.Add(new CreateModel("Track No Meta", Examples.CreateTrackNoMetadata));
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
            {
                Title = "Open GPX File",
                Filter = "GPX File|*.gpx",
            };

            if (ofd.ShowDialog(this) != DialogResult.OK) return;

            GpxClass gpx = GpxClass.FromFile(ofd.FileName);
            PropertyGrid.SelectedObject = gpx;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PropertyGrid.SelectedObject is not GpxClass gpx) return;

            using SaveFileDialog sfd = new()
            {
                Title = "Save GPX File",
                Filter = "GPX File|*.gpx"
            };

            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            gpx.ToFile(sfd.FileName);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var toCreate = (listBox1.SelectedItem as CreateModel)?.Create;
            if (toCreate == null)
                return;

            PropertyGrid.SelectedObject = toCreate();
        }

        public class CreateModel
        {
            public CreateModel(string name, Func<GpxClass> create)
            {
                Name = name;
                Create = create;
            }

            public string Name { get; }

            public Func<GpxClass> Create { get; }

            public override string ToString() => Name;
        }
    }
}
