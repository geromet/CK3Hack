namespace CK3Hack
{
    internal class Hack
    {
        public void Run(List<Type> selectedTypes)
        {
            Clean(selectedTypes);
            WaitForGame();

            FileStream stream = File.Open((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Crusader Kings III/logs/debug.log").ToString(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (stream)
            {
                StreamReader reader = new StreamReader(stream);
                using (reader)
                {
                    string line;
                    while (selectedTypes.Count > 0)
                    {
                        line = reader.ReadLine();
                        if (line == null) continue;
                        List<Type> hits = new();
                        for (int i = 0; i < selectedTypes.Count; i++)
                        {
                            if (line.Contains(selectedTypes[i].searchString))
                            {
                                hits.Add(selectedTypes[i]);
                                selectedTypes.RemoveAt(i);
                            }
                        }
                        hits.ForEach(hit => Copy(hit));
                        hits.Clear();
                    }
                }
            }
        }
        private void Copy(Type type)
        {
            Thread.Sleep(type.copyDelay);
            File.Copy(Environment.CurrentDirectory + type.fileLocation, Properties.Settings.Default.GameFolder + type.fileLocation, true);
        }
        private void Clean(List<Type> selectedTypes)
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Crusader Kings III/logs/debug.log");
            foreach (Type type in selectedTypes)
            {
                File.Copy(Environment.CurrentDirectory + "/backup" + type.fileLocation, Properties.Settings.Default.GameFolder + type.fileLocation, true);
            }
        }
        private void WaitForGame()
        {
            while (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Paradox Interactive/Crusader Kings III/logs/debug.log"))
            {
                Thread.Sleep(500);
            }
        }
    }
}
