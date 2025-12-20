using BridgeLabzApp.DB;

namespace BridgeLabzApp
{
    public class Program
    {
        public static void Main()
        {
            TestDatabase testDatabase = new TestDatabase();
            testDatabase.ConnectDatabase();
        }
    }
}