using Microsoft.Extensions.Configuration;
using ProjectChatMessage.Repository.Repository.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChatMessage.Repository.Repository
{
    public class ChatRepository : IChatRepository
    {
        public SqlConnection connection;


        public ChatRepository(IConfiguration configuration)
        {
            string strConnection = configuration.GetConnectionString("sqlconnection");
            connection = new SqlConnection(strConnection);

        }

        public void AddChat(Chat chat)
        {
            SqlCommand cmd = new SqlCommand("dbo.Message", connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@ParentId", chat.ParentID);
            cmd.Parameters.AddWithValue("@Text", chat.Text);
            
            connection.Open();
            int rowInserted = cmd.ExecuteNonQuery();
            connection.Close();
        }

        public List<Chat> GetAllChat()
        {

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("GetAllChat", connection);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<Chat> ChatList = new List<Chat>();
            foreach (DataRow dr in dt.Rows)
            {
                Chat chat = new Chat();


                chat.ID = Convert.ToInt32(dr["ID"]);
                chat.ParentID = Convert.ToInt32(dr["ParentID"]);
                chat.Text = dr["Text"].ToString();
                chat.Time = Convert.ToDateTime(dr["Chattime"]);


                ChatList.Add(chat);
            }


            return ChatList;


        }
    }
}
