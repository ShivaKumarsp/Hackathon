namespace HackathonAPI.Comman
{
    public static class ConnectionString
    {
        private static string cs = "data source=SOWMYA\\SQLEXPRESS;database=Hackathon;uid=sa;password=sql@123;";
        public static string dbcs { get=> cs; }
    }
}
