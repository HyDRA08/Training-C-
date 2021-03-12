//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;
//using Dapper;

//namespace WebAPI.Models
//{
//    public class MakersPortalRepository
//    {
//        private string DBConnectionString;

//        public MakersPortalRepository()
//        {
//            DBConnectionString = "Data Source=QB-TP-240\\SQLSERVER2016;Initial Catalog=faredge_20181130;User ID=SA;Password=qburst";
//        }

//        public IDbConnection Connection
//        {
//            get
//            {
//                return new SqlConnection(DBConnectionString);
//            }
//        }

//        //CURD Operations for User

//        public void AddUser(User user)
//        {
//            using(IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "insert into AngCore_User (UserName,UserPassword) values (@UserName,@UserPassword)";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL,user);
//            }
//        }

//        public User GetUserByID(int id)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "select * from AngCore_User where UserID=@Id";
//                dbConnection.Open();
//                return dbConnection.Query<User>(strSQL, new { Id = id }).FirstOrDefault(); 
//            }
//        }

//        public IEnumerable<User> GetAllUser()
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "select * from AngCore_User";
//                dbConnection.Open();
//                return dbConnection.Query<User>(strSQL);
//            }
//        }

//        //public void UpdateUser(User user)
//        //{
//        //    using (IDbConnection dbConnection = Connection)
//        //    {
//        //        string strSQL = "Update AngCore_User set UserName=@UserNameUserPassword values (,@UserPassword)";
//        //        dbConnection.Open();
//        //        dbConnection.Execute(strSQL, user);
//        //    }
//        //}

//        public void DeleteUser(int id)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "delete from AngCore_User where UserID=@Id";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL, new { ID = id });
//            }
//        }

//        //CURD Operations for Items

//        public void AddItem(Items item)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "insert into AngCore_Items (ItemName,ItemPrice) values (@ItemName,@ItemPrice)";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL, item);
//            }
//        }

//        public Items GetItemById(int id)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "select * from AngCore_Items where ItemID=@Id";
//                dbConnection.Open();
//                return dbConnection.Query<Items>(strSQL, new { Id = id }).FirstOrDefault();
//            }
//        }

//        public IEnumerable<Items> GetAllItem()
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "select * from AngCore_Items";
//                dbConnection.Open();
//                return dbConnection.Query<Items>(strSQL);
//            }
//        }

//        public void UpdateItem(Items item)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "update AngCore_Items set ItemName=@ItemName, ItemPrice =@ItemPrice where ItemID=@ItemID";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL, item);
//            }
//        }

//        public void DeleteItem(int id)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "delete from AngCore_Items where ItemID=@Id";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL, new { ID = id });
//            }
//        }

//        //CURD Operations for Order

//        public void CreateOrder(Order order)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "insert into AngCore_Orders(OrderItemID,OrderUserID) values (@OrderItemID,@OrderUserID)";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL, order);
//            }
//        }

//        //public Items GetOrder(int id)
//        //{
//        //    using (IDbConnection dbConnection = Connection)
//        //    {
//        //        string strSQL = "select * from AngCore_Items where ItemID=@Id";
//        //        dbConnection.Open();
//        //        return dbConnection.Query<Items>(strSQL, new { Id = id }).FirstOrDefault();
//        //    }
//        //}

//        public IEnumerable<Order> GetAllOrder()
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "select * from AngCore_Orders aco inner join AngCore_User acu on aco.OrderUserID=acu.UserID";
//                dbConnection.Open();
//                return dbConnection.Query<Order>(strSQL);
//            }
//        }

//        public void UpdateOrder(Order order)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "update AngCore_Orders set OrderItemID=@OrderItemID,OrderUserID=@OrderUserID where OrderID = @OrderID ";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL, order);
//            }
//        }

//        public void DeleteOrder(int id)
//        {
//            using (IDbConnection dbConnection = Connection)
//            {
//                string strSQL = "delete from AngCore_Orders where OrderID=@Id";
//                dbConnection.Open();
//                dbConnection.Execute(strSQL, new { ID = id });
//            }
//        }
//    }
//}
