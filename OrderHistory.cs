using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCoffee
{
    public partial class OrderHistory : Form
    {
        private Button exit;
        private ListBox orderhistorylist;
        public static string test;

        public OrderHistory(){
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; /////////////////////////////////////////////////////////////
        }

        private void InitializeComponent()
        {
            this.orderhistorylist = new System.Windows.Forms.ListBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderhistorylist
            // 
            this.orderhistorylist.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderhistorylist.FormattingEnabled = true;
            this.orderhistorylist.ItemHeight = 19;
            this.orderhistorylist.Items.AddRange(new object[] {
            ""});
            this.orderhistorylist.Location = new System.Drawing.Point(12, 12);
            this.orderhistorylist.Name = "orderhistorylist";
            this.orderhistorylist.Size = new System.Drawing.Size(600, 802);
            this.orderhistorylist.TabIndex = 1;
            this.orderhistorylist.SelectedIndexChanged += new System.EventHandler(this.orderhistorylist_SelectedIndexChanged);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit.Location = new System.Drawing.Point(12, 859);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(600, 50);
            this.exit.TabIndex = 2;
            this.exit.Text = "닫기";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // OrderHistory
            // 
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.orderhistorylist);
            this.Name = "OrderHistory";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }
        
        public void setorderhistory()
        {
            using (MySqlConnection connection = new MySqlConnection(MainForm.connectionString))
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

                            string firstLine = $"메뉴명 : {coffeename} [{coffeesize}] [{coffeetemperature}]   가격 : {coffeeprice} / [{date}]";
                            string secondLine = $"수량 : {coffeenum} / 샷 : {shotnum} / 설탕 : {sugarnum} / 헤이즐 : {hazlenum} / 카라멜 : {caranum}";
                            orderhistorylist.Items.Add(firstLine);
                            orderhistorylist.Items.Add(secondLine);
                            orderhistorylist.Items.Add(""); // 이 줄을 추가하여 각 주문 사이에 빈줄을 추가합니다.
                        }
                    }
                }
            }
        }
        private void orderhistorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }




}
