using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOPCoffee
{
    public partial class MainForm : Form
    {
        private Button BtnOrderInStore;
        private Button BtnOrderTakeout;
        private Label coffeeName;
        private Button orderhistory;

        public static String ordertype = "";

        public static string connectionString = "server=192.168.0.5;user=newuser;database=oopcafe;port=3306;password=11111111!";
        /*bool isConnected = TestConnection(connectionString);*/
        public static DataTable dataTable = LoadTable(connectionString, "orderhistory");

        public static DataTable LoadTable(string connectionString, string tableName)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName}";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        public static bool TestConnection(string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" 연결이 실패했습니다 ");

                    Console.WriteLine("Database connection error: " + ex.Message);
                    return false;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; /////////////////////////////////////////////////////////////
            
        }

        private void InitializeComponent()
        {
            this.coffeeName = new System.Windows.Forms.Label();
            this.BtnOrderInStore = new System.Windows.Forms.Button();
            this.BtnOrderTakeout = new System.Windows.Forms.Button();
            this.orderhistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coffeeName
            // 
            this.coffeeName.AutoSize = true;
            this.coffeeName.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffeeName.Location = new System.Drawing.Point(160, 190);
            this.coffeeName.Name = "coffeeName";
            this.coffeeName.Size = new System.Drawing.Size(294, 64);
            this.coffeeName.TabIndex = 0;
            this.coffeeName.Text = "OOP카페";
            this.coffeeName.Click += new System.EventHandler(this.coffeeName_Click);
            // 
            // BtnOrderInStore
            // 
            this.BtnOrderInStore.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnOrderInStore.Location = new System.Drawing.Point(92, 623);
            this.BtnOrderInStore.Name = "BtnOrderInStore";
            this.BtnOrderInStore.Size = new System.Drawing.Size(150, 80);
            this.BtnOrderInStore.TabIndex = 1;
            this.BtnOrderInStore.Text = "매장 주문";
            this.BtnOrderInStore.UseVisualStyleBackColor = true;
            this.BtnOrderInStore.Click += new System.EventHandler(this.BtnOrderInStore_Click);
            // 
            // BtnOrderTakeout
            // 
            this.BtnOrderTakeout.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnOrderTakeout.Location = new System.Drawing.Point(383, 623);
            this.BtnOrderTakeout.Name = "BtnOrderTakeout";
            this.BtnOrderTakeout.Size = new System.Drawing.Size(150, 80);
            this.BtnOrderTakeout.TabIndex = 2;
            this.BtnOrderTakeout.Text = "포장 주문";
            this.BtnOrderTakeout.UseVisualStyleBackColor = true;
            this.BtnOrderTakeout.Click += new System.EventHandler(this.BtnOrderTakeout_Click);
            // 
            // orderhistory
            // 
            this.orderhistory.Location = new System.Drawing.Point(537, 12);
            this.orderhistory.Name = "orderhistory";
            this.orderhistory.Size = new System.Drawing.Size(75, 23);
            this.orderhistory.TabIndex = 3;
            this.orderhistory.Text = "주문내역";
            this.orderhistory.UseVisualStyleBackColor = true;
            this.orderhistory.Click += new System.EventHandler(this.orderhistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.orderhistory);
            this.Controls.Add(this.BtnOrderTakeout);
            this.Controls.Add(this.BtnOrderInStore);
            this.Controls.Add(this.coffeeName);
            this.Location = new System.Drawing.Point(1000, 100);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            /// ///////////////////////////////////////////////////////////////// ///////////////////////////////////////////////////////////////// //////////////////////////////////////////////////////////////
            // 데이터베이스 연결 확인

           /* if (isConnected)
            {
                Console.WriteLine("Connected successfully to the database!");
                // 테이블의 데이터 행을 출력
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine("--- Row ---");
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        Console.WriteLine($"{column.ColumnName}: {row[column]}");
                    }

                }
            }
            else
            {
                Console.WriteLine(" Failed to connect to the database. Check the connectionString or DB settings.");
            }*/
        }

   
        /// ///////////////////////////////////////////////////////////////// ///////////////////////////////////////////////////////////////// //////////////////////////////////////////////////////////////

        private void coffeeName_Click(object sender, EventArgs e)
        {
            
        }

     
        private void BtnOrderInStore_Click(object sender, EventArgs e)
        {
            ordertype = "매장 주문";
            Console.WriteLine(ordertype);
            MenuForm menuform = new MenuForm();
            menuform.Show();
            this.Hide();
        }

        private void BtnOrderTakeout_Click(object sender, EventArgs e)
        {
            ordertype = "매장 주문";
            MenuForm menuform = new MenuForm();
            menuform.Show();
            this.Hide();
        }


        public static void InsertOrderHistory(string coffeename, int coffeeprice, int coffeenum, int shotnum, int sugarnum, int hazlenum, int caranum, string coffeesize, string coffeetemperature, string date)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sqlCommand = "INSERT INTO orderhistory (coffeename, coffeeprice, coffeenum, shotnum, sugarnum, hazlenum, caranum, coffeesize, coffeetemperature, date) VALUES (@coffeename, @coffeeprice, @coffeenum, @shotnum, @sugarnum, @hazlenum, @caranum, @coffeesize, @coffeetemperature, @date)";

                using (MySqlCommand command = new MySqlCommand(sqlCommand, connection))
                {

                    command.Parameters.AddWithValue("@coffeename", coffeename);
                    command.Parameters.AddWithValue("@coffeeprice", coffeeprice);
                    command.Parameters.AddWithValue("@coffeenum", coffeenum);
                    command.Parameters.AddWithValue("@shotnum", shotnum);
                    command.Parameters.AddWithValue("@sugarnum", sugarnum);
                    command.Parameters.AddWithValue("@hazlenum", hazlenum);
                    command.Parameters.AddWithValue("@caranum", caranum);
                    command.Parameters.AddWithValue("@coffeesize", coffeesize);
                    command.Parameters.AddWithValue("@coffeetemperature", coffeetemperature);
                    command.Parameters.AddWithValue("@date", date);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void LoadOrderHistory()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sqlCommand = "SELECT coffeename, coffeeprice, coffeenum, shotnum, sugarnum, hazlenum, caranum, coffeesize, coffeetemperature, date FROM orderhistory";

                using (MySqlCommand command = new MySqlCommand(sqlCommand, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string coffeename = reader["coffeename"].ToString();
                            int coffeeprice = Convert.ToInt32(reader["coffeeprice"]);
                            int coffeenum = Convert.ToInt32(reader["coffeenum"]);
                            int shotnum = Convert.ToInt32(reader["shotnum"]);
                            int sugarnum = Convert.ToInt32(reader["sugarnum"]);
                            int hazlenum = Convert.ToInt32(reader["hazlenum"]);
                            int caranum = Convert.ToInt32(reader["caranum"]);
                            string coffeesize = reader["coffeesize"].ToString();
                            string coffeetemperature = reader["coffeetemperature"].ToString();
                            string date = reader["date"].ToString();

                            Console.WriteLine($"Coffee Name: {coffeename}, Coffee Price: {coffeeprice}, Coffee Quantity: {coffeenum}, Shot Num: {shotnum}, Sugar Num: {sugarnum}, Hazlenut Num: {hazlenum}, Cacao Num: {caranum}, Coffee Size: {coffeesize}, Coffee Temperature: {coffeetemperature}, Date: {date}");
                        }
                    }
                }
            }
        }
        private void orderhistory_Click(object sender, EventArgs e)
        {
            OrderHistory orderHistory = new OrderHistory();
            orderHistory.setorderhistory();
            orderHistory.Show();
            this.Hide();
        }
    }
}
