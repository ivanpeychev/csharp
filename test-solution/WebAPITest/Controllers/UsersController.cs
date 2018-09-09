using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    public class UsersController : ApiController
    {
		/// <summary>
		/// Lists all available users.
		/// </summary>
		// GET: api/Users
		public List<User> Get()
        {
			return UserDB.GetAll();
        }

		/// <summary>
		/// List a user requested by ID.
		/// </summary>
		// GET: api/Users/5
		public User Get(int id)
        {
			return UserDB.SelectByID(id);
        }

		/// <summary>
		/// Adds new user to the DB.
		/// </summary>
		// POST: api/Users
		public int Post([FromBody]User request)
        {
			return UserDB.Insert(request.FirstName, request.LastName, request.ActionUserID);
        }

		/// <summary>
		/// Updates first and last name of existing user.
		/// </summary>
		// PUT: api/Users/5
		public string Put(int id, [FromBody]User request)
        {
			return UserDB.Update(request.FirstName, request.LastName, request.ID, request.ActionUserID);
        }

		/// <summary>
		/// Deletes user by ID.
		/// </summary>
		// DELETE: api/Users/5
		public string Delete(int id)
        {
			return UserDB.Delete(id);
        }

		/// <summary>
		/// Serves a great purpose!
		/// </summary>
		// OPTIONS header
		[AcceptVerbs("OPTIONS")]
		public HttpResponseMessage Options()
		{
			var resp = new HttpResponseMessage(HttpStatusCode.OK);
			resp.Headers.Add("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept, Authorization, Access-Control-Allow-Origin, Access-Control-Allow-Headers, Access-Control-Allow-Methods");
			resp.Headers.Add("Access-Control-Allow-Methods", "GET,HEAD,OPTIONS,POST,PUT");

			return resp;
		}
	}
}
