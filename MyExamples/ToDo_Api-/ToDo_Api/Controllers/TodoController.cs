using Microsoft.AspNetCore.Mvc;
using ToDo_Api.Object;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ToDo_Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        string sql = "Data Source =EVT03306NB\\SQLEXPRESS;Initial Catalog = TodoDb; Integrated Security=SSPI";


        [HttpGet]
        public string GetTodos()
        {
            SqlConnection connection = new SqlConnection(sql);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Todo", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
                ;
            }
            else
            {
                return "not fount";
            }


        }
        [HttpGet("{id}")]
        public string GetTodoById(int id)
        {
            SqlConnection connection = new SqlConnection(sql);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Todo Where Id=" + id, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
                ;
            }
            else
            {
                return "not fount";
            }


        }
        [HttpPost]
        public string ADD(int id, string title, string descriptiom)
        {
            SqlConnection connection = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand("insert into Todo (Id,Title,Description1) values('" + id + "','" + title + "','" + descriptiom + "')", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i == 1)
            {
                return "kayıt basarılı...";

            }
            else
            {
                return "try again";
            }
        }
        [HttpPut]
        public string Update(int id, string title, string description)
        {
            SqlConnection connection = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand("update Todo set Title='" + title + "' ,Description1='" + description + "' where Id='" + id + "' ", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i == 1)
            {
                return "update basarılı...";

            }
            else
            {
                return "try again";
            }
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            SqlConnection connection = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand("delete from Todo Where Id= " + id, connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i == 1)
            {
                return "delete basarılı...";

            }
            else
            {
                return "try again";
            }

        }








    }
}
