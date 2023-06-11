using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MenuForm;

namespace OOPCoffee
{
    public partial class PaymentMethodForm : Form
    {
        private Panel panel1;
        private Panel panel2;
        private Button nextBtn;
        private Button backBtn;
        private Button allcancleBtn;
        private Label allordernum;
        private Label salepricenum;
        private Label orderpricenum;
        private Label allorderlabel;
        private Label salepricelab;
        private Label orderpricelabel;
        private Button paycoBtn;
        private Button applepayBtn;
        private Button kacapayBtn;
        private Button sampayBtn;
        private Label payment;

        int orderprice = 0;
        int saleprice = 0;
        public PaymentMethodForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;/////////////////////////////////////////////////////////////
        }

        private void InitializeComponent()
        {
            this.payment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paycoBtn = new System.Windows.Forms.Button();
            this.applepayBtn = new System.Windows.Forms.Button();
            this.kacapayBtn = new System.Windows.Forms.Button();
            this.sampayBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payment.Location = new System.Drawing.Point(230, 9);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(165, 37);
            this.payment.TabIndex = 0;
            this.payment.Text = "결제하기";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.paycoBtn);
            this.panel1.Controls.Add(this.applepayBtn);
            this.panel1.Controls.Add(this.kacapayBtn);
            this.panel1.Controls.Add(this.sampayBtn);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 587);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // paycoBtn
            // 
            this.paycoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.paycoBtn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paycoBtn.Location = new System.Drawing.Point(364, 329);
            this.paycoBtn.Name = "paycoBtn";
            this.paycoBtn.Size = new System.Drawing.Size(173, 169);
            this.paycoBtn.TabIndex = 0;
            this.paycoBtn.Text = "페이코";
            this.paycoBtn.UseVisualStyleBackColor = false;
            this.paycoBtn.Click += new System.EventHandler(this.paycoBtn_Click);
            // 
            // applepayBtn
            // 
            this.applepayBtn.BackColor = System.Drawing.SystemColors.Control;
            this.applepayBtn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.applepayBtn.Location = new System.Drawing.Point(364, 65);
            this.applepayBtn.Name = "applepayBtn";
            this.applepayBtn.Size = new System.Drawing.Size(173, 169);
            this.applepayBtn.TabIndex = 0;
            this.applepayBtn.Text = "애플페이";
            this.applepayBtn.UseVisualStyleBackColor = false;
            this.applepayBtn.Click += new System.EventHandler(this.applepayBtn_Click);
            // 
            // kacapayBtn
            // 
            this.kacapayBtn.BackColor = System.Drawing.SystemColors.Control;
            this.kacapayBtn.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kacapayBtn.Location = new System.Drawing.Point(75, 329);
            this.kacapayBtn.Name = "kacapayBtn";
            this.kacapayBtn.Size = new System.Drawing.Size(173, 169);
            this.kacapayBtn.TabIndex = 0;
            this.kacapayBtn.Text = "카카오페이";
            this.kacapayBtn.UseVisualStyleBackColor = false;
            this.kacapayBtn.Click += new System.EventHandler(this.kacapayBtn_Click);
            // 
            // sampayBtn
            // 
            this.sampayBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sampayBtn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sampayBtn.Location = new System.Drawing.Point(60, 58);
            this.sampayBtn.Name = "sampayBtn";
            this.sampayBtn.Size = new System.Drawing.Size(173, 169);
            this.sampayBtn.TabIndex = 0;
            this.sampayBtn.Text = "삼성페이";
            this.sampayBtn.UseVisualStyleBackColor = false;
            this.sampayBtn.Click += new System.EventHandler(this.sampayBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.allcancleBtn);
            this.panel2.Controls.Add(this.allordernum);
            this.panel2.Controls.Add(this.salepricenum);
            this.panel2.Controls.Add(this.orderpricenum);
            this.panel2.Controls.Add(this.allorderlabel);
            this.panel2.Controls.Add(this.salepricelab);
            this.panel2.Controls.Add(this.orderpricelabel);
            this.panel2.Location = new System.Drawing.Point(12, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 222);
            this.panel2.TabIndex = 3;
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
            this.salepricenum.Size = new System.Drawing.Size(110, 27);
            this.salepricenum.TabIndex = 0;
            this.salepricenum.Text = "\\ 8000";
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
            // PaymentMethodForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.payment);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "PaymentMethodForm";
            this.Load += new System.EventHandler(this.PaymentMethodForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PaymentMethodForm_Load(object sender, EventArgs e)
        {

        }

        private void sampayBtn_Click(object sender, EventArgs e)
        {

            sampayBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            applepayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            paycoBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            kacapayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        }

        private void applepayBtn_Click(object sender, EventArgs e)
        {
            sampayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            applepayBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            paycoBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            kacapayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        }

        private void paycoBtn_Click(object sender, EventArgs e)
        {
            sampayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            applepayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            paycoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            kacapayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        }

        private void kacapayBtn_Click(object sender, EventArgs e)
        {
            sampayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            applepayBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            paycoBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            kacapayBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            PayForm payForm = new PayForm();
            payForm.setorderprice();
            payForm.setsaleorderprice();
            payForm.setallorderprice();

            payForm.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            OrderConfirmForm orderConfirmForm = new OrderConfirmForm();
            orderConfirmForm.setsaleorderprice();
            orderConfirmForm.setorderprice();
            orderConfirmForm.setallorderprice();
            orderConfirmForm.Show();
            orderConfirmForm.setorderchecklist();
            this.Hide();
        }

        private void allcancleBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void setorderprice()
        {
            

            foreach (Menuclass item in MenuForm.orderlist)
            {
                orderprice += item.coffeeprice;

            }
            this.orderpricenum.Text = "\\     " + orderprice + "";
        }
        public void setallorderprice()
        {
            this.allordernum.Text = "\\     " + (orderprice - saleprice) + "";

        }
        public void setsaleorderprice()
        {
            this.salepricenum.Text = "\\     " + saleprice + "";
        }
        

    }
}
