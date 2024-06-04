namespace Web.Model
{
    public class FollowersModel
    {
        public Data data { get; set; }
        public string pagination_token { get; set; }
    }

    public class Data
    {
        public int count { get; set; }
        public Item[] items { get; set; }
        public int total { get; set; }
    }

    public class Item
    {
        public string full_name { get; set; }
        public string id { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

}
