using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace DBUtility
{
    /// <summary>
    /// sql server通用数据访问类
    /// </summary>
    public class SqlHelper
    {
        //封装数据库连接字符串
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        #region 封装格式化SQL语句执行的各种方法
        /// <summary>
        /// 执行insert、delete、update操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                WriteErrorLog(ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// 返回数据集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            //创建数据适配器
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //创建内存数据集
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 封装带参数SQL语句执行的各种方法
        /// <summary>
        /// 执行insert、delete、update操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, SqlParameter[] sqlParameters = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, SqlParameter[] sqlParameters = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql,SqlParameter[] sqlParameters=null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                WriteErrorLog(ex.Message);
                throw ex;
            }
        }


        /// <summary>
        /// 返回数据集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql,SqlParameter[] sqlParameters = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            //创建数据适配器
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //创建内存数据集
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        #endregion

        #region 封装调用存储过程执行的各种方法
        /// <summary>
        /// 执行insert、delete、update操作
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="sqlParameters"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, SqlParameter[] sqlParameters = null,bool isProcedure=false)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="sqlParameters"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, SqlParameter[] sqlParameters = null,bool isProcedure = false)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="sqlParameters"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string cmdText, SqlParameter[] sqlParameters = null, bool isProcedure = false)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                WriteErrorLog(ex.Message);
                throw ex;
            }
        }
        #endregion

        #region 返回数据集查询（包括单张数据表以及多张数据表）
        /// <summary>
        /// 执行返回数据集的查询（针对一张数据表）
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="sqlParameters"></param>
        /// <param name="tableName"></param>
        /// <param name="isProcedure"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string cmdText, SqlParameter[] sqlParameters = null, string tableName = null, bool isProcedure = false)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            if (isProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            //创建数据适配器
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //创建内存数据集
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                if (tableName != null)
                {
                    adapter.Fill(ds, tableName);
                }
                else
                {
                    adapter.Fill(ds);
                }

                return ds;
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 使用DataSet存储查询的结果（针对多张数据表）
        /// </summary>
        /// <param name="sqlAndTableName"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(Dictionary<string, string> sqlAndTableName)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //创建数据适配器
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //创建内存数据集
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                foreach (var tableName in sqlAndTableName.Keys)
                {
                    cmd.CommandText = sqlAndTableName[tableName];
                    adapter.Fill(ds, tableName);
                }
                return ds;
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 执行事务：提交多条不带参数的sql语句以及提交多条带参数的sql语句，适合主从表的关系
        /// <summary>
        /// 开启事务：提交多条不带参数的sql语句
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns></returns>
        public static bool ExecuteTransation(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                foreach (var sql in sqlList)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//回滚事务
                }
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;//清空事务
                }
                conn.Close();
            }
        }

        /// <summary>
        /// 启用事务，提交多条带参数的sql语句，适合主从表的关系
        /// </summary>
        /// <param name="mainSql"></param>
        /// <param name="mainParam"></param>
        /// <param name="detailSql"></param>
        /// <param name="detailParam"></param>
        /// <returns></returns>
        public static bool ExecuteTransation(string mainSql, SqlParameter[] mainParam, string detailSql, List<SqlParameter[]> detailParam)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                //执行主表操作
                if (mainSql != null && mainSql.Length != 0)
                {
                    cmd.Parameters.AddRange(mainParam);
                    cmd.CommandText = mainSql;
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = detailSql;
                foreach (SqlParameter[] sqlParameters in detailParam)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(sqlParameters);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//回滚事务
                }
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;//清空事务
                }
                conn.Close();
            }
        }

        /// <summary>
        /// 启用事务：调用单参数的存储过程
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="paramArray">存储过程参数数组集合</param>
        /// <returns>返回基于事务的存储过程是否调用成功</returns>
        public static bool ExecuteTransation(string procedureName, List<SqlParameter[]> paramArray)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedureName;
                cmd.Transaction = conn.BeginTransaction();
                foreach (SqlParameter[] sqlParameters in paramArray)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(sqlParameters);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//回滚事务
                }
                WriteErrorLog(ex.Message);
                throw ex;
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;//清空事务
                }
                conn.Close();
            }
        }
        #endregion

        #region 获取数据库服务器时间
        /// <summary>
        /// 获取数据库服务器时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetDbServerTime()
        {
            return Convert.ToDateTime(ExecuteScalar("select getdate()"));
        }
        #endregion

        #region 日志记录
        private static void WriteErrorLog(string msg)
        {
            FileStream fs = new FileStream("Error.log", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("【" + GetDbServerTime() + "】：" + msg+"\r\n");
            sw.Close();
        }
        #endregion

    }
}
