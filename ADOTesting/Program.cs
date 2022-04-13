using System;

namespace ADOTesting
{
    internal class Program
    {
        static void Main(string[] args) //old
        {
            int i;
            double d;

            i =10
                d = 3.14159
                // Step 0: Declare a interface variable

                System.data.IDbConnection conn;
                //conn = new Microsoft.DataSqlite.SqliteConnection()  //sqllite
                conn = new Mysql.Data.MySqlClient.MySqlConnection()   //mysql
                //conn = new System.Data.SqlClient.SqlConnection()     //sqlserver
                // Step 1 : Pick a Provider.   That is a specific database Vendor
                
                conn.ConnectionString
                // STEP 2: Configure your
                //     a:connectionstrings.com

            conn.connectionstrings = Server = myServerAddress; Database = myDataBase; Uid = myUsername; Pwd = myPassword;         //127.0.0.
            conn.
             console.writeline(conn.state);          
            conn.open();
            Console.WriteLine(conn.state);
         // var t = conn.BegingTransaction();

            //Console.WriteLine("Hello World!");

            //STEP 3: Use the connectin to get access to a command object

            System.Data.IDbCommand cmd = conn.CreateCommand():  // or
                // varcmd =Conn.CreateCOmmand():

                // Step 4: Configure a COmmand Type
                        //   a: choose a COmmand Type
                  //    the command TYPE establishes how to  INTERPRET  the  COmmand Text
                cmd.CommandType = System.Data.CommandType.Text;

                // b: set a Command Text
                cmd.CommandText = "Select " from Movies where minutes> @P1""
                // c: Add any Parameters


            // STEP 5: Optional if you have parameters
            // Use the command object to create each parameter

            var P1 = cmd.CreateParameter();
            //  Step 5a; configure each parameter
            P1.Direction = System.Data.ParameterDirection.Input;
            P.Direction = System.Data.ParamterDirection.Input;
            P1.Value = 30;
            // P1.DbType = System.Data.DbType
            //  Steb 5b:  Add teh configured parameter to the list of all parameters

            cmd.Parameters.Add().(P1);  // required to ADD P before Creating anotherParameter
            P1 = cmd.CreateParameter();
            P.Direction = System.Data.ParameterDirection.Input;
            P1.ParameterName = "@P2"
             P.value = 0;
            //cmd.Parameters.Add(P);  // if you forget this step, the paramter is not added to the command
            // Step 6: EXECUTE The Command

            // There are THree versions of Execute

            //  ExecuteNonQuery()    returns an Interger   (int)
            // ExecuteScalar();   returns an Object   (object)
            //  ExecuteReader();    returns a set of records  (IdataReader)

            //var rv = cmd.ExecuteNonQuery();

            var rv = cmd.ExecuteScalar();
            {
                while (rv.Read())
                {
                    //for (int c =0; c < rv.FieldCount; c++)
                    //{
                    //  Console.WriteLine(rv[c]) ;
                    // Console.Write(' ');

                    //}
                    Console.WriteLine(rv["Title"]);
                    Console.WriteLine(rv["minutes]);
                        Console.WriteLine();

                }
                Console.WriteLine(******************************************)
           

                    //}while (rv.NextResult()0;


                // IdataReader
                //FieldCount   an Integer representing the number of columns
                //TWO indexers
                //     rv[i}  where i is an integer: represents the column offset starting with 0
                //  rv[s]   where s is a string :  represents the column name as a string. 
                    
               // Getname (int i) where i is the offset of a column. returns the name of the specified column as a string
               // GetOrdinal(string s) where s is the name of a column. returns the offset of the specified column
               //
               // Read()   returns a bool letting you know that a record was loaded (true) or not (false)

                    
                    }





                    {

                    }
                }
            }

              while(rv.Read()

            Console.WriteLine(r[]);


        }
    }
}
