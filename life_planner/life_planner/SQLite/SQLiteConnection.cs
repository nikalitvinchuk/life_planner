namespace SQLite
{
    internal class SQLiteConnection
    {
        private string dB_PATH;

        public SQLiteConnection(string dB_PATH)
        {
            this.dB_PATH = dB_PATH;
        }
    }
}