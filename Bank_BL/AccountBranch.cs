using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Bank_DL;
using System.Windows.Forms;

namespace Bank_BL
{
	public class AccountBranch
	{
		public string userRole { get; set; }
		public string name { get; set; }

		public string username { get; set; }

		public string password { get; set; }

		public int id { set; get; }

public void udate(string job,string Name,string pass)
		{
			userRole = job;
			name = Name;
			password = pass;
		}


		public int AddTo()
		{
			try
			{
				string query = @"insert into users(userRole,name,username,pass )values(@userRole,@name,@username,@pass)";
				DbParameter[] paraArray = new DbParameter[4];
				paraArray[0] = (DbParameter)DbHelper.CreateParameter("@userRole", System.Data.DbType.String, this.userRole);
				paraArray[1] = (DbParameter)DbHelper.CreateParameter("@name", System.Data.DbType.String, this.name);
				paraArray[2] = (DbParameter)DbHelper.CreateParameter("@username", System.Data.DbType.String, this.username);
				paraArray[3] = (DbParameter)DbHelper.CreateParameter("@pass", System.Data.DbType.String, this.password);
				int rows = DbHelper.ExecuteNonQuery(System.Data.CommandType.Text, query, paraArray);
				return rows;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}



		public static List<AccountBranch> getAccount()
		{
			DbConnection conn = null;
			try
			{
				String query = @"select id,userRole,name,username,pass from users";
				conn = DbHelper.GetConnection();
				conn.Open();

				List<AccountBranch> accBrnch = new List<AccountBranch>();
				SqlDataReader reader = (SqlDataReader)DbHelper.ExecuteReader(ref conn, System.Data.CommandType.Text,query, null);

				while(reader.Read()){
					AccountBranch acc = new AccountBranch();
					acc.id = Convert.ToInt32(reader[0].ToString());
					acc.userRole = reader[1].ToString();
					acc.name = reader[2].ToString();
					acc.username = reader[3].ToString();
					acc.password = reader[4].ToString();
					accBrnch.Add(acc);

				}
				return accBrnch;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}


		}


		  public List<AccountBranch>veiwAccount()
		{
			DbConnection conn = null;
			try
			{
				string query= @"select id,userRole,name,username,pass from users where username="+"'"+username+"'";
				conn = DbHelper.GetConnection();
				conn.Open();
				List<AccountBranch> accList = new List<AccountBranch>();
				SqlDataReader reader = (SqlDataReader)DbHelper.ExecuteReader(ref conn, System.Data.CommandType.Text, query, null);
				while (reader.Read())
				{
					AccountBranch acc = new AccountBranch();
					acc.id = Convert.ToInt32(reader[0].ToString());
					acc.userRole = reader[1].ToString();
					acc.name = reader[2].ToString();
					acc.username = reader[3].ToString();
					acc.password = reader[4].ToString();
					accList.Add(acc);

				}
				return accList;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}
		
		}


		

			public int Acupdate(string oldusername)
		{
			try
			{
				string query = @"UPDATE users SET userRole = @userRole, name = @name, pass = @pass where username = @oldusername";
				DbParameter[] paraArray = new DbParameter[4];
				paraArray[0] = (DbParameter)DbHelper.CreateParameter("@userRole", System.Data.DbType.String, this.userRole);
				paraArray[1] = (DbParameter)DbHelper.CreateParameter("@name", System.Data.DbType.String, this.name);
				paraArray[2] = (DbParameter)DbHelper.CreateParameter("@pass", System.Data.DbType.String, this.password);
				paraArray[3] = (DbParameter)DbHelper.CreateParameter("@oldusername", System.Data.DbType.String, oldusername);
				int rows = DbHelper.ExecuteNonQuery(System.Data.CommandType.Text, query, paraArray);
				return rows;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int AcDeleteAccount(string username)
		{
			try
			{
				string query = @"delete from users where username=@username";



				DbParameter[] paraArray = new DbParameter[1];
				paraArray[0] = (DbParameter)DbHelper.CreateParameter("@username", System.Data.DbType.String, username);


				int rows = DbHelper.ExecuteNonQuery(System.Data.CommandType.Text, query, paraArray);
				MessageBox.Show("Delecte successful.....");

				return rows;
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}


	}


}
