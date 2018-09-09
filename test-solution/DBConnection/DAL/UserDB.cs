using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Collections;

public class UserDB : IEnumerable<UserDB>
{
    private const string connectionString = "Data Source=den1.mssql5.gear.host;Initial Catalog=testdb007;User ID=testdb007;Password=Wa7d~V8mi-b4";

	public static User SelectByID(int UserID)
    {
		try 
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = new SqlCommand("usr.sp_SelectUserByID", conn);
				cmd.Parameters.AddWithValue("@p_UserID", UserID);
				cmd.CommandType = CommandType.StoredProcedure;
				conn.Open();
				User myUser = new User();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						myUser = FillUser(dr);
					}
				}
				return myUser;
			}
		}
        catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
    }

    public static List<User> GetAll()
    {
		var myList = new List<User>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("usr.sp_ListUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
					myList.Add(FillUser(dr));
                }
            }
        }
		return myList;
    }
    public static int Insert(string FirstName, string LastName, int ByUserID)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("usr.sp_InsertUser", conn);
            cmd.Parameters.AddWithValue("@p_FirstName", FirstName);
            cmd.Parameters.AddWithValue("@p_LastName", LastName);
            cmd.Parameters.AddWithValue("@p_ByUserID", ByUserID);
			cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
			int newUserID = 0;
			using (SqlDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read())
				{
					newUserID = Convert.ToInt32(dr["UserID"]);
				}
			}
			if (newUserID == 0)
			{
				throw new Exception("There is a problem with user creation!");
			}
			return newUserID;
		}
    }
	public static string Update(string FirstName, string LastName, int UserID, int ByUserID)
	{
		using (SqlConnection conn = new SqlConnection(connectionString))
		{
			SqlCommand cmd = new SqlCommand("usr.sp_UpdateUserByID", conn);
			cmd.Parameters.AddWithValue("@p_FirstName", FirstName);
			cmd.Parameters.AddWithValue("@p_LastName", LastName);
			cmd.Parameters.AddWithValue("@p_UserID", UserID);
			cmd.Parameters.AddWithValue("@p_ByUserID", ByUserID);
			cmd.CommandType = CommandType.StoredProcedure;
			conn.Open();
			bool success = false;
			using (SqlDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read())
				{
					success = Convert.ToBoolean(dr["Result"]);
				}
			}
			if (success)
			{
				return "success";
			}
			else
			{
				return "Update error";
			}
		}
	}
	public static string Delete(int UserID)
	{
		using (SqlConnection conn = new SqlConnection(connectionString))
		{
			SqlCommand cmd = new SqlCommand("usr.sp_DeleteUserByID", conn);
			cmd.Parameters.AddWithValue("@p_UserID", UserID);
			cmd.CommandType = CommandType.StoredProcedure;
			conn.Open();
			bool success = false;
			using (SqlDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read())
				{
					success = Convert.ToBoolean(dr["Result"]);
				}
			}
			if (success)
			{
				return "success";
			}
			else
			{
				return "Delete error";
			}
		}
	}


	public static User FillUser(IDataRecord myDataRecord)
    {
		return new User
		{
			ID = Convert.ToInt32(myDataRecord["ID"]),
			FirstName = myDataRecord["FirstName"].ToString(),
			LastName = myDataRecord["LastName"].ToString(),
			CreatedByID = Convert.ToInt32(myDataRecord["CreatedByID"]),
			CreateDate = DateTime.Parse(myDataRecord["CreateDate"].ToString()),
			UpdatedByID = User.IsNullOrEmpty(myDataRecord["UpdatedByID"]) ?
							0 :
							Convert.ToInt32(myDataRecord["UpdatedByID"]),
			UpdateDate = User.IsNullOrEmpty(myDataRecord["UpdateDate"].ToString()) ? 
							Convert.ToDateTime("01/01/1900") : 
							Convert.ToDateTime(myDataRecord["UpdateDate"].ToString())
		};
    }

	public IEnumerator<UserDB> GetEnumerator()
	{
		throw new NotImplementedException();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw new NotImplementedException();
	}
}