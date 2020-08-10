using DBConnection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DAL
{
    public static class Initializer
    {
        #region Variable Declarations

        static string _ConnectionString = string.Empty;
        static SQL _sql = new SQL();

        #endregion

        #region Constructors

        #endregion

        #region Accessors

        #endregion

        #region Mutators

        /// <summary>
        /// This method will create the database on the specified SQL server.
        /// </summary>
        public static void CreateDatabase()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            // call the SQL CreateDatabase method to build the database in SQL server
            _sql.CreateDatabase(_ConnectionString);
            CreateDatabaseTables();
            SeedDatabaseTables();
        }

        private static void SeedDatabaseTables()
        {
            SeedPS4();
            SeedXbox();
            //SeedSwitch();
            //SeedPC();
            SeedGenre();
            SeedPlatform();
        }

        private static void SeedPS4()
        {
            List<string> PS4g = new List<string>
            {
                "1, 'God of War', 1, 1, '2018/04/20'",
            };

            // ColumnNames must match the order of the test data above
            string columnNames = "PS4TitleId, Title, Genre, Platform, ReleaseDate";
            //To auto set platform make sure the variable ps4 is set when frmPS4 is selected 
            // Loop through the List Games and push the data to the database table
            foreach(var PS4 in PS4g)
            {
                _sql.InsertRecord(_ConnectionString, "PS4", columnNames, PS4);
            }
        }

        private static void SeedXbox()
        {
            List<string> Xboxg = new List<string>
            {
                "1, 'Halo Reach', 4, 2, '14,10,2010'"
            };

            string columnNames = "XboxTitleId, Title, Genre, Platform, ReleaseDate";

            foreach (var Xbox in Xboxg)
            {
                _sql.InsertRecord(_ConnectionString, "Xbox", columnNames, Xbox);
            }
        }

        private static void SeedPlatform()
        {
            List<string> Platforms = new List<string>
            {
                "0, 'Multi Platform'",
                "1, 'PS4'",
                "2, 'Xbox'",
                "3, 'Switch'",
                "4, 'PC'"

            };
            // ColumnNames must match the order of the test data above
            string columnNames = "PlatformId, PlatformName";

            // Loop through the List movies and push the data to the database table
            foreach(var Platform in Platforms)
            {
                _sql.InsertRecord(_ConnectionString, "Platform", columnNames, Platform);
            }
        }

        private static void SeedGenre()
        {
            List<string> Genres = new List<string>
            {
                "1, 'Adventure'",
                "2, 'RPG'",
                "3, 'Third person action'",
                "4, 'First person action'",
                "5, 'Simulation'",
                "6, 'Puzzle'",
                "7, 'Platformer",
                "8, 'Fighting'",
                "9, 'Sports'",
                "10, 'VR'",
                "11, 'Strategy'"

            };

            // ColumnNames must match the order of the test data above
            string columnNames = "GenreId, GenreName";

            // Loop through the List movies and push the data to the database table
            foreach(var Genre in Genres)
            {
                _sql.InsertRecord(_ConnectionString, "Genre", columnNames, Genre);
            }
        }


        //    #region Another way of creating and initializing a List

        //    // 
        //    //List<string> movies = new List<string>();
        //    //movies.Add("1, 'The Avengers'");
        //    //movies.Add("2, 'Star Wars'");

        //    #endregion

        //    // ColumnNames must match the order of the test data above
        //    string columnNames = "ToolId, ToolName, ToolBrand, ToolStatus, ToolNotes";

        //    // Loop through the List movies and push the data to the database table
        //    foreach(var tool in tools)
        //    {
        //        _sql.InsertRecord(_ConnectionString, "Tool", columnNames, tool);
        //    }

        //}

        //private static void SeedBrand()
        //{
        //    List<string> Brands = new List<string>
        //    {
        //        "1, 'Frost'",
        //        "2, 'Bailey'",
        //        "3, 'Stenley'",
        //        "4, 'Yamaha'",
        //        "5, 'RJ Tool'",
        //        "6, 'Super Tool'",
        //        "7, 'ROSS'",
        //        "8, 'KC Tools'",
        //        "9, 'Midwest'",
        //        "10, 'Stablia'"

        //    };

        //    // ColumnNames must match the order of the test data above
        //    string columnNames = "BrandId, BrandName";

        //    // Loop through the List movies and push the data to the database table
        //    foreach (var Brand in Brands)
        //    {
        //        _sql.InsertRecord(_ConnectionString, "Brand", columnNames, Brand);
        //    }

        //}

        //private static void SeedWorkspace()
        //{
        //    List<string> Workspaces = new List<string>
        //    {
        //        "1, 'Block A'",
        //        "2, 'Block B'",
        //        "3, 'Block C'",
        //        "4, 'Block D'",
        //        "5, 'Block E'",
        //        "6, 'Block F'"

        //    };

        //    // ColumnNames must match the order of the test data above
        //    string columnNames = "WorkspaceId, WorkspaceName";

        //    // Loop through the List movies and push the data to the database table
        //    foreach (var Workspace in Workspaces)
        //    {
        //        _sql.InsertRecord(_ConnectionString, "Workspace", columnNames, Workspace);
        //    }

        //}

        private static void CreateDatabaseTables()
        {
            // Ps4 Table Schema
            string PS4Schema =  "PS4TitleId int IDENTITY(1,1) PRIMARY KEY, " +
                                "Title VARCHAR(70), " +
                                "Genre int NOT NULL, " +
                                "ReleaseDate DATETIME NOT NULL, " +
                                "Platform BIT NOT NULL Default 1";

             // Platform Table Schema
             string PlatformSchema = "PlatformId int IDENTITY(1,1) PRIMARY KEY, " +
                                    "PlatformName VARCHAR(70)";

            // Genre Table Schema
            string GenreSchema = "GenreId int IDENTITY(1,1) PRIMARY KEY, " +
                                 "GenreName VARCHAR(20)";

            //// Rental Item Table Schema
            //string RentalItemSchema = "RentalItemId int IDENTITY(1,1) PRIMARY KEY, " +
            //                          "RentalId int NOT NULL, " +
            //                          "ToolId int NOT NULL";

            //// Brand table schema
            //string BrandSchema = "BrandId int IDENTITY(1,1) PRIMARY KEY, " +
            //                     "BrandName VARCHAR(20)";

            //// Workspace table schema
            //string WorkspaceSchema = "WorkspaceId int IDENTITY(1,1) PRIMARY KEY, " +
            //                         "WorkspaceName VARCHAR(20)";

            //Create the tables
            try
            {
                _sql.CreateDatabaseTable(_ConnectionString, "PS4", PS4Schema);
                SeedPS4();
            }
            catch (Exception)
            {
                Debug.WriteLine("Table exists so skip seeding data");
            }

            try
            {
                _sql.CreateDatabaseTable(_ConnectionString, "Platform", PlatformSchema);
                SeedPlatform();
            }
            catch (Exception)
            {
                Debug.WriteLine("Table exists so skip seeding data");
            }

            try
            {
                _sql.CreateDatabaseTable(_ConnectionString, "Genre", GenreSchema);
                SeedGenre();
            }
            catch (Exception)
            {
                Debug.WriteLine("Table exists so skip seeding data");
            }

            //try
            //{
            //    _sql.CreateDatabaseTable(_ConnectionString, "RentalItem", RentalItemSchema);
            //    SeedRentalItems();
            //}
            //catch (Exception)
            //{
            //    Debug.WriteLine("Table exists so skip seeding data");
            //}

            //try
            //{
            //    _sql.CreateDatabaseTable(_ConnectionString, "Brand", BrandSchema);
            //    SeedBrand();
            //}
            //catch (Exception)
            //{
            //    Debug.WriteLine("Table exists so skip seeding data");
            //}

            //try
            //{
            //    _sql.CreateDatabaseTable(_ConnectionString, "Workspace", WorkspaceSchema);
            //    SeedWorkspace();
            //}
            //catch (Exception)
            //{
            //    Debug.WriteLine("Table exists so skip seeding data");
            //}
        }

        #endregion

        #region Helper Methods

        #endregion
    }
}
