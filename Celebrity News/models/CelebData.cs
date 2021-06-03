using System;
using System.Collections.Generic;
using System.Text;

namespace Celebrity_News.models
{
    public static IList<Celebs>Celebrity{ get; private set; }
     static CelebData()
    {
        Celebrity = new List<Celebs>();

        Celebrity.Add(new Celebs
        {
            Id = "Musician",
            Name = "Ariana Grande",
            Birthday = "June 26, 1993",
            Details = " is an American singer, songwriter, and actress. From 2010 to 2013, she played Cat Valentine on the Nickelodeon sitcom Victorious. She played that role again on the spin-off Sam & Cat.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Ariana_Grande_Grammys_Red_Carpet_2020.png/220px-Ariana_Grande_Grammys_Red_Carpet_2020.png"
        });
        Celebrity.Add(new Celebs
        {
            Id = "Athlets",
            Name ="Stephen Curry",
            Birthday="March 14, 1988",
            Details ="is an American professional basketball player who plays for the Golden State Warriors of the National Basketball Association (NBA).Curry plays the point guard position.",
            ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Stephen_Curry_dribbling_2016_%28cropped%29.jpg/220px-Stephen_Curry_dribbling_2016_%28cropped%29.jpg"
        });
        Celebrity.Add(new Celebs
        {
            Id = "Athlets",
            Name ="Serena Williams", 
            Birthday = "September 26, 1981", 
            Details = " is an American professional tennis player. She is the younger sister of another former world no. 1 professional female tennis player, Venus Williams.",
            ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Serena_Williams_at_2013_US_Open.jpg/220px-Serena_Williams_at_2013_US_Open.jpg"
        });
        Celebrity.Add(new Celebs
        {
            Id = "Actors",
            Name = "Dwayne Johnson",
            Birthday = "May 2, 1972",
            Details = "is an American actor and semi-retired professional wrestler. He is best known for his work with the WWE.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Dwayne_Johnson_2%2C_2013.jpg/220px-Dwayne_Johnson_2%2C_2013.jpg"
        });
        Celebrity.Add(new Celebs
        {
            Id = "Musicians",
            Name = "21 savage",
            Birthday = "October 22, 1992",
            Details = "better known by his stage name 21 Savage, is an British-born rapper, songwriter and record producer. He is based in Atlanta, in the U.S. state of Georgia.21 Savage started his career in 2014. He has released two mixtapes, two extended plays and two solo studio albums. He released his first album, Issa Album, in 2017. The album's lead single was Bank Account.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/21_Savage_2018.jpg/220px-21_Savage_2018.jpg"
        });
        Celebrity.Add(new Celebs
        {
            Id = "Actors",
            Name ="Will Smith",
            Birthday = "September 25, 1968", 
            Details = "is an American actor and rapper from Philadelphia, Pennsylvania.He got his start as part of the rap duo DJ Jazzy Jeff and the Fresh Prince.[2] He became an actor when he starred on the television show The Fresh Prince of Bel-Air as Will Smith, a teenager from Philadelphia sent to live with his rich relatives in Southern California. He has appeared in many movies including Independence Day.", 
            ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Will_Smith_2.jpg/220px-Will_Smith_2.jpg"
        });
        Celebrity.Add(new Celebs
        {
            Id = "Musicians",
            Name ="Beyonce Knowles-Carter", 
            Birthday = "September 4, 1981", 
            Details = "is an American singer, songwriter, record producer, dancer, and actress. She was the lead singer of the all-girl R&B group Destiny's Child. She released her first album Dangerously in Love in 2003 when Destiny's Child were on a break. Since then, she has released five more albums, which have all produced hit singles. She is married to rapper JAY-Z and has a daughter named Blue Ivy Carter and twins Sir and Rumi Carter.", 
            ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Beyonce.jpg/220px-Beyonce.jpg"
        });
        Celebrity.Add(new Celebs
        {
            Id = "Actors",
            Name ="Morgan Freeman",
            Birthday = "June 1, 1937", 
            Details = "is an American actor, director, and narrator. He has appeared in a range of film genres portraying character roles and is particularly known for his distinctive deep voice.",
            ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Morgan_Freeman%2C_2006.jpg/210px-Morgan_Freeman%2C_2006.jpg"

        });
    }
}


              
                
                
              
               
               
               
              