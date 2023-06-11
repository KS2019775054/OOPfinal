using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
public partial class MenuForm : Form
{
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox6;
    private Label price1;
    private Label menu2;
    private Label price2;
    private Label menu3;
    private Label menu4;
    private Label price3;
    private Label price4;
    private Label menu5;
    private Label menu6;
    private Label price5;
    private Label price6;
    private Panel panel1;
    private Label allprice;
    private ListBox menuorderlist;
    private Button BtnCheckout;
    private Label menu1;





    /*public static LinkedList<string> orderlist = new LinkedList<string>();*/

    public class Menuclass
    {
        public String coffeename;
        public int coffeeprice;
        public int coffeenum;
        public int shotnum;
        public int sugarnum;
        public int hazlenum;
        public int caranum;
        public string coffeetemperature;
        public string coffeesize;
        public Menuclass(string coffeename, int coffeeprice, int coffeenum, int shotnum, int sugarnum, int hazlenum, int caranum, string coffeesize, string coffeetemperature)
        {
            this.coffeename = coffeename;
            this.coffeeprice = coffeeprice;
            this.coffeenum = coffeenum;
            this.shotnum = shotnum;
            this.sugarnum = sugarnum;
            this.hazlenum = hazlenum;
            this.caranum = caranum;
            this.coffeesize = coffeesize;
            this.coffeetemperature = coffeetemperature;
           
        }
    }

    public static LinkedList<Menuclass> orderlist = new LinkedList<Menuclass>();


    public MenuForm()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen; /////////////////////////////////////////////////////////////
    }


  

    private void InitializeComponent()
    {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.menu1 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.menu2 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.menu3 = new System.Windows.Forms.Label();
            this.menu4 = new System.Windows.Forms.Label();
            this.price3 = new System.Windows.Forms.Label();
            this.price4 = new System.Windows.Forms.Label();
            this.menu5 = new System.Windows.Forms.Label();
            this.menu6 = new System.Windows.Forms.Label();
            this.price5 = new System.Windows.Forms.Label();
            this.price6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.allprice = new System.Windows.Forms.Label();
            this.menuorderlist = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ImageLocation = "./image/Americano.png";
            this.pictureBox1.Location = new System.Drawing.Point(97, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ImageLocation = "./image/Americano.png";
            this.pictureBox2.Location = new System.Drawing.Point(371, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.ImageLocation = "./image/Americano.png";
            this.pictureBox3.Location = new System.Drawing.Point(97, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.ImageLocation = "./image/Americano.png";
            this.pictureBox4.Location = new System.Drawing.Point(371, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.ImageLocation = "./image/Americano.png";
            this.pictureBox5.Location = new System.Drawing.Point(97, 477);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.ImageLocation = "./image/Americano.png";
            this.pictureBox6.Location = new System.Drawing.Point(371, 477);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 150);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // menu1
            // 
            this.menu1.AutoSize = true;
            this.menu1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu1.Location = new System.Drawing.Point(115, 191);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(115, 21);
            this.menu1.TabIndex = 1;
            this.menu1.Text = "아메리카노";
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price1.Location = new System.Drawing.Point(146, 212);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(49, 19);
            this.price1.TabIndex = 2;
            this.price1.Text = "3200";
            // 
            // menu2
            // 
            this.menu2.AutoSize = true;
            this.menu2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu2.Location = new System.Drawing.Point(395, 191);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(94, 21);
            this.menu2.TabIndex = 1;
            this.menu2.Text = "카페모카";
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price2.Location = new System.Drawing.Point(426, 212);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(49, 19);
            this.price2.TabIndex = 2;
            this.price2.Text = "3900";
            // 
            // menu3
            // 
            this.menu3.AutoSize = true;
            this.menu3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu3.Location = new System.Drawing.Point(115, 404);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(94, 21);
            this.menu3.TabIndex = 1;
            this.menu3.Text = "카페라떼";
            // 
            // menu4
            // 
            this.menu4.AutoSize = true;
            this.menu4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu4.Location = new System.Drawing.Point(400, 404);
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(94, 21);
            this.menu4.TabIndex = 1;
            this.menu4.Text = "카푸치노";
            // 
            // price3
            // 
            this.price3.AutoSize = true;
            this.price3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price3.Location = new System.Drawing.Point(146, 425);
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(49, 19);
            this.price3.TabIndex = 2;
            this.price3.Text = "3700";
            // 
            // price4
            // 
            this.price4.AutoSize = true;
            this.price4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price4.Location = new System.Drawing.Point(426, 425);
            this.price4.Name = "price4";
            this.price4.Size = new System.Drawing.Size(49, 19);
            this.price4.TabIndex = 2;
            this.price4.Text = "3700";
            // 
            // menu5
            // 
            this.menu5.AutoSize = true;
            this.menu5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu5.Location = new System.Drawing.Point(115, 630);
            this.menu5.Name = "menu5";
            this.menu5.Size = new System.Drawing.Size(115, 21);
            this.menu5.TabIndex = 1;
            this.menu5.Text = "아인슈페너";
            // 
            // menu6
            // 
            this.menu6.AutoSize = true;
            this.menu6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu6.Location = new System.Drawing.Point(395, 630);
            this.menu6.Name = "menu6";
            this.menu6.Size = new System.Drawing.Size(115, 21);
            this.menu6.TabIndex = 1;
            this.menu6.Text = "바닐라라떼";
            // 
            // price5
            // 
            this.price5.AutoSize = true;
            this.price5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price5.Location = new System.Drawing.Point(146, 651);
            this.price5.Name = "price5";
            this.price5.Size = new System.Drawing.Size(49, 19);
            this.price5.TabIndex = 2;
            this.price5.Text = "3700";
            // 
            // price6
            // 
            this.price6.AutoSize = true;
            this.price6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price6.Location = new System.Drawing.Point(426, 651);
            this.price6.Name = "price6";
            this.price6.Size = new System.Drawing.Size(49, 19);
            this.price6.TabIndex = 2;
            this.price6.Text = "3900";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnCheckout);
            this.panel1.Controls.Add(this.allprice);
            this.panel1.Controls.Add(this.menuorderlist);
            this.panel1.Location = new System.Drawing.Point(12, 689);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 223);
            this.panel1.TabIndex = 3;
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCheckout.Location = new System.Drawing.Point(434, 16);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(148, 148);
            this.BtnCheckout.TabIndex = 4;
            this.BtnCheckout.Text = "결제하기";
            this.BtnCheckout.UseVisualStyleBackColor = true;
            this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // allprice
            // 
            this.allprice.AutoSize = true;
            this.allprice.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allprice.Location = new System.Drawing.Point(9, 178);
            this.allprice.Name = "allprice";
            this.allprice.Size = new System.Drawing.Size(100, 32);
            this.allprice.TabIndex = 1;
            this.allprice.Text = "가격 :";
            this.allprice.Click += new System.EventHandler(this.allprice_Click);
            // 
            // menuorderlist
            // 
            this.menuorderlist.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuorderlist.FormattingEnabled = true;
            this.menuorderlist.Location = new System.Drawing.Point(15, 16);
            this.menuorderlist.Name = "menuorderlist";
            this.menuorderlist.Size = new System.Drawing.Size(400, 134);
            this.menuorderlist.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.price6);
            this.Controls.Add(this.price4);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price5);
            this.Controls.Add(this.price3);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.menu6);
            this.Controls.Add(this.menu4);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menu5);
            this.Controls.Add(this.menu3);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void MenuForm_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        DetailMenuForm detailMenuform = new DetailMenuForm();
        detailMenuform.setMenuname("아메리카노");
        detailMenuform.setPrice(3200);
        detailMenuform.Show();
        this.Hide();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        DetailMenuForm detailMenuform = new DetailMenuForm();
        detailMenuform.setMenuname("카페모카");
        detailMenuform.setPrice(3900);
        detailMenuform.Show();
        this.Hide();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        DetailMenuForm detailMenuform = new DetailMenuForm();
        detailMenuform.setMenuname("카페라떼");
        detailMenuform.setPrice(3700);
        detailMenuform.Show();
        this.Hide();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
        DetailMenuForm detailMenuform = new DetailMenuForm();
        detailMenuform.setMenuname("카푸치노");
        detailMenuform.setPrice(3700);
        detailMenuform.Show();
        this.Hide();
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
        DetailMenuForm detailMenuform = new DetailMenuForm();
        detailMenuform.setMenuname("아인슈페너");
        detailMenuform.setPrice(3700);
        detailMenuform.Show();
        this.Hide();
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
        DetailMenuForm detailMenuform = new DetailMenuForm();
        detailMenuform.setMenuname("바닐라라떼");
        detailMenuform.setPrice(3900);
        detailMenuform.Show();
        this.Hide();
    }

    private void BtnCheckout_Click(object sender, EventArgs e)
    {
        OrderConfirmForm orderConfirmForm = new OrderConfirmForm();
        orderConfirmForm.Show();
        orderConfirmForm.setorderchecklist();
        orderConfirmForm.setorderprice();
        orderConfirmForm.setsaleorderprice();
        orderConfirmForm.setallorderprice();


        this.Hide();
        

    }

    public void setmenuorderlist()
    {
        menuorderlist.Items.Clear();
        
        foreach (Menuclass item in orderlist)
        {
            string str = item.coffeename + " [" + item.coffeetemperature + "]" + " [" + item.coffeesize + "]";
            
            while (str.Length < 18)
            {
                str = str + " " + " " + " ";
            }

            string liststr1 = "메뉴명 : " + str +  "                     가격 : "+ item.coffeeprice;
            string liststr2 = "수량 : " + item.coffeenum + " /  샷 : " + item.shotnum + " /  설탕 : " + item.sugarnum + " / 헤이즐 : " + item.hazlenum + " / 카라멜 : " + item.caranum;
            menuorderlist.Items.Add(liststr1);
            menuorderlist.Items.Add(liststr2);
            menuorderlist.Items.Add("");
        }

    }
    public void setallprice()
    {
        int price = 0;
        foreach (Menuclass item in orderlist)
        {
            price += item.coffeeprice;
        }
        this.allprice.Text = "가격 : " + price;

    }

    private void allprice_Click(object sender, EventArgs e)
    {

    }

    /*    public String coffeename;
        public int coffeeprice;
        public int coffeenum;
        public int shotnum;
        public int sugarnum;
        public int hazlenum;
        public int caranum;
        public string coffeetemperature;
        public string coffeesize;*/
}