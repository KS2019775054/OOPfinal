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
    public partial class PayForm : Form
    {
        private Label payment;
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
        private PictureBox pictureBox1;

        int orderprice = 0;
        int saleprice = 0;
        public PayForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;/////////////////////////////////////////////////////////////
        }

        private void InitializeComponent()
        {
            this.payment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payment.Location = new System.Drawing.Point(230, 3);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(165, 37);
            this.payment.TabIndex = 1;
            this.payment.Text = "결제하기";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 604);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.panel2.TabIndex = 4;
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
            // PayForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.payment);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.pictureBox1.Load("./image/pay.png");

        }

        private void PayForm_Load(object sender, EventArgs e)
        {

        }

        private void allcancleBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PaymentMethodForm paymentMethodForm = new PaymentMethodForm();
            paymentMethodForm.setorderprice();
            paymentMethodForm.setsaleorderprice();
            paymentMethodForm.setallorderprice();
            paymentMethodForm.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            PaymentCompleteForm paymentCompleteForm = new PaymentCompleteForm();
            paymentCompleteForm.Show();
            this.Hide();
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
