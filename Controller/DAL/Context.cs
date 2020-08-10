using DBConnection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DAL
{
    public static class Context
    {
        #region Variable Declarations

        static SQL _sql = new SQL();

        #endregion

        #region Accessors

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
        }

        /// <summary>
        /// This method will return all records from the specified database table.
        /// </summary>
        /// <param name="tableName">The database table name where the records will come from.</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string tableName)
        {
            return _sql.GetDataTable(ConnectionString, tableName);
        }

        /// <summary>
        /// This method will return the records based on the specified SQL query.
        /// </summary>
        /// <param name="sqlQuery">The SELECT query that will be used to filter the records</param>
        /// <param name="tableName">The database table name where the records will come from.</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sqlQuery, string tableName)
        {
            return _sql.GetDataTable(ConnectionString, sqlQuery, tableName);
        }

        /// <summary>
        /// This method will return the records based on the specified SQL query.
        /// </summary>
        /// <param name="sqlQuery">The SELECT query that will be used to filter the records</param>
        /// <param name="tableName">The database table name where the records will come from.</param>
        /// <param name="isReadOnly">To indicate whether the returned database table is updateable or not.</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sqlQuery, string tableName, bool isReadOnly)
        {
            return _sql.GetDataTable(ConnectionString, sqlQuery, tableName, isReadOnly);
        }

        #endregion

        #region Mutators

        public static void SaveDatabaseTable(DataTable table)
        {
            _sql.SaveDatabaseTable(ConnectionString, table);
        }

        public static int InsertParentTable(string tableName, string columnNames, string columnValues)
        {
            return _sql.InsertParentRecord(ConnectionString, tableName, columnNames, columnValues);
        }

        public static void DeleteRecord(string tableName, string PKName, string PKID)
        {
            _sql.DeleteRecord(ConnectionString, tableName, PKName, PKID);
        }

        #endregion

        #region Helper Methods

        #endregion
    }
}
