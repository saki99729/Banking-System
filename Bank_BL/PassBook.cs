using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_DL;

namespace Bank_BL
{
	public class PassBook : MainData
	{
		public double salary { set; get; }

		public int Acc_ID { get; set; }

		public PassBook()
		{

		}

		public PassBook(string fname, string lname, string nic, DateTime dob, string gender)
		{
			Fname = fname;
			Lname = lname;
			NIC = nic;
			DOB = dob;
			Gender = gender;
		}

		public void up (string fname,string lname,string nic)
		{
			Fname = fname;
			Lname = lname;
			NIC = nic;
		}
		public int AddToPass()
		{
			try
			{
				string query = @"insert into AccPass(fname,lname,Nic,Dob,gender,salary) values(@fname,@lname,@Nic,@Dob,@gender,@salary) ";
				DbParameter[] paraArray = new DbParameter[6];
				paraArray[0] = (DbParameter)DbHelper.CreateParameter("@fname", System.Data.DbType.String, this.Fname);
				paraArray[1] = (DbParameter)DbHelper.CreateParameter("@lname", System.Data.DbType.String, this.Lname);
				paraArray[2] = (DbParameter)DbHelper.CreateParameter("@Nic", System.Data.DbType.String, this.NIC);
				paraArray[3] = (DbParameter)DbHelper.CreateParameter("@Dob", System.Data.DbType.Date, this.DOB.ToLongDateString());
				paraArray[4] = (DbParameter)DbHelper.CreateParameter("@gender", System.Data.DbType.String, this.Gender);
				paraArray[5] = (DbParameter)DbHelper.CreateParameter("@salary", System.Data.DbType.Double, this.salary);
				int rows = DbHelper.ExecuteNonQuery(System.Data.CommandType.Text, query, paraArray);
				return rows;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public static List<PassBook> getAccount()
		{
			DbConnection conn = null;
			try
			{
				String query = @"select Acc_ID,fname,lname,Nic,Dob,gender,salary from AccPass";
				conn = DbHelper.GetConnection();
				conn.Open();

				List<PassBook> accBrnch = new List<PassBook>();
				SqlDataReader reader = (SqlDataReader)DbHelper.ExecuteReader(ref conn, System.Data.CommandType.Text, query, null);

				while (reader.Read())
				{
					PassBook acc = new PassBook();
					acc.Acc_ID = Convert.ToInt32(reader[0].ToString());
					acc.Fname = reader[1].ToString();
					acc.Lname = reader[2].ToString();
					acc.NIC = reader[3].ToString();
					acc.DOB = Convert.ToDateTime(reader[4].ToString());
					acc.Gender = reader[5].ToString();
					acc.salary = Convert.ToDouble(reader[6].ToString());
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


		public List<PassBook> veiwAccount()
		{
			DbConnection conn = null;
			try
			{
				string query = @"select Acc_ID,fname,lname,Nic,Dob,gender,salary from AccPass where Acc_ID=" + "'" + Acc_ID + "'";
				conn = DbHelper.GetConnection();
				conn.Open();
				List<PassBook> accList = new List<PassBook>();
				SqlDataReader reader = (SqlDataReader)DbHelper.ExecuteReader(ref conn, System.Data.CommandType.Text, query, null);
				while (reader.Read())
				{
					PassBook acc = new PassBook();
					acc.Acc_ID = Convert.ToInt32(reader[0].ToString());
					acc.Fname = reader[1].ToString();
					acc.Lname = reader[2].ToString();
					acc.NIC = reader[3].ToString();
					acc.DOB = Convert.ToDateTime(reader[4].ToString());
					acc.Gender = reader[5].ToString();
					acc.salary = Convert.ToDouble(reader[6].ToString());
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



		public int Acupdate(int OLDID )
		{
			try
			{
				string query = @"UPDATE AccPass SET fname=@fname,lname=@lname,Nic=@Nic where Acc_ID =@OldID";
				DbParameter[] paraArray = new DbParameter[4];
				paraArray[0] = (DbParameter)DbHelper.CreateParameter("@fname", System.Data.DbType.String, this.Fname);
				paraArray[1] = (DbParameter)DbHelper.CreateParameter("@lname", System.Data.DbType.String, this.Lname);
				paraArray[2] = (DbParameter)DbHelper.CreateParameter("@Nic", System.Data.DbType.String, this.NIC);
				paraArray[3] = (DbParameter)DbHelper.CreateParameter("@OldID", System.Data.DbType.Int32, OLDID);
				int rows = DbHelper.ExecuteNonQuery(System.Data.CommandType.Text, query, paraArray);
				return rows;
			}
				


			catch (Exception ex)
			{
				throw ex;
			}
		}



		public int AcDeleteAccount(int ID)
		{
			try
			{
				string query = @"delete from AccPass where Acc_ID= @ID";



				DbParameter[] paraArray = new DbParameter[1];
				paraArray[0] = (DbParameter)DbHelper.CreateParameter("@ID", System.Data.DbType.Int32, ID);


				int rows = DbHelper.ExecuteNonQuery(System.Data.CommandType.Text, query, paraArray);
				

				return rows;
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}

		public int deposit()
		{
			try
			{
				string query = @"UPDATE AccPass SET salary=@salary where Acc_ID=@Acc_ID";
				DbParameter[] paraArray = new DbParameter[2];
				paraArray[0] = (DbParameter)DbHelper.CreateParameter("@salary", System.Data.DbType.Double, this.salary);
				paraArray[1] = (DbParameter)DbHelper.CreateParameter("@Acc_ID", System.Data.DbType.Int32, this.Acc_ID);
				int rows = DbHelper.ExecuteNonQuery(System.Data.CommandType.Text, query, paraArray);
				return rows;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


	}
}
