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
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Runtime.InteropServices;


namespace OOPCoffee
{
    public partial class PaymentCompleteForm : Form
    {
        private Panel panel1;
        private Button endBtn;
        private Label tnklabel;
        private Label staynumlabel;
        private Label staylabel;
        private Label oklabel;
        
        /*LinkedList<String> list = MenuForm.orderlist2;*/

        public PaymentCompleteForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;/////////////////////////////////////////////////////////////
            
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.endBtn = new System.Windows.Forms.Button();
            this.tnklabel = new System.Windows.Forms.Label();
            this.staynumlabel = new System.Windows.Forms.Label();
            this.staylabel = new System.Windows.Forms.Label();
            this.oklabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.endBtn);
            this.panel1.Controls.Add(this.tnklabel);
            this.panel1.Controls.Add(this.staynumlabel);
            this.panel1.Controls.Add(this.staylabel);
            this.panel1.Controls.Add(this.oklabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 897);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // endBtn
            // 
            this.endBtn.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.endBtn.Location = new System.Drawing.Point(189, 761);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(231, 74);
            this.endBtn.TabIndex = 4;
            this.endBtn.Text = "결제완료";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // tnklabel
            // 
            this.tnklabel.AutoSize = true;
            this.tnklabel.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tnklabel.Location = new System.Drawing.Point(163, 494);
            this.tnklabel.Name = "tnklabel";
            this.tnklabel.Size = new System.Drawing.Size(276, 48);
            this.tnklabel.TabIndex = 3;
            this.tnklabel.Text = "감사합니다.";
            // 
            // staynumlabel
            // 
            this.staynumlabel.AutoSize = true;
            this.staynumlabel.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.staynumlabel.Location = new System.Drawing.Point(215, 355);
            this.staynumlabel.Name = "staynumlabel";
            this.staynumlabel.Size = new System.Drawing.Size(57, 40);
            this.staynumlabel.TabIndex = 2;
            this.staynumlabel.Text = "[]";
            // 
            // staylabel
            // 
            this.staylabel.AutoSize = true;
            this.staylabel.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.staylabel.Location = new System.Drawing.Point(207, 294);
            this.staylabel.Name = "staylabel";
            this.staylabel.Size = new System.Drawing.Size(177, 40);
            this.staylabel.TabIndex = 1;
            this.staylabel.Text = "대기번호";
            // 
            // oklabel
            // 
            this.oklabel.AutoSize = true;
            this.oklabel.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.oklabel.Location = new System.Drawing.Point(34, 168);
            this.oklabel.Name = "oklabel";
            this.oklabel.Size = new System.Drawing.Size(548, 48);
            this.oklabel.TabIndex = 0;
            this.oklabel.Text = "결제가 완료 되었습니다.";
            // 
            // PaymentCompleteForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "PaymentCompleteForm";
            this.Load += new System.EventHandler(this.PaymentCompleteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void PaymentCompleteForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            this.staynumlabel.Text = " [ " + randomNumber + " ]";
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Now;

            // 년도 nowDate.Year;

            // 월 nowDate.Month;

            // 일 nowDate.Day;

            // 시 nowDate.Hour;

            // 분 nowDate.Minute;
            string date = nowDate.Year.ToString() + "-" + nowDate.Month.ToString() + "-" + nowDate.Day.ToString() + "/" + nowDate.Hour.ToString() + ":" + nowDate.Minute.ToString();
            string body = "";
            string firstr = "";
            string secstr = "";
            MainForm mainForm = new MainForm();
            mainForm.Show();
            foreach (Menuclass item in MenuForm.orderlist)
            {
                MainForm.InsertOrderHistory(item.coffeename,item.coffeeprice,item.coffeenum,item.shotnum,item.sugarnum,item.hazlenum,item.caranum,item.coffeesize,item.coffeetemperature,date);
                firstr = $"메뉴명 : {item.coffeename} [{item.coffeesize}] [{item.coffeetemperature}] 가격 : {item.coffeeprice} / [{date}]";
                secstr = $"수량 : {item.coffeenum} / 샷 : {item.shotnum} / 설탕 : {item.sugarnum} / 헤이즐 : {item.hazlenum} / 카라멜 : {item.caranum}";
                body += "[ " + firstr+secstr + " ] \n";
            }
            
            const string accountSid = "AC7813a1d6012769b46971b5ba47a8e990";
            const string authToken = "41d87f6e2b0f7d50e9e320182333836d";
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: body,
                from: new Twilio.Types.PhoneNumber("+12706123495"),
                to: new Twilio.Types.PhoneNumber("+8201036705235"));
            Console.WriteLine(message.Sid);
            
            
            this.Hide();
            MenuForm.orderlist.Clear();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
