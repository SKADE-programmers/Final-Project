using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Scott Stratton
namespace DataLibrary
{
    public class Commands
    {

        public static void CreateEmployee(string Fname, string Lname, int PosID, string login, string pass)
        {
            
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            Fname = "'" + Fname + "'";
            Lname = "'" + Lname + "'";
            login = "'" + login + "'";
            pass = "'" + pass + "'";

            command.Connection = Data.con;
            command.CommandText = "INSERT INTO employee (empFirst, empLast, posID)" +
                                    "VALUES (" + Fname + "," + Lname + "," + PosID + "); SELECT SCOPE_IDENTITY();";
            try
            {
                Data.con.Open();
                int result = Convert.ToInt32(command.ExecuteScalar());

                string res = "'" + result.ToString() + "'";

                command.CommandText = "INSERT INTO logins(empID, logUser, logPass) VALUES(" + res + "," + login + "," + pass + ")";
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }


            

        }

        public static void UpdateEmployee(string Fname, string Lname, int PosID, string login, string pass, int id)
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            Fname = "'" + Fname + "'";
            Lname = "'" + Lname + "'";
            login = "'" + login + "'";
            pass = "'" + pass + "'";

            command.Connection = Data.con;
            command.CommandText = "UPDATE employee SET empFirst =" + Fname + " , empLast = " + Lname + ", posID =" + PosID + " WHERE (id = " + id + ")";

            try
            {
                Data.con.Open();
                command.ExecuteNonQuery();
                command.CommandText = "UPDATE logins SET logUser = " + login + ", logPass = " + pass + " WHERE (empID  = " + id + ")";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }
        }

        public static void DeleteEmployee(int id)
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            command.Connection = Data.con;
            command.CommandText = "DELETE FROM logins WHERE(empID = "+ id+")";
            try
            {
                Data.con.Open();
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM employee WHERE(id = "+ id +")";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }


        }

        public static void CreateCustomer(string FirstName, string LastName, string Phone, string Address, string City, string Postal, string Email)
        {
            
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            FirstName = "'" + FirstName + "'";
            LastName = "'" + LastName + "'";
            Phone = "'" + Phone + "'";
            Address = "'" + Address + "'";
            City = "'" + City + "'";
            Postal = "'" + Postal + "'";
            Email = "'" + Email + "'";

            command.Connection = Data.con;
            command.CommandText = "INSERT INTO customer (custFirst, custLast, custPhone, custAddress, custCity, custPostal, custEmail) VALUES("+ FirstName + ","+ LastName + " ,"+ Phone + " ,"+ Address + " ,"+ City + " ,"+ Postal + " ,"+ Email + " )";
            try
            {
                Data.con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }            
        }

        public static void UpdateCustomer(string FirstName, string LastName, string Phone, string Address, string City, string Postal, string Email, int id)
        {

            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            FirstName = "'" + FirstName + "'";
            LastName = "'" + LastName + "'";
            Phone = "'" + Phone + "'";
            Address = "'" + Address + "'";
            City = "'" + City + "'";
            Postal = "'" + Postal + "'";
            Email = "'" + Email + "'";

            command.Connection = Data.con;
            command.CommandText = "UPDATE customer SET custFirst = " + FirstName + ", custLast = " + LastName + ", custPhone =" + Phone + " , custAddress = " + Address + ", custCity = " + City + ", custPostal = " + Postal + ", custEmail = " + Email + " WHERE (id = "+id+" )";
            try
            {
                Data.con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }
        }

        public static void DeleteCustomer(int id)
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            command.Connection = Data.con;
            command.CommandText = "DELETE FROM  customer  WHERE(id = " + id + ")";
            try
            {
                Data.con.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }


        }

        public static void AddEquipment(string model, string serial, int custID, int equtypeID, int manuID)
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            model = "'" + model + "'";
            serial = "'" + serial + "'";
            command.Connection = Data.con;
            command.CommandText = "INSERT INTO equipment (equModel, equSerial, custID, equtypeID, equManuID ) VALUES(" + model + "," + serial + " ," + custID + " ," + equtypeID + " ," + manuID + " )";
            try
            {
                Data.con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }
        }

        public static void CreateSale(string orderNum, DateTime ordDate, int ordPaid, int paymentID, int custID, int empID)
        {
            //wip

        }

        public static void UpdateSale(string orderNum, DateTime ordDate, int ordPaid, int paymentID, int custID, int empID, int saleID)
        {
            //wip
        }

        public static void UpdateInventoryCount(int count, int inventoryID) 
        {
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();

            command.Connection = Data.con;
            command.CommandText = "UPDATE inventory SET invQuantity = " + count + " WHERE (id = " + inventoryID + " )";
            try
            {
                Data.con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (Data.con.State == System.Data.ConnectionState.Open)
                {
                    Data.con.Close();
                }
            }


        }

        public static void placeOrder(string orderNum, DateTime date, bool paid) { }

        public static void UpdateRequest( ) 
        {

        }


    }
}
