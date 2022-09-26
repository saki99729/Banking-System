using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // All generic data access classes
using System.Data.Common;  // classes shared (or overidden) by individual data providers

namespace Bank_DL
{
 public  class DbHelper
    {
         private static Providers _factory = Providers.SqlClient;
        private static string _connectionString = "";

        public static string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public static DbConnection GetConnection()
        {
            try
            {
                 DbProviderFactory oProviderFactory = DbProviderFactories.
                                        GetFactory(GetFactoryByProvider(_factory));
                 DbConnection con = oProviderFactory.CreateConnection();
                 con.ConnectionString = ConnectionString;
                return con;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private static string GetFactoryByProvider(Providers oGetFactory)
        {
            switch ((Providers)oGetFactory)
            {
                case Providers.Odbc:

                    return "System.Data.Odbc";
                case Providers.OleDb:

                    return "System.Data.OleDb";
                case Providers.SqlClient:

                    return "System.Data.SqlClient";
                case Providers.OracleClient:

                    return "System.Data.OracleClient";
                case Providers.MySql:
                    return "CorLab.MySql.MySqlClient";
            }
            return "";
        }

        public static IDataParameter CreateParameter(string name, DbType type, object value)
        {
            return CreateParameter(name, type, value, ParameterDirection.Input);
        }
               
        public static IDataParameter CreateParameter(string name, DbType type, object value, ParameterDirection direction)
        {

            DbParameter param = null;

            DbProviderFactory oProviderFactory = DbProviderFactories.GetFactory(GetFactoryByProvider(_factory));
            DbConnection Con = oProviderFactory.CreateConnection();
            DbCommand cmd = Con.CreateCommand();

            param = cmd.CreateParameter();

            if ((param != null))
            {
                param.ParameterName = name;
                param.DbType = type;
                param.Direction = direction;
                param.Value = value;
            }

            return param;
        }
  
        public static int ExecuteNonQuery(CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {
            //To identify type of DB Server connecting to
            DbProviderFactory oProviderFactory = DbProviderFactories.GetFactory(GetFactoryByProvider(_factory));
            //Create a new connection
            DbConnection Con = oProviderFactory.CreateConnection();
            //Create a new command
            DbCommand cmd = Con.CreateCommand();
            DbTransaction trans = null;

            try
            {
                Con.ConnectionString = ConnectionString;
                cmd.Connection = Con;//where to run
                cmd.CommandText = cmdText;//Query to run
                cmd.Parameters.Clear();
                cmd.CommandType = cmdType;//Normal query or a procedure

                if (!((cmdParms == null)))//Query might have parameters
                {
                    //DbParameter param = default(DbParameter);

                    foreach (DbParameter param in cmdParms)//Adding parameter to command
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                Con.Open();//This is the point open up the connection
                trans = Con.BeginTransaction();//Start transaction
                cmd.Transaction = trans;

                int val = cmd.ExecuteNonQuery();//Running query
                cmd.Parameters.Clear();
                trans.Commit();

                return val;//Return number of rows 
            }
            catch (DbException ex)
            {
                trans.Rollback();

                throw new Exception("DB Exception " + ex.Message);
            }
            catch (Exception exx)
            {
                trans.Rollback();
                throw new Exception("ExecuteNonQuery Function "+ exx.Message);
            }
            finally
            {
                Con.Close();
                cmd = null;
                cmdParms = null;
            }
        }
           
        public static object ExecuteScalar(CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {

            DbProviderFactory oProviderFactory = DbProviderFactories.GetFactory(GetFactoryByProvider(_factory));
            DbConnection Con = oProviderFactory.CreateConnection();
            DbCommand cmd = Con.CreateCommand();
            DbTransaction trans = null;

            try
            {
                Con.ConnectionString = ConnectionString;
                cmd.Connection = Con;
                cmd.CommandText = cmdText;
                cmd.Parameters.Clear();
                cmd.CommandType = cmdType;

                if (!((cmdParms == null)))
                {
                   // DbParameter param = default(DbParameter);

                    foreach (DbParameter param in cmdParms)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                Con.Open();
                trans = Con.BeginTransaction();
                cmd.Transaction = trans;

                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                trans.Commit();

                return val;
            }
            catch (DbException ex)
            {
                trans.Rollback();

                throw new Exception("DB Exception " + ex.Message);
            }
            catch (Exception exx)
            {
                trans.Rollback();
                throw new Exception("ExecuteNonQuery Function"+ exx.Message);
            }
            finally
            {
                Con.Close();
                cmd = null;
                cmdParms = null;
            }
        }
              
        public static DataSet ExecuteDataSet(CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {
            DbProviderFactory oProviderFactory = DbProviderFactories.GetFactory(GetFactoryByProvider(_factory));
            DbConnection con = oProviderFactory.CreateConnection();
            DbDataAdapter oDataAdapter = oProviderFactory.CreateDataAdapter();
            DbCommand cmd = con.CreateCommand();

            try
            {
                con.ConnectionString = ConnectionString;
                cmd = con.CreateCommand();
                PrepareCommand(cmd, con, cmdType, cmdText, cmdParms);
                oDataAdapter = oProviderFactory.CreateDataAdapter();
                DataSet oDataSet = new DataSet();
                oDataAdapter.SelectCommand = cmd;
                oDataAdapter.Fill(oDataSet);
                cmd.Parameters.Clear();


                return oDataSet;
            }
            catch (DbException ex)
            {

                throw new Exception("SQL Exception ", ex);
            }
            catch (Exception exx)
            {
                throw new Exception("Execute DataSet", exx);
            }
            finally
            {
                con.Close();
                cmd = null;
                oDataAdapter = null;
            }
        }       
             
        public static DbDataReader ExecuteReader(ref DbConnection conn, CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {

            DbProviderFactory oProviderFactory = DbProviderFactories.GetFactory(GetFactoryByProvider(_factory));
          

            DbDataAdapter oDataAdapter = oProviderFactory.CreateDataAdapter();
            DbCommand cmd = conn.CreateCommand();

            DbDataReader rdr = default(DbDataReader);

            try
            {
                PrepareCommand(cmd, conn, cmdType, cmdText, cmdParms);
                rdr = cmd.ExecuteReader();
                cmd.Parameters.Clear();

                if (!((cmdParms == null)))
                {
                   // DbParameter param = default(DbParameter);

                    foreach (DbParameter param in cmdParms)
                    {
                        cmd.Parameters.Add(param);
                    }
                }


                return rdr;
            }
            catch (DbException ex)
            {

                throw new Exception("SQL Exception ", ex);
            }
            catch (Exception exx)
            {
                throw new Exception("ExecuteReader", exx);
            }
            finally
            {
                cmd = null;
            }
        }
       
        public static bool PrepareCommand(DbCommand cmd, DbConnection conn, CommandType cmdType, string cmdText, DbParameter[] cmdParms)
        {
            if (!(conn.State == ConnectionState.Open))
            {
                conn.Open();
            }
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                cmd.Parameters.Clear();
                cmd.CommandType = cmdType;

                if (!((cmdParms == null)))
                {
                    //DbParameter param = default(DbParameter);

                    foreach (DbParameter param in cmdParms)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                return true;
            }
            catch (DbException ex)
            {
                throw new Exception("DB Exception ", ex);
            }
            catch (Exception exx)
            {
                throw new Exception("PrepareCommand : ", exx);
            }
        }

    }

    public enum Providers : int
    {
        Odbc = 1,
        OleDb = 2,
        SqlClient = 3,
        OracleClient = 4,
        MySql = 5
    }
    

    }

