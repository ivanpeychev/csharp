using System;
using System.Collections;
using System.Collections.Generic;

public class User
{
	public int ID { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int CreatedByID { get; set; }
	public DateTime CreateDate { get; set; }
	public int UpdatedByID { get; set; }
	public DateTime UpdateDate { get; set; }
	public int ActionUserID { get; set; }
	
	public override string ToString()
	{
		User creator = UserDB.SelectByID(CreatedByID);
		return String.Format($"This is {this.FirstName} {this.LastName} with ID: {this.ID}, created by {creator.FirstName + " " + creator.LastName} on {CreateDate}.");
	}

	public static bool IsNullOrEmpty(object inValue)
	{
		bool bEmpty = false;
		try
		{
			if (inValue.ToString() == null || inValue.ToString().Replace(" ", "").Length == 0)
			{
				bEmpty = true;
			}
		}
		catch
		{
			bEmpty = true;
		}
		return bEmpty;
	}
}