using System;
using System.IO;
using System.Windows.Forms;
using Podcast.Implementation;

namespace TestUI
{
    public partial class chapterTestForm : Form
    {
        public chapterTestForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog(this) != DialogResult.OK)
                return;

            filePath.Text = openFile.FileName;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            var path = filePath.Text;
            if (!File.Exists(path))
                return;

            var ep = new Episode(path);
            var chapters = ep.Chapters;

            chapterList.Clear();

            foreach (var chapter in chapters)
            {
                var item = new ListViewItem(chapter.Time.ToString());
                item.SubItems.Add(chapter.Name);
                chapterList.Items.Add(item);
            }
        }

        private void filePath_Changed(object sender, EventArgs e)
        {
            testButton.Enabled = !string.IsNullOrWhiteSpace(filePath.Text);
        }
    }
}
