using System;
using System.Collections.Generic;

namespace InstagramAPI.Models
{// Ik gebruik deze object om de data van json bestand op te slaan 
    //Deze object voor de recent media
    public class InstagramMedia
    {


        public Meta meta { get; set; }
        public IList<Data> data { get; set; }
        public Pagination pagination { get; set; }



        public class Meta
        {


        }
        public class Data
        {
            public string id { get; set; }
            public User user { get; set; }
            public Images images { get; set; }
            public string created_time { get; set; }
            public Caption caption { get; set; }
            public Boolean user_has_liked { get; set; }
            public Likes likes { get; set; }
            public IList<String> tags { get; set; }
            public string filter { get; set; }
            public Comments comments { get; set; }

            public string type { get; set; }
            public string link { get; set; }
            public Locaton location { get; set; }
            public Attribution attribution { get; set; }
            public string users_in_photo { get; set; }



            public class User
            {
                public string Id { get; set; }
                public string full_name { get; set; }
                public string profile_picture { get; set; }
                public string username { get; set; }
            }
            public class Images
            {
                public Thumbnail thumbnail { get; set; }

                public class Thumbnail
                {


                }
            }
            public class Caption { }
            public class Likes { }
            public class Comments { }
            public class Locaton { }
            public class Attribution { }


        }
        public class Pagination { }
    }
}