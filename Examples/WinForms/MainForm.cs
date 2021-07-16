using SharpGPX;
using System;
using System.Net;
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

            OpenFile(ofd.FileName);
        }

        private void OpenFile(string url) => PropertyGrid.SelectedObject = FromUrl(url);

        /// <summary>
        /// Load Gpx file from an url
        /// You can use a local path "C:\Temp\fileName.gpx" and this will detect it.
        /// You can also use "file:\\\" if you like.
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static GpxClass FromUrl(string url)
        {
            // this will throw an exception if the url isn't an url
            // but interestingly it handles local file paths easily, creating
            // an url with a "file" Scheme
            Uri uri = new(url);

            // if it's a file scheme, just read the local file
            if (uri.Scheme == "file")
                return GpxClass.FromFile(url);

            // open a stream and load the file directly
            using var client = new WebClient();
            return GpxClass.FromStream(client.OpenRead(url));
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

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = null;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                fileName = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
            else if(e.Data.GetDataPresent(DataFormats.Text))
                fileName = (string)e.Data.GetData(DataFormats.Text, false);

            OpenFile(fileName);
        }

        private void Panel_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;
    }
}
