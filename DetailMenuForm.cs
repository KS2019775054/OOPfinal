using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class DetailMenuForm : Form
{
    private Label menuname;
    private Button plusBtn;
    private Button minusBtn;
    private Label coffeecount;
    private Button iceBtn;
    private Button hotBtn;
    private Label sizelabel;
    private Button tallBtn;
    private Button grandeBtn;
    private Button ventiBtn;
    private Label label1;
    private Label shotpricelabel;
    private Label sugerlabel;
    private Label sugerpricelabel;
    private Label haylzelabel;
    private Label hazlepricelabel;
    private Label caralabel;
    private Label carapricelabel;
    private Button shotplusBtn;
    private Button shotminBtn;
    private Label shotconut;
    private Button sugerpluse;
    private Button sugermin;
    private Label sugercount;
    private Button haylzeplus;
    private Button caraplus;
    private Button haylzemin;
    private Button caramin;
    private Label hazlecount;
    private Label caracount;
    private Label coffeeprice;
    private Button cancleBtn;
    private Button orderBtn;
    private PictureBox pictureBox1;


    public int price = 0;
    public int allprice = 0;
    public int tall = 0;
    public int grande = 0;
    public int venti = 0;


    public int coffeenum = 1;
    public int shotnum = 0;
    public int sugernum = 0;
    public int hazlenum = 0;
    public int caranum = 0;
    public string coffeesize = "Tall";
    public string coffeetemperature = "Ice";



    public DetailMenuForm()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen; /////////////////////////////////////////////////////////////
    }

    // Instantiate event handlers for '+' and '-' buttons, size buttons, rest of the buttons to control quantity





    private void InitializeComponent()
    {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuname = new System.Windows.Forms.Label();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.coffeecount = new System.Windows.Forms.Label();
            this.iceBtn = new System.Windows.Forms.Button();
            this.hotBtn = new System.Windows.Forms.Button();
            this.sizelabel = new System.Windows.Forms.Label();
            this.tallBtn = new System.Windows.Forms.Button();
            this.grandeBtn = new System.Windows.Forms.Button();
            this.ventiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shotpricelabel = new System.Windows.Forms.Label();
            this.sugerlabel = new System.Windows.Forms.Label();
            this.sugerpricelabel = new System.Windows.Forms.Label();
            this.haylzelabel = new System.Windows.Forms.Label();
            this.hazlepricelabel = new System.Windows.Forms.Label();
            this.caralabel = new System.Windows.Forms.Label();
            this.carapricelabel = new System.Windows.Forms.Label();
            this.shotplusBtn = new System.Windows.Forms.Button();
            this.shotminBtn = new System.Windows.Forms.Button();
            this.shotconut = new System.Windows.Forms.Label();
            this.sugerpluse = new System.Windows.Forms.Button();
            this.sugermin = new System.Windows.Forms.Button();
            this.sugercount = new System.Windows.Forms.Label();
            this.haylzeplus = new System.Windows.Forms.Button();
            this.caraplus = new System.Windows.Forms.Button();
            this.haylzemin = new System.Windows.Forms.Button();
            this.caramin = new System.Windows.Forms.Button();
            this.hazlecount = new System.Windows.Forms.Label();
            this.caracount = new System.Windows.Forms.Label();
            this.coffeeprice = new System.Windows.Forms.Label();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ImageLocation = "./pngimage/Americano.png";
            this.pictureBox1.Location = new System.Drawing.Point(71, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuname
            // 
            this.menuname.AutoSize = true;
            this.menuname.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuname.Location = new System.Drawing.Point(268, 54);
            this.menuname.Name = "menuname";
            this.menuname.Size = new System.Drawing.Size(166, 37);
            this.menuname.TabIndex = 1;
            this.menuname.Text = "[메뉴명]";
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plusBtn.Location = new System.Drawing.Point(269, 119);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(40, 40);
            this.plusBtn.TabIndex = 2;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minusBtn.Location = new System.Drawing.Point(387, 119);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(40, 40);
            this.minusBtn.TabIndex = 3;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // coffeecount
            // 
            this.coffeecount.AutoSize = true;
            this.coffeecount.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffeecount.Location = new System.Drawing.Point(333, 127);
            this.coffeecount.Name = "coffeecount";
            this.coffeecount.Size = new System.Drawing.Size(28, 27);
            this.coffeecount.TabIndex = 4;
            this.coffeecount.Text = "1";
            // 
            // iceBtn
            // 
            this.iceBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iceBtn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iceBtn.Location = new System.Drawing.Point(85, 226);
            this.iceBtn.Name = "iceBtn";
            this.iceBtn.Size = new System.Drawing.Size(180, 80);
            this.iceBtn.TabIndex = 5;
            this.iceBtn.Text = "Ice";
            this.iceBtn.UseVisualStyleBackColor = false;
            this.iceBtn.Click += new System.EventHandler(this.iceBtn_Click);
            // 
            // hotBtn
            // 
            this.hotBtn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hotBtn.Location = new System.Drawing.Point(352, 226);
            this.hotBtn.Name = "hotBtn";
            this.hotBtn.Size = new System.Drawing.Size(180, 80);
            this.hotBtn.TabIndex = 6;
            this.hotBtn.Text = "Hot";
            this.hotBtn.UseVisualStyleBackColor = true;
            this.hotBtn.Click += new System.EventHandler(this.hotBtn_Click);
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.BackColor = System.Drawing.SystemColors.Control;
            this.sizelabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sizelabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sizelabel.Location = new System.Drawing.Point(16, 390);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(110, 32);
            this.sizelabel.TabIndex = 7;
            this.sizelabel.Text = "사이즈";
            // 
            // tallBtn
            // 
            this.tallBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tallBtn.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tallBtn.Location = new System.Drawing.Point(174, 343);
            this.tallBtn.Name = "tallBtn";
            this.tallBtn.Size = new System.Drawing.Size(110, 110);
            this.tallBtn.TabIndex = 8;
            this.tallBtn.Text = "Tall";
            this.tallBtn.UseVisualStyleBackColor = false;
            this.tallBtn.Click += new System.EventHandler(this.tallBtn_Click);
            // 
            // grandeBtn
            // 
            this.grandeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grandeBtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grandeBtn.Location = new System.Drawing.Point(321, 343);
            this.grandeBtn.Name = "grandeBtn";
            this.grandeBtn.Size = new System.Drawing.Size(110, 110);
            this.grandeBtn.TabIndex = 8;
            this.grandeBtn.Text = "Grande";
            this.grandeBtn.UseVisualStyleBackColor = false;
            this.grandeBtn.Click += new System.EventHandler(this.grandeBtn_Click);
            // 
            // ventiBtn
            // 
            this.ventiBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ventiBtn.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ventiBtn.Location = new System.Drawing.Point(466, 343);
            this.ventiBtn.Name = "ventiBtn";
            this.ventiBtn.Size = new System.Drawing.Size(110, 110);
            this.ventiBtn.TabIndex = 8;
            this.ventiBtn.Text = "Venti";
            this.ventiBtn.UseVisualStyleBackColor = false;
            this.ventiBtn.Click += new System.EventHandler(this.ventiBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(32, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "샷 추가";
            // 
            // shotpricelabel
            // 
            this.shotpricelabel.AutoSize = true;
            this.shotpricelabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shotpricelabel.Location = new System.Drawing.Point(198, 510);
            this.shotpricelabel.Name = "shotpricelabel";
            this.shotpricelabel.Size = new System.Drawing.Size(87, 27);
            this.shotpricelabel.TabIndex = 9;
            this.shotpricelabel.Text = "500원";
            // 
            // sugerlabel
            // 
            this.sugerlabel.AutoSize = true;
            this.sugerlabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sugerlabel.Location = new System.Drawing.Point(32, 579);
            this.sugerlabel.Name = "sugerlabel";
            this.sugerlabel.Size = new System.Drawing.Size(129, 27);
            this.sugerlabel.TabIndex = 9;
            this.sugerlabel.Text = "설탕 시럽";
            // 
            // sugerpricelabel
            // 
            this.sugerpricelabel.AutoSize = true;
            this.sugerpricelabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sugerpricelabel.Location = new System.Drawing.Point(198, 579);
            this.sugerpricelabel.Name = "sugerpricelabel";
            this.sugerpricelabel.Size = new System.Drawing.Size(87, 27);
            this.sugerpricelabel.TabIndex = 9;
            this.sugerpricelabel.Text = "300원";
            // 
            // haylzelabel
            // 
            this.haylzelabel.AutoSize = true;
            this.haylzelabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.haylzelabel.Location = new System.Drawing.Point(32, 652);
            this.haylzelabel.Name = "haylzelabel";
            this.haylzelabel.Size = new System.Drawing.Size(156, 27);
            this.haylzelabel.TabIndex = 9;
            this.haylzelabel.Text = "헤이즐 시럽";
            // 
            // hazlepricelabel
            // 
            this.hazlepricelabel.AutoSize = true;
            this.hazlepricelabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hazlepricelabel.Location = new System.Drawing.Point(198, 652);
            this.hazlepricelabel.Name = "hazlepricelabel";
            this.hazlepricelabel.Size = new System.Drawing.Size(87, 27);
            this.hazlepricelabel.TabIndex = 9;
            this.hazlepricelabel.Text = "300원";
            // 
            // caralabel
            // 
            this.caralabel.AutoSize = true;
            this.caralabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.caralabel.Location = new System.Drawing.Point(32, 729);
            this.caralabel.Name = "caralabel";
            this.caralabel.Size = new System.Drawing.Size(156, 27);
            this.caralabel.TabIndex = 9;
            this.caralabel.Text = "카라멜 시럽";
            // 
            // carapricelabel
            // 
            this.carapricelabel.AutoSize = true;
            this.carapricelabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.carapricelabel.Location = new System.Drawing.Point(198, 729);
            this.carapricelabel.Name = "carapricelabel";
            this.carapricelabel.Size = new System.Drawing.Size(87, 27);
            this.carapricelabel.TabIndex = 9;
            this.carapricelabel.Text = "300원";
            // 
            // shotplusBtn
            // 
            this.shotplusBtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shotplusBtn.Location = new System.Drawing.Point(377, 499);
            this.shotplusBtn.Name = "shotplusBtn";
            this.shotplusBtn.Size = new System.Drawing.Size(50, 46);
            this.shotplusBtn.TabIndex = 10;
            this.shotplusBtn.Text = "+";
            this.shotplusBtn.UseVisualStyleBackColor = true;
            this.shotplusBtn.Click += new System.EventHandler(this.shotplusBtn_Click);
            // 
            // shotminBtn
            // 
            this.shotminBtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shotminBtn.Location = new System.Drawing.Point(504, 499);
            this.shotminBtn.Name = "shotminBtn";
            this.shotminBtn.Size = new System.Drawing.Size(50, 46);
            this.shotminBtn.TabIndex = 10;
            this.shotminBtn.Text = "-";
            this.shotminBtn.UseVisualStyleBackColor = true;
            this.shotminBtn.Click += new System.EventHandler(this.shotminBtn_Click);
            // 
            // shotconut
            // 
            this.shotconut.AutoSize = true;
            this.shotconut.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shotconut.Location = new System.Drawing.Point(453, 506);
            this.shotconut.Name = "shotconut";
            this.shotconut.Size = new System.Drawing.Size(23, 24);
            this.shotconut.TabIndex = 11;
            this.shotconut.Text = "0";
            // 
            // sugerpluse
            // 
            this.sugerpluse.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sugerpluse.Location = new System.Drawing.Point(377, 570);
            this.sugerpluse.Name = "sugerpluse";
            this.sugerpluse.Size = new System.Drawing.Size(50, 46);
            this.sugerpluse.TabIndex = 10;
            this.sugerpluse.Text = "+";
            this.sugerpluse.UseVisualStyleBackColor = true;
            this.sugerpluse.Click += new System.EventHandler(this.sugerpluse_Click);
            // 
            // sugermin
            // 
            this.sugermin.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sugermin.Location = new System.Drawing.Point(504, 570);
            this.sugermin.Name = "sugermin";
            this.sugermin.Size = new System.Drawing.Size(50, 46);
            this.sugermin.TabIndex = 10;
            this.sugermin.Text = "-";
            this.sugermin.UseVisualStyleBackColor = true;
            this.sugermin.Click += new System.EventHandler(this.sugermin_Click);
            // 
            // sugercount
            // 
            this.sugercount.AutoSize = true;
            this.sugercount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sugercount.Location = new System.Drawing.Point(453, 577);
            this.sugercount.Name = "sugercount";
            this.sugercount.Size = new System.Drawing.Size(23, 24);
            this.sugercount.TabIndex = 11;
            this.sugercount.Text = "0";
            // 
            // haylzeplus
            // 
            this.haylzeplus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.haylzeplus.Location = new System.Drawing.Point(377, 642);
            this.haylzeplus.Name = "haylzeplus";
            this.haylzeplus.Size = new System.Drawing.Size(50, 46);
            this.haylzeplus.TabIndex = 10;
            this.haylzeplus.Text = "+";
            this.haylzeplus.UseVisualStyleBackColor = true;
            this.haylzeplus.Click += new System.EventHandler(this.haylzeplus_Click);
            // 
            // caraplus
            // 
            this.caraplus.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.caraplus.Location = new System.Drawing.Point(377, 715);
            this.caraplus.Name = "caraplus";
            this.caraplus.Size = new System.Drawing.Size(50, 46);
            this.caraplus.TabIndex = 10;
            this.caraplus.Text = "+";
            this.caraplus.UseVisualStyleBackColor = true;
            this.caraplus.Click += new System.EventHandler(this.caraplus_Click);
            // 
            // haylzemin
            // 
            this.haylzemin.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.haylzemin.Location = new System.Drawing.Point(504, 642);
            this.haylzemin.Name = "haylzemin";
            this.haylzemin.Size = new System.Drawing.Size(50, 46);
            this.haylzemin.TabIndex = 10;
            this.haylzemin.Text = "-";
            this.haylzemin.UseVisualStyleBackColor = true;
            this.haylzemin.Click += new System.EventHandler(this.haylzemin_Click);
            // 
            // caramin
            // 
            this.caramin.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.caramin.Location = new System.Drawing.Point(504, 715);
            this.caramin.Name = "caramin";
            this.caramin.Size = new System.Drawing.Size(50, 46);
            this.caramin.TabIndex = 10;
            this.caramin.Text = "-";
            this.caramin.UseVisualStyleBackColor = true;
            this.caramin.Click += new System.EventHandler(this.caramin_Click);
            // 
            // hazlecount
            // 
            this.hazlecount.AutoSize = true;
            this.hazlecount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hazlecount.Location = new System.Drawing.Point(453, 649);
            this.hazlecount.Name = "hazlecount";
            this.hazlecount.Size = new System.Drawing.Size(23, 24);
            this.hazlecount.TabIndex = 11;
            this.hazlecount.Text = "0";
            // 
            // caracount
            // 
            this.caracount.AutoSize = true;
            this.caracount.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.caracount.Location = new System.Drawing.Point(453, 722);
            this.caracount.Name = "caracount";
            this.caracount.Size = new System.Drawing.Size(23, 24);
            this.caracount.TabIndex = 11;
            this.caracount.Text = "0";
            // 
            // coffeeprice
            // 
            this.coffeeprice.AutoSize = true;
            this.coffeeprice.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coffeeprice.Location = new System.Drawing.Point(482, 67);
            this.coffeeprice.Name = "coffeeprice";
            this.coffeeprice.Size = new System.Drawing.Size(49, 24);
            this.coffeeprice.TabIndex = 12;
            this.coffeeprice.Text = "111";
            // 
            // cancleBtn
            // 
            this.cancleBtn.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancleBtn.Location = new System.Drawing.Point(71, 835);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(179, 65);
            this.cancleBtn.TabIndex = 13;
            this.cancleBtn.Text = "취소";
            this.cancleBtn.UseVisualStyleBackColor = true;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderBtn.Location = new System.Drawing.Point(375, 835);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(179, 65);
            this.orderBtn.TabIndex = 13;
            this.orderBtn.Text = "주문";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // DetailMenuForm
            // 
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.coffeeprice);
            this.Controls.Add(this.caracount);
            this.Controls.Add(this.sugercount);
            this.Controls.Add(this.hazlecount);
            this.Controls.Add(this.shotconut);
            this.Controls.Add(this.caramin);
            this.Controls.Add(this.sugermin);
            this.Controls.Add(this.haylzemin);
            this.Controls.Add(this.shotminBtn);
            this.Controls.Add(this.caraplus);
            this.Controls.Add(this.haylzeplus);
            this.Controls.Add(this.sugerpluse);
            this.Controls.Add(this.shotplusBtn);
            this.Controls.Add(this.carapricelabel);
            this.Controls.Add(this.hazlepricelabel);
            this.Controls.Add(this.sugerpricelabel);
            this.Controls.Add(this.shotpricelabel);
            this.Controls.Add(this.caralabel);
            this.Controls.Add(this.haylzelabel);
            this.Controls.Add(this.sugerlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ventiBtn);
            this.Controls.Add(this.grandeBtn);
            this.Controls.Add(this.tallBtn);
            this.Controls.Add(this.sizelabel);
            this.Controls.Add(this.hotBtn);
            this.Controls.Add(this.iceBtn);
            this.Controls.Add(this.coffeecount);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.menuname);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "DetailMenuForm";
            this.Load += new System.EventHandler(this.DetailMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
         this.pictureBox1.Load("./image/Americano.png");

    }

    private void plusBtn_Click(object sender, EventArgs e)
    {
        this.coffeecount.Text = (int.Parse(this.coffeecount.Text) + 1).ToString();
        this.coffeenum++;

        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();

    }
    private void minusBtn_Click(object sender, EventArgs e)
    {
        if (this.coffeecount.Text == "1")
        {

        }
        else
        {
            this.coffeecount.Text = (int.Parse(this.coffeecount.Text) - 1).ToString();
            this.coffeeprice.Text = allprice.ToString();
            this.coffeenum--;

            this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
            this.coffeeprice.Text = allprice.ToString();
        }
    }
    private void cancleBtn_Click(object sender, EventArgs e)
    {
        MenuForm menuform = new MenuForm();

        menuform.setmenuorderlist();
        menuform.setallprice();
        menuform.Show();
        this.Hide();
    }

    private void orderBtn_Click(object sender, EventArgs e)
    {
        MenuForm menuform = new MenuForm();
        OrderConfirmForm orderconfirmform = new OrderConfirmForm();

        MenuForm.Menuclass menuclass = new MenuForm.Menuclass(menuname.Text, Int32.Parse(coffeeprice.Text), coffeenum, shotnum, sugernum, hazlenum, caranum, coffeesize, coffeetemperature) ;
        MenuForm.orderlist.AddLast(menuclass);

        menuform.setmenuorderlist();
        menuform.setallprice();


        menuform.Show();
        this.Hide();

    }
    /// <summary>/*
    ///  public String coffeename;
  /*  public int coffeeprice;
    public int coffeenum;
    public int shotnum;
    public int sugarnum;
    public int hazlenum;
    public int caranum;*/
    /// </summary>*/
    /// <param name="str"></param>




    public void setMenuname(String  str)
    {
        this.menuname.Text= str;
    }
    public void setPrice(int pri)
    {
        this.price = pri;
        this.coffeeprice.Text = price.ToString();
    }
    private void tallBtn_Click(object sender, EventArgs e)
    {
        this.tall = 1;
        this.grande = 0;
        this.venti = 0;
        coffeesize = "Tall";
        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();


        tallBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
        grandeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        ventiBtn.BackColor = System.Drawing.SystemColors.ControlLight;

    }
    private void grandeBtn_Click(object sender, EventArgs e)
    {
        this.tall = 0;
        this.grande = 1;
        this.venti = 0;
        coffeesize = "Grande";
        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();


        tallBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        grandeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
        ventiBtn.BackColor = System.Drawing.SystemColors.ControlLight;

    }

    private void ventiBtn_Click(object sender, EventArgs e)
    {
        this.tall = 0;
        this.grande = 0;
        this.venti = 1;
        coffeesize = "Venti";
        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();


        tallBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        grandeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        ventiBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;

    }
    private void shotplusBtn_Click(object sender, EventArgs e)
    {
        this.shotconut.Text = (int.Parse(this.shotconut.Text) + 1).ToString();
        this.coffeeprice.Text = allprice.ToString();
        this.shotnum++;

        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();
    }

    private void shotminBtn_Click(object sender, EventArgs e)
    {
        if (this.shotconut.Text == "0")
        {

        }
        else
        {
            this.shotconut.Text = (int.Parse(this.shotconut.Text) - 1).ToString();
            this.coffeeprice.Text = allprice.ToString();
            this.shotnum--;

            this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
            this.coffeeprice.Text = allprice.ToString();
        }
    }

    private void sugerpluse_Click(object sender, EventArgs e)
    {
        this.sugercount.Text = (int.Parse(this.sugercount.Text) + 1).ToString();
        this.coffeeprice.Text = allprice.ToString();
        this.sugernum++;

        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();
    }

    private void sugermin_Click(object sender, EventArgs e)
    {
        if (this.sugercount.Text == "0")
        {

        }
        else
        {
            this.sugercount.Text = (int.Parse(this.sugercount.Text) - 1).ToString();
            this.coffeeprice.Text = allprice.ToString();
            this.sugernum--;

            this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
            this.coffeeprice.Text = allprice.ToString();
        }
    }

    private void haylzeplus_Click(object sender, EventArgs e)
    {
        this.hazlecount.Text = (int.Parse(this.hazlecount.Text) + 1).ToString();
        this.coffeeprice.Text = allprice.ToString();
        this.hazlenum++;

        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();
    }

    private void haylzemin_Click(object sender, EventArgs e)
    {
        if (this.hazlecount.Text == "0")
        {

        }
        else
        {
            this.hazlecount.Text = (int.Parse(this.hazlecount.Text) - 1).ToString();
            this.coffeeprice.Text = allprice.ToString();
            this.hazlenum--;

            this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
            this.coffeeprice.Text = allprice.ToString();
        }
    }
    private void caraplus_Click(object sender, EventArgs e)
    {
        this.caracount.Text = (int.Parse(this.caracount.Text) + 1).ToString();
        this.coffeeprice.Text = allprice.ToString();
        this.caranum++;

        this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
        this.coffeeprice.Text = allprice.ToString();
    }

    private void caramin_Click(object sender, EventArgs e)
    {
        if (this.caracount.Text == "0")
        {

        }
        else
        {
            this.caracount.Text = (int.Parse(this.caracount.Text) - 1).ToString();
            this.coffeeprice.Text = allprice.ToString();
            this.caranum--;

            this.allprice = coffeenum * ((500 * grande) + (1000 * venti) + (500 * shotnum) + (300 * sugernum) + (300 * hazlenum) + (300 * caranum) + price);
            this.coffeeprice.Text = allprice.ToString();
        }
    }

    private void DetailMenuForm_Load(object sender, EventArgs e)
    {

    }

    private void iceBtn_Click(object sender, EventArgs e)
    {
        coffeetemperature = "Ice";

        hotBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        iceBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
    }

    private void hotBtn_Click(object sender, EventArgs e)
    {
        coffeetemperature = "Hot";

        iceBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        hotBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;

    }
}
