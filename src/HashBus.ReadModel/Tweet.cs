﻿namespace HashBus.ReadModel
{
    public class Tweet
    {
        public long TweetId { get; set; }

        public long UserId { get; set; }

        public string UserIdStr { get; set; }

        public string UserName { get; set; }

        public string UserScreenName { get; set; }
    }
}
