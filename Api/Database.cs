using Microsoft.VisualBasic;
using Npgsql;
using Telegram.Bot;
using Telegram.Bot.Types;
using Web.Model;

namespace Web
{
    public class Database
    {
        NpgsqlConnection con = new NpgsqlConnection(Constants.Connect);

        public async Task Insert(Test testmodel, FollowersModel followersModel, string Username)
        {
            var sql = "insert into public.\"InstagramRequests\"(\"Nickname\", \"FollowersCount\", \"Time\", \"ProfilePicture\", \"Username\")"
                + $"values (@Nickname, @FollowersCount, @Time, @ProfilePicture, @Username)";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);

            comm.Parameters.AddWithValue("Username", Username);
            comm.Parameters.AddWithValue("Nickname", testmodel.data.username);
            comm.Parameters.AddWithValue("ProfilePicture", testmodel.data.profile_pic_url_hd);
            comm.Parameters.AddWithValue("FollowersCount", followersModel.data.total);
            comm.Parameters.AddWithValue("Time", DateTime.Now);

            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }
        public async Task Insert(Test testmodel, string Username)
        {
            var sql = "insert into public.\"InstagramRequests\"(\"Nickname\", \"Time\", \"ProfilePicture\",\"Username\")"
                + $"values (@Nickname, @Time, @ProfilePicture, @Username)";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);

            comm.Parameters.AddWithValue("Username", Username);
            comm.Parameters.AddWithValue("Nickname", testmodel.data.username);
            comm.Parameters.AddWithValue("ProfilePicture", testmodel.data.profile_pic_url_hd);

            comm.Parameters.AddWithValue("Time", DateTime.Now);

            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }
        public async Task Delete(string Nickname, string Username)
        {
            var sql = "DELETE FROM public.\"InstagramRequests\" WHERE \"Nickname\" = @Nickname AND \"Username\" = @Username";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);


            comm.Parameters.AddWithValue("Nickname", Nickname);
            comm.Parameters.AddWithValue("Username", Username);
            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }

        public async Task<long> CountNickname(string Nickname)
        {
            var sql = "SELECT COUNT(*) FROM public.\"InstagramRequests\" WHERE \"Nickname\" = @Nickname";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("Nickname", Nickname);

            await con.OpenAsync();
            long count = (long)await comm.ExecuteScalarAsync();
            await con.CloseAsync();

            return count;
        }

        public async Task<long> CountNickname(string Nickname, string Username)
        {
            var sql = "SELECT COUNT(*) FROM public.\"InstagramRequests\" WHERE \"Nickname\" = @Nickname AND \"Username\" = @Username";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("Nickname", Nickname);
            comm.Parameters.AddWithValue("Username", Username);

            await con.OpenAsync();
            long count = (long)await comm.ExecuteScalarAsync();
            await con.CloseAsync();

            return count;
        }


    }
}
