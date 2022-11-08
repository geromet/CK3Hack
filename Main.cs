using Newtonsoft.Json;

namespace CK3Hack
{

    /*                fileLocation = "/common/bookmarks/00_bookmarks.txt";
                searchString = "[PDX_NAKAMA_METADATA]";

                fileLocation = "/history/characters/norse.txt";
                searchString = "Authenticated successfully";*/

    public partial class Main : Form
    {
        private List<Type> selectedTypes = new();
        private Dictionary<string, List<string>> SearchStringAndFile = new Dictionary<string, List<string>>();
        private Hack hack = new();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SearchStringAndFile != null)
            {
                SearchStringAndFile = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(Properties.Settings.Default.SearchStringAndFile);
                OutputBox.Text = Properties.Settings.Default.SearchStringAndFile;
            }
            InitializeTypes();
        }

        private void SelectGameFolderButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GameFolder = (folderBrowserDialog.ShowDialog() == DialogResult.OK) ? folderBrowserDialog.SelectedPath + "/game" : null;
            Properties.Settings.Default.Save();
        }
        private void AddFile(string fileLocation, string searchString)
        {
            if (SearchStringAndFile == null)
            {
                SearchStringAndFile = new Dictionary<string, List<string>>();
                SearchStringAndFile.Add(searchString, new List<string> { fileLocation });
            }
            else
            {
                if (SearchStringAndFile.ContainsKey(searchString))
                {
                    SearchStringAndFile[searchString].Add(fileLocation);
                }
                else
                {
                    SearchStringAndFile.Add(searchString, new List<string> { fileLocation });
                }
            }

            //TODO : put in save function
            Properties.Settings.Default.SearchStringAndFile = JsonConvert.SerializeObject(SearchStringAndFile);
            Properties.Settings.Default.Save();
            InitializeType(fileLocation, searchString);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GameFolder == null)
            {
                RunButton.Text = "Game folder not set";
            }
            else
            {
                hack.Run(selectedTypes);
            }
        }

        private void InitializeTypes()
        {
            if (SearchStringAndFile != null)
            {
                foreach (KeyValuePair<string, List<string>> entry in SearchStringAndFile)
                {
                    foreach (string fileLocation in entry.Value)
                    {
                        selectedTypes.Add(new Type(fileLocation, entry.Key));
                    }
                }
            }

        }
        private void InitializeType(string fileLocation, string searchString)
        {
            selectedTypes.Add(new Type(fileLocation, searchString));
        }

        private void AddNewFileButton_Click(object sender, EventArgs e)
        {
            if (LocationTextBox.Text.Length > 5 && searchStringTextBox.Text.Length > 5)
            {
                AddFile(LocationTextBox.Text, searchStringTextBox.Text);
                OutputBox.Text = Properties.Settings.Default.SearchStringAndFile;
                LocationTextBox.Text = null;
                searchStringTextBox.Text = null;
            }
            else
            {
                Properties.Settings.Default.SearchStringAndFile = null;
                Properties.Settings.Default.Save();
                SearchStringAndFile = null;
                OutputBox.Text = Properties.Settings.Default.SearchStringAndFile;
                LocationTextBox.Text = null;
                searchStringTextBox.Text = null;
            }

        }
    }
}