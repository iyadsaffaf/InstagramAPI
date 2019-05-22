using System;

namespace InstagramAPI.Models
{

    // Ik gebruik deze object om de data van json bestand op te slaan 
    //Deze object voor de user data
    public class InstagramUser
    {


        public Data data { get; set; }
        public Meta meta { get; set; }





        public class Data
        {
            public string Id { get; set; }
            public string UserName { get; set; }
            public string Profile_Picture { get; set; }
            public string Full_Name { get; set; }
            public string Bio { get; set; }
            public string Website { get; set; }
            public Boolean Is_businees { get; set; }
            public Counts counts { get; set; }

            public class Counts
            {
                public int Media { get; set; }
                public int Follows { get; set; }
                public int Followed_by { get; set; }


            }




        }
        public class Meta { }
    
}
}