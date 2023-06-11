using OOPCoffee;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MenuForm;

public partial class OrderConfirmForm : Form
{
    private Label orderchecklable;
    private ListBox orderchecklist;
    private Panel panel1;
    private Label allordernum;
    private Label salepricenum;
    private Label orderpricenum;
    private Label allorderlabel;
    private Label salepricelab;
    private Button nextBtn;
    private Button backBtn;
    private Button allcancleBtn;
    private Label orderpricelabel;

    int orderprice = 0;
    int saleprice = 0;

    public OrderConfirmForm()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;/////////////////////////////////////////////////////////////
    }

    // Instantiate event handlers for '+' and '-' buttons, size buttons, rest of the buttons to control quantity



    private void InitializeComponent()
    {
            this.orderchecklable = new System.Windows.Forms.Label();
            this.orderchecklist = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.allcancleBtn = new System.Windows.Forms.Button();
            this.allordernum = new System.Windows.Forms.Label();
            this.salepricenum = new System.Windows.Forms.Label();
            this.orderpricenum = new System.Windows.Forms.Label();
            this.allorderlabel = new System.Windows.Forms.Label();
            this.salepricelab = new System.Windows.Forms.Label();
            this.orderpricelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderchecklable
            // 
            this.orderchecklable.AutoSize = true;
            this.orderchecklable.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderchecklable.Location = new System.Drawing.Point(232, 9);
            this.orderchecklable.Name = "orderchecklable";
            this.orderchecklable.Size = new System.Drawing.Size(165, 37);
            this.orderchecklable.TabIndex = 0;
            this.orderchecklable.Text = "주문확인";
            // 
            // orderchecklist
            // 
            this.orderchecklist.BackColor = System.Drawing.SystemColors.Window;
            this.orderchecklist.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderchecklist.FormattingEnabled = true;
            this.orderchecklist.ItemHeight = 21;
            this.orderchecklist.Location = new System.Drawing.Point(12, 60);
            this.orderchecklist.Name = "orderchecklist";
            this.orderchecklist.Size = new System.Drawing.Size(600, 592);
            this.orderchecklist.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.allcancleBtn);
            this.panel1.Controls.Add(this.allordernum);
            this.panel1.Controls.Add(this.salepricenum);
            this.panel1.Controls.Add(this.orderpricenum);
            this.panel1.Controls.Add(this.allorderlabel);
            this.panel1.Controls.Add(this.salepricelab);
            this.panel1.Controls.Add(this.orderpricelabel);
            this.panel1.Location = new System.Drawing.Point(12, 687);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 222);
            this.panel1.TabIndex = 2;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nextBtn.Location = new System.Drawing.Point(443, 164);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(144, 55);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "다음";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backBtn.Location = new System.Drawing.Point(286, 164);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(144, 55);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "이전";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // allcancleBtn
            // 
            this.allcancleBtn.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allcancleBtn.Location = new System.Drawing.Point(21, 164);
            this.allcancleBtn.Name = "allcancleBtn";
            this.allcancleBtn.Size = new System.Drawing.Size(144, 55);
            this.allcancleBtn.TabIndex = 1;
            this.allcancleBtn.Text = "전체 취소";
            this.allcancleBtn.UseVisualStyleBackColor = true;
            this.allcancleBtn.Click += new System.EventHandler(this.allcancleBtn_Click);
            // 
            // allordernum
            // 
            this.allordernum.AutoSize = true;
            this.allordernum.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allordernum.Location = new System.Drawing.Point(389, 107);
            this.allordernum.Name = "allordernum";
            this.allordernum.Size = new System.Drawing.Size(110, 27);
            this.allordernum.TabIndex = 0;
            this.allordernum.Text = "\\ 8000";
            // 
            // salepricenum
            // 
            this.salepricenum.AutoSize = true;
            this.salepricenum.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.salepricenum.Location = new System.Drawing.Point(389, 61);
            this.salepricenum.Name = "salepricenum";
            this.salepricenum.Size = new System.Drawing.Size(62, 27);
            this.salepricenum.TabIndex = 0;
            this.salepricenum.Text = "\\ 0";
            this.salepricenum.Click += new System.EventHandler(this.label3_Click);
            // 
            // orderpricenum
            // 
            this.orderpricenum.AutoSize = true;
            this.orderpricenum.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderpricenum.Location = new System.Drawing.Point(389, 20);
            this.orderpricenum.Name = "orderpricenum";
            this.orderpricenum.Size = new System.Drawing.Size(110, 27);
            this.orderpricenum.TabIndex = 0;
            this.orderpricenum.Text = "\\ 8000";
            // 
            // allorderlabel
            // 
            this.allorderlabel.AutoSize = true;
            this.allorderlabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allorderlabel.Location = new System.Drawing.Point(36, 107);
            this.allorderlabel.Name = "allorderlabel";
            this.allorderlabel.Size = new System.Drawing.Size(129, 27);
            this.allorderlabel.TabIndex = 0;
            this.allorderlabel.Text = "주문 금액";
            // 
            // salepricelab
            // 
            this.salepricelab.AutoSize = true;
            this.salepricelab.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.salepricelab.Location = new System.Drawing.Point(36, 61);
            this.salepricelab.Name = "salepricelab";
            this.salepricelab.Size = new System.Drawing.Size(129, 27);
            this.salepricelab.TabIndex = 0;
            this.salepricelab.Text = "할인 금액";
            // 
            // orderpricelabel
            // 
            this.orderpricelabel.AutoSize = true;
            this.orderpricelabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderpricelabel.Location = new System.Drawing.Point(36, 20);
            this.orderpricelabel.Name = "orderpricelabel";
            this.orderpricelabel.Size = new System.Drawing.Size(129, 27);
            this.orderpricelabel.TabIndex = 0;
            this.orderpricelabel.Text = "주문 금액";
            // 
            // OrderConfirmForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderchecklist);
            this.Controls.Add(this.orderchecklable);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "OrderConfirmForm";
            this.Load += new System.EventHandler(this.OrderConfirmForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void OrderConfirmForm_Load(object sender, EventArgs e)
    {

    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
        PaymentMethodForm paymentMethodForm = new PaymentMethodForm();
        paymentMethodForm.Show();
        paymentMethodForm.setorderprice();
        paymentMethodForm.setsaleorderprice();
        paymentMethodForm.setallorderprice(); 
        this.Hide();
    }

    private void backBtn_Click(object sender, EventArgs e)
    {
        MenuForm menuForm = new MenuForm();
        
        menuForm.setmenuorderlist();
        menuForm.Show();
        this.Hide();
    }

    private void allcancleBtn_Click(object sender, EventArgs e)
    {
        MenuForm menuForm = new MenuForm();
        menuForm.Show();
        this.Hide();
    }

    public void setorderchecklist()
    {
        orderchecklist.Items.Clear();

        foreach (Menuclass item in orderlist)
        {
            string str = item.coffeename + " [" + item.coffeetemperature + "]" + " [" + item.coffeesize + "]";

            while (str.Length < 18)
            {
                str = str + " " + " " ;
            }

            string liststr1 = "메뉴명 : " + str + "                     가격 : " + item.coffeeprice;
            string liststr2 = "수량 : " + item.coffeenum + " /  샷 : " + item.shotnum + " /  설탕 : " + item.sugarnum + " / 헤이즐 : " + item.hazlenum + " / 카라멜 : " + item.caranum;
            orderchecklist.Items.Add(liststr1);
            orderchecklist.Items.Add(liststr2);
            orderchecklist.Items.Add("");
        }

    }
    public void setorderprice()
    {
       
        foreach (Menuclass item in orderlist)
        {
            orderprice += item.coffeeprice;
          
        }
        orderpricenum.Text = "\\     " + orderprice + "";
    }
    public void setallorderprice()
    {
        allordernum.Text = "\\     " + (orderprice - saleprice) + "";
        
    }
    public void setsaleorderprice()
    {
        salepricenum.Text = "\\     " + saleprice + "";
    }


}
