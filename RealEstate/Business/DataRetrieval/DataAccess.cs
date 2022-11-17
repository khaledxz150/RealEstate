using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Configuration;


namespace Business.DataRetrieval
{
    public class DataAccess :Disposer
    {
        public static string GenerateCommandText(string storedProcedure, SqlParameter[] parameters)
        {
            string CommandText = "EXEC {0} {1}";
            string[] ParameterNames = new string[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterNames[i] = parameters[i].ParameterName;
            }

            return string.Format(CommandText, storedProcedure, string.Join(",", ParameterNames));
        }



        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public static string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; }
        }

        public static string sqlConnection;
        public DataAccess()
        {
            sqlConnection = connectionString;
        }

        public static int ErrorID;
        public List<SqlParameter> LstSqlParameter = new List<SqlParameter>();
        public List<T> ExcuteReader<T>(string storedProcedure, CommandType Type = CommandType.StoredProcedure)
        {

            List<T> returnList = new List<T>();
            using (SqlConnection Con = new SqlConnection(sqlConnection))
            {
                SqlCommand command = new SqlCommand(storedProcedure, Con);
                command.CommandType = Type;
                command.Parameters.Clear();
                if (LstSqlParameter.Count > 0)
                {
                    command.Parameters.AddRange(LstSqlParameter.ToArray());
                }

                if (Con.State == ConnectionState.Closed || Con.State == ConnectionState.Broken)
                {
                    Con.Open();
                }

                var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    ErrorID = (returnParameter.Value != null) ? (int)returnParameter.Value : 0;
                    if (ErrorID == 0)
                    {
                        if (dr.HasRows)
                        {
                            Con.Close();
                            return returnList = DataReaderMapToList<T>(dr);
                        }
                    }
                    else
                    {
                        Con.Close();
                        return null;
                    }
                }
                return null;
            }
        }
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);

            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}