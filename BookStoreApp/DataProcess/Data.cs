using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace BookStoreApp
{
    class Data
    {
        private static string connectionString = "Server=tcp:yavuzucrks.database.windows.net,1433;Initial Catalog=BookStore;Persist Security Info=False;User ID=yavuzucrkss;Password=oop2_bookstore;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection = new SqlConnection(connectionString);
        

        private DataTable customerTable = new DataTable();
        private Customer customerTmp;
        private List<Customer> customers = new List<Customer>();

        private List<Product> products = new List<Product>();
        private Product productTmp;

        private List<Order> orders= new List<Order>();
        private Order order;
        private DataTable orderTable = new DataTable();

        public void productsList()
        {
            int numberofProducts = books.Count() + magazines.Count() + musics.Count();
            Random random = new Random();
            int rand = random.Next(1, 4);
            for(int i = 0; i < numberofProducts; i++)
            {

                products.Add(books[i]);

            }

        }

        private DataTable bookTable = new DataTable();       
        private List<Product> books = new List<Product>();
        private Book bookTmp;

        private DataTable magazineTable = new DataTable();
        private List<Product> magazines = new List<Product>();
        private Magazine magazineTmp;

        private DataTable musicTable = new DataTable();
        private List<Product> musics = new List<Product>();
        private MusicCD musicTmp;

        public DataTable OrderTable { get => orderTable; set => orderTable = value; }

        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public void CustomerList()
        {
            try
            {
                customerTable.Clear();
                ConnectionsStatus();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From CustomerTable", connection);
                da.Fill(customerTable);
                connection.Close();
                for (int i = 0; i < customerTable.Rows.Count; i++)
                {
                    customerTmp = new Customer(customerTable.Rows[i]["CustomerId"].ToString(), customerTable.Rows[i]["CustomerName"].ToString(), customerTable.Rows[i]["CustomerUsername"].ToString(), customerTable.Rows[i]["CustomerPassword"].ToString() , customerTable.Rows[i]["CustomerEmail"].ToString(), customerTable.Rows[i]["CustomerAddress"].ToString());
                    customers.Add(customerTmp);
                }

            }
            catch (Exception)
            {

                throw;
            }


        }
        public bool loginQuery(string username , string password) //alınan parametrelere göre giris yapılıp yapılamadığını denetler
        {
            ConnectionsStatus();
           
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from CustomerTable where CustomerUsername = @username and CustomerPassword = @password", connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }     
        public void AddCustomerQuery(Customer newcustomer)
        {
            
            if (IsValid(newcustomer.Username))
            {
                try
                {
                    ConnectionsStatus();
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CustomerTable (CustomerName,CustomerAddress,CustomerEmail,CustomerUsername,CustomerPassword) " +
                                                     "values(@name, @address, @email, @username, @password)", connection);

                    cmd.Parameters.AddWithValue("@name", newcustomer.Namesurname);
                    cmd.Parameters.AddWithValue("@address", newcustomer.Address);
                    cmd.Parameters.AddWithValue("@email", newcustomer.Email);
                    cmd.Parameters.AddWithValue("@username", newcustomer.Username);
                    cmd.Parameters.AddWithValue("@password", newcustomer.Password);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    CustomerList();
                    MessageBox.Show("Registration successful", "Information");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


              
                CustomerList();
                
            }
            else
            {
                MessageBox.Show("This username is used");
            }
      
        } //Koşullar Sql ve listeye ekleme yapar
        public bool IsValid(string username)
        {
            ConnectionsStatus();
            bool state = false;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerUsername From CustomerTable", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (username == dr[0].ToString())
                {
                    state = false;
                    break;
                }
                else
                {
                    state = true;
                }
            }
            
            return state;
        } //username kullanılıyorsa false döndürür.
        public void UpdateCustomerList(Customer customer)
        {
            try
            {
                customers.Clear();
                ConnectionsStatus();
                connection.Open();
                SqlCommand cmd = new SqlCommand("Update CustomerTable set CustomerName=@name,CustomerAddress=@address,CustomerEmail=@email,CustomerPassword=@password where CustomerId = @id", connection);
                cmd.Parameters.AddWithValue("@name", customer.Namesurname);
                cmd.Parameters.AddWithValue("@address",customer.Address);
                cmd.Parameters.AddWithValue("@email",customer.Email);            
                cmd.Parameters.AddWithValue("@password", customer.Password);   
                cmd.Parameters.AddWithValue("@id", customer.Id);   
                
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Success updated");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            


        } //ekleme işleminden sonra List<Customer>'a üyeyi ekler
        public void UpdateCustomerPass(string id,string pass)
        {
            try
            {
                customers.Clear();
                ConnectionsStatus();
                connection.Open();
                SqlCommand cmd = new SqlCommand("Update CustomerTable set CustomerPassword=@password where CustomerId = @id", connection);   
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Success updated");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }


        public List<Product> getBooks()
        {
            return books;
        }
        public void BookList()
        {
            try
            {
                bookTable.Clear();
                ConnectionsStatus();
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From BooksTable", connection);
                da.Fill(bookTable);
                connection.Close();
                for (int i = 0; i < bookTable.Rows.Count; i++)
                {
                    bookTmp = new Book(bookTable.Rows[i]["BookId"].ToString(), bookTable.Rows[i]["BookName"].ToString(),
                                   bookTable.Rows[i]["BookPrice"].ToString(), (byte[])bookTable.Rows[i]["BookImage"],
                          bookTable.Rows[i]["BookDescription"].ToString(), bookTable.Rows[i]["BookAuthor"].ToString(), bookTable.Rows[i]["BookPublisher"].ToString(),
                                   bookTable.Rows[i]["BookIsdb"].ToString(), bookTable.Rows[i]["BookPageNumber"].ToString());
                    books.Add(bookTmp);
                }             
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public void AddBook(Book book)
        {
            try
            {
                ConnectionsStatus();
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into BooksTable (BookName,BookPrice,BookImage,BookAuthor,BookPublisher,BookISBN,BookPageNumber) " +
                    "values (@name,@price,@image,@author,@publisher,@ısbn,@page", connection);
                cmd.Parameters.AddWithValue("@name", book.Name);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@image", book.Image);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@publisher", book.Publisher);
                cmd.Parameters.AddWithValue("@ısbn", book.Isdb);
                cmd.Parameters.AddWithValue("@page", book.Page);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Book added.");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        //public void UpdateBook(Book book)
        //{
        //    try
        //    {
        //        ConnectionsStatus();
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("Update BookTable set BookName=@Name,BookPrice=@Price,BookISBN=@Isbn,BookAuthor=@Author,BookPublisher=@Publisher,BookPage=@Page,BookImage=@image where BookId=@ID", connection);
        //        command.Parameters.AddWithValue("@Name", book.Name);
        //        command.Parameters.AddWithValue("@Price", book.Price);
        //        command.Parameters.AddWithValue("@Isbn", book.Isdb);
        //        command.Parameters.AddWithValue("@Author", book.Author);
        //        command.Parameters.AddWithValue("@Publisher", book.Publisher);
        //        command.Parameters.AddWithValue("@Page", book.Page);
        //        command.Parameters.AddWithValue("@image", book.Image);
        //        command.Parameters.AddWithValue("@ProductId", book.Id);
        //        command.ExecuteNonQuery();
        //        connection.Close();
        //        MessageBox.Show("Update successful");
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}



        public List<Product> getMagazines()
        {
            return magazines;
        }
        public void MagazinList()
        {
            ConnectionsStatus();
            try
            {
                connection.Open();
                magazineTable.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * From MagazinesTable", connection);
                da.Fill(magazineTable);
                connection.Close();
                for (int i = 0; i < magazineTable.Rows.Count; i++)
                {
                    magazineTmp = new Magazine(magazineTable.Rows[i]["MagazineId"].ToString(), magazineTable.Rows[i]["MagazineName"].ToString(),
                                            magazineTable.Rows[i]["MagazinePrice"].ToString(), (byte[])magazineTable.Rows[i]["MagazineImage"],
                                  magazineTable.Rows[i]["MagazineDetail"].ToString(), magazineTable.Rows[i]["MagazineType"].ToString(), magazineTable.Rows[i]["MagazineIssue"].ToString());
                    magazines.Add(magazineTmp);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }



        public List<Product> getMusics()
        {
            return musics;
        }
        public void MusicList()
        {
            ConnectionsStatus();
            try
            {
                connection.Open();
                musicTable.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * From MusicsTable", connection);
                da.Fill(musicTable);
                connection.Close();
                for (int i = 0; i < musicTable.Rows.Count; i++)
                {
                    musicTmp = new MusicCD(musicTable.Rows[i]["MusicId"].ToString(), musicTable.Rows[i]["MusicName"].ToString(),
                                        musicTable.Rows[i]["MusicPrice"].ToString(), (byte[])musicTable.Rows[i]["MusicImage"],
                                musicTable.Rows[i]["MusicDetail"].ToString(), musicTable.Rows[i]["MusicSinger"].ToString(), musicTable.Rows[i]["MusicType"].ToString());
                    musics.Add(musicTmp);
                }
            }
            catch (Exception ep)
            {

                MessageBox.Show(ep.Message);
            }
           
        }

        public List<Order> getOrders()
        {
            return orders;
        }
        public void OrdersList()
        {
            ConnectionsStatus();
            try
            {
                LoginedUser loginedUser = LoginedUser.getInstance();
                
                connection.Open();
                orderTable.Clear();
                SqlCommand cmd = new SqlCommand("Select * From OrdersTable where OrderUsername= @username", connection);
                cmd.Parameters.AddWithValue("@username", loginedUser.Customer.Username);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(OrderTable);
                connection.Close();
                for (int i = 0; i < musicTable.Rows.Count; i++)
                {
                    order = new Order(OrderTable.Rows[i]["OrderID"].ToString(), OrderTable.Rows[i]["OrderUsername"].ToString(),
                                        OrderTable.Rows[i]["OrderProduct"].ToString(), OrderTable.Rows[i]["OrderAmount"].ToString(), 
                                        musicTable.Rows[i]["OrderDate"].ToString());
                    orders.Add(order);
                }
            }
            catch (Exception ep)
            {

                
            }
        }
        public void AddOrder(Order order)
        {
            try
            {
                ConnectionsStatus();
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into OrdersTable (OrderUsername,OrderProduct,OrderAmount,OrderDate)" +
                    "values (@username,@product,@amount,@date)", connection);
                cmd.Parameters.AddWithValue("@username", order.Username);
                cmd.Parameters.AddWithValue("@product", order.Product);
                cmd.Parameters.AddWithValue("@amount", order.Amount);
                cmd.Parameters.AddWithValue("@date", order.Date);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Order added.");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public void DeleteOrder(int id)
        {

            try
            {
                ConnectionsStatus();
                connection.Open();
                SqlCommand cmd = new SqlCommand("Delete from OrdersTable where OrderId=@id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Order Canceled.");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        private void ConnectionsStatus()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        } //Connection açıksa kapatır.
    }
}
