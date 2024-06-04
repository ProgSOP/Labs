using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using Web.Clients;
using Web.Model;
using Web.Model1;
using static System.Net.Mime.MediaTypeNames;

namespace Web.Controllers
{
    [ApiController]
    [Route("InstagramController")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;


        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;

        }

        [HttpGet("GetPictureByNickname")]

        public string GetPicture(string nick, string username)
        {
            Database database = new Database();
            InstagramClients instagramClients = new InstagramClients();
            Test test = instagramClients.GetInformation(nick).Result;
            FollowersModel followersModel = instagramClients.GetFollowersInformation(nick).Result;

            if (test != null)
            {
                if (followersModel != null)
                {
                    database.Insert(test, followersModel, username);
                }
                else if (followersModel == null)
                {

                    database.Insert(test, username);
                }

                return test.data.profile_pic_url_hd;
            }
            else
            {
                return null;
            }
        }




        [HttpGet("GetFollowersCount")]

        public int GetFollowers(string nick, string username)
        {
            Database database = new Database();
            InstagramClients instagramClients = new InstagramClients();

            Test test = instagramClients.GetInformation(nick).Result;
            FollowersModel followersModel = instagramClients.GetFollowersInformation(nick).Result;

            database.Insert(test, followersModel, username);

            if (followersModel != null)
            {
                
                return followersModel.data.total;
               
            }
            else

            {
                
                return 0;
            }
        
        }


        [HttpGet("GetStoryByNickname")]

        public List<string> GetStory(string nick)
        {
            InstagramClients instagramClients = new InstagramClients();

            StoriesModel storiesModel = instagramClients.GetInformationStory(nick).Result;

            List<string> stories = new List<string>();

            if (storiesModel != null)
            {

                foreach (Web.Model1.Item item in storiesModel.data.items)
                {
                    if (item.video_url != null)
                    {
                       
                        stories.Add(item.video_url);
                    }
                    else if (item.thumbnail_url != null)
                    {
                       
                        stories.Add(item.thumbnail_url);
                    }
                }

                return stories;
            }
            else
            {
                return null;
            }
        }





        [HttpDelete("Delete")]
        public bool DeleteTest(string Nickname, string Username)
        {
            InstagramClients instagramClients = new InstagramClients();
            Test test = instagramClients.GetInformation(Nickname).Result;

            Database database = new Database();
            database.Delete(Nickname, Username);

            if (test != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet("GetStatistics")]

        public long GetStatistics(string nickname)
        {
            InstagramClients instagramClients = new InstagramClients();
            Test test = instagramClients.GetInformation(nickname).Result;
            if (test != null)
            {
                Database database = new Database();
                long count = database.CountNickname(nickname).Result;
                return count;
            }
            else
            {
                return -1;
            }
        }

        [HttpGet("GetStatisticsOverloaded")]
        public long GetStatistics(string nickname, string Username)
        {
            InstagramClients instagramClients = new InstagramClients();
            Test test = instagramClients.GetInformation(nickname).Result;
            if (test != null)
            {
                Database database = new Database();
                long count = database.CountNickname(nickname, Username).Result;
                return count;
            }
            else
            {
                return -1;
            }
        }





    }
}
