


using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConsoleApp
{
    public class SwagerGet
    {
        public async Task<int> GetFollowers(string Nick, string Username)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http://localhost:5150/InstagramController/GetFollowersCount?nick={Nick}&username={Username}"),

            };

           
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    int result = JsonConvert.DeserializeObject<int>(body);
                    return result;
                }
            
           
        }
        public async Task<string> GetPicture(string Nick, string Username)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http://localhost:5150/InstagramController/GetPictureByNickname?nick={Nick}&username={Username}"),

            };

            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    if (body != "")
                    {
                        return body;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            
      
        }
        public async Task<List<string>> GetStorie(string Nick)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http://localhost:5150/InstagramController/GetStoryByNickname?nick={Nick}"),

            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<string>>(body);
                return result;
            }
        }

        public async Task<string> GetStatistics(string nickname)
        {
            var client = new HttpClient();
            string response = await client.GetStringAsync($"http://localhost:5150/InstagramController/GetStatistics?nickname={nickname}");
            return response;
        }
        public async Task<bool> DeleteFromData(string nickname, string username)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"http://localhost:5150/InstagramController/Delete?Nickname={nickname}&Username={username}"),

            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<bool>(body);
                return result;
            }

        }
        public async Task<string> GetStatisticsOverloaded(string nickname, string username)
        {
            var client = new HttpClient();
            string response = await client.GetStringAsync($"http://localhost:5150/InstagramController/GetStatisticsOverloaded?nickname={nickname}&Username={username}");
            return response;
        }
    }

    internal class Program
    {


        public static bool function1Work = false;
        public static bool function2Work = false;
        public static bool functionDeleteWork = false;
        public static bool functionGetStatisticsWork = false;
        public static bool functionGetStorie = false;
        static void Main(string[] args)
        {

            var client = new TelegramBotClient("6816166286:AAEvNnpqnX8l7qUd-WHp_U2fSr10DNinSQ4");
            client.StartReceiving(Update, Error);
            Console.WriteLine("Bot started");
            Console.ReadLine();
        }
        async private static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {

            if (update?.Message?.Text != null && update.Type == UpdateType.Message)
            {

                await HandlerMessageAsync(botClient, update.Message);
            }




        }
        private static async Task HandlerMessageAsync(ITelegramBotClient botClient, Message message)
        {

            if (message.Text == "/start")
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, $"Hi! {message.Chat.Username} I am InstagramHelper bot! Choose command :3 \n\n/getpicurl - To get avatar of instagram profile by nickname or link\n" +
                    $"/getnumberoffollowers - To get number of followers of instagram profile by nickname or link\n/delete - Delete your requests by nickname\n/getstatistics - Get a number of profile visits\n/getstories - Get active stories by nickname or link", replyToMessageId: message.MessageId);

            }

            else if (message.Text == "/getpicurl")
            {
                function1Work = true;
                await botClient.SendTextMessageAsync(message.Chat.Id, $"Hi! write nickname or send me a link");
            }

            else if (message.Text == "/getnumberoffollowers")
            {
                function2Work = true;
                await botClient.SendTextMessageAsync(message.Chat.Id, $"Hi! write nickname or send me a link");
            }

            else if (message.Text == "/delete")
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, $"Ok, write the nickname or of the request you want to delete (Attention, you should have made this request in the past)");
                functionDeleteWork = true;
            }

            else if (message.Text == "/getstatistics")
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, $"Ok, write me nickname you want to count statistics!");
                functionGetStatisticsWork = true;

            }
            else if (message.Text == "/getstories")
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, $"Ok, write me nickname or link you want to get stories");
                functionGetStorie = true;

            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------//


            else if (function1Work == true)
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "I've received your message. Wait......");
                SwagerGet swagerGet = new SwagerGet();

                var nick = message.Text;
                var username = message.Chat.Username;

                string picture = swagerGet.GetPicture(nick, username).Result;

                if (picture != null)
                {

                    await botClient.SendDocumentAsync(message.Chat.Id, document: InputFile.FromUri(picture), replyMarkup:
                    new InlineKeyboardMarkup(InlineKeyboardButton.WithUrl(text: "Url of your picture", url: $"{picture}")), replyToMessageId: message.MessageId);
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"I can't find that account :(");

                }

                function1Work = false;
            }

            else if (function2Work == true)
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "I've received your message. Wait......");
                SwagerGet swagerGet = new SwagerGet();

                var nick = message.Text;
                var username = message.Chat.Username;

                int followers = swagerGet.GetFollowers(nick, username).Result;

                if (followers != 0)
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"{nick} followers count: {followers}");
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Sorry this account is private or doesn`t exist at all :(");
                }

                function2Work = false;

            }
            else if (functionDeleteWork == true)
            {
                var nickname = message.Text;
                var username = message.Chat.Username;

                SwagerGet swagerGet = new SwagerGet();
                string result = swagerGet.GetStatisticsOverloaded(nickname, username).Result;

                if (nickname.Contains("http") == false)
                {
                    if (swagerGet.DeleteFromData(nickname, username).Result == true)
                    {
                        if (long.Parse(result) > 0)
                        {
                            swagerGet.DeleteFromData(nickname, username);
                            await botClient.SendTextMessageAsync(message.Chat.Id, $"Success! all your requests to the {nickname} have been deleted");
                        }
                        else
                        {
                            await botClient.SendTextMessageAsync(message.Chat.Id, $"I couldn't find your requests, either you deleted them all or they don't exist");
                        }
                    }
                    else
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, $"I can't find that request :(");
                    }
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Please send it as a Nickname");
                }

                functionDeleteWork = false;

            }
            else if (functionGetStatisticsWork == true)
            {
                var nickname = message.Text;
                SwagerGet swagerGet = new SwagerGet();
                string statistics = swagerGet.GetStatistics(nickname).Result;

                if (statistics.Contains("-1") == false)
                {
                    if (nickname.Contains("http") == true || nickname.Contains("https") == true)
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, $"Please send it as a Nickname");
                    }
                    else
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, $"{nickname} profile was searched for {statistics} times!");
                    }
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"I can't find this instagram profile :(");
                }

                functionGetStatisticsWork = false;
            }

            else if (functionGetStorie == true)
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "I've received your message. Wait......");
                SwagerGet swagerGet = new SwagerGet();
                List<string> result = swagerGet.GetStorie(message.Text).Result;

                if (result != null)
                {
                    if (result.Count != 0)
                    {
                        if (result.Count <= 10)
                        {
                            await botClient.SendTextMessageAsync(message.Chat.Id, $"There are stories: ");
                            foreach (var storie in result)
                            {

                                await botClient.SendDocumentAsync(message.Chat.Id, document: InputFile.FromUri(storie));
                            }
                        }
                        else
                        {
                            await botClient.SendTextMessageAsync(message.Chat.Id, $"Too many stories, sorry i can't send you more than 10 :(");
                        }
                    }
                    else
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, $"This profile doesn't have any stories now");
                    }

                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"I can't find this instagram profile :(");
                }

                functionGetStorie = false;

            }

            else
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "Please choose one of the commands! \n/getpicurl - To get avatar of instagram profile by nickname or link\n/getnumberoffollowers- To get number of followers of instagram\n/delete - Delete your requests by nickname\n/getstatistics - Get a number of profile visits\n/getstories - Get active stories by nickname or link");
            }
        }
        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            var error = exception switch
            {
                ApiRequestException apiRequestException => $"Error:\n{apiRequestException.ErrorCode}" +
                $"\n {apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine($"{error}");
            return Task.CompletedTask;
        }

    }
}