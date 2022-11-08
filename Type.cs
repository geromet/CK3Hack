namespace CK3Hack
{
    internal class Type
    {
        public string fileLocation { get; private set; }
        public string searchString { get; private set; }
        public int copyDelay { get; private set; }
        public Type() { }
        public Type(string fileLocation, string searchString, int copyDelay = 0)
        {
            this.fileLocation = fileLocation;
            this.searchString = searchString;
            this.copyDelay = copyDelay;
        }
    }
}
