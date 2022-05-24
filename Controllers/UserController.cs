
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using POO.Models;

namespace POO.Controllers;

public class UserController
{


    [Route("POO/[Controllers]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        SqlConnection conn;
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpPost, Route("[action]", Name = "Login")]
        public UserDetails Login(User user)
        {
            UserDetails userdetails = new UserDetails();
            userdetails.result = new Result();
            try
            {
                if (users != null && !string.IsNullOrWhiteSpace(users.username) && !string.IsNullOrWhiteSpace(users.password))
                {
                    conn = new SqlConnection(_configuration["ConnectionStrings:sql-conn"]);
                    using (conn)
                    {
                        SqlCommand cmd = new SqlCommand("sp_users", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", users.username);
                        cmd.Parameters.AddWithValue("@password", users.password);
                        cmd.Parameters.AddWithValue("@stmttype", "userlogin");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            userdetails.username = dt.Rows[0]["username"].ToString();
                            userdetails.firstname = dt.Rows[0]["firstname"].ToString();
                            userdetails.lastname = dt.Rows[0]["lastname"].ToString();
                            userdetails.email = dt.Rows[0]["email"].ToString();
                            userdetails.gender = dt.Rows[0]["gender"].ToString();
                            userdetails.contactno = dt.Rows[0]["contactno"].ToString();
                            userdetails.dob = dt.Rows[0]["dob"].ToString();
                            userdetails.role = dt.Rows[0]["role"].ToString();

                            userdetails.result.result = true;
                            userdetails.result.message = "success";
                        }
                        else
                        {
                            userdetails.result.result = false;
                            userdetails.result.message = "Invalid user";
                        }
                    }
                }
                else
                {
                    userdetails.result.result = false;
                    userdetails.result.message = "Please enter username and password";
                }
            }
            catch (Exception ex)
            {
                userdetails.result.result = false;
                userdetails.result.message = "Error occurred: " + ex.Message.ToString();
            }
            return userdetails;
        }
    }


}