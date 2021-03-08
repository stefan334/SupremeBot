using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace Botsup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.supremenewyork.com/checkout");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("order_billing_name").SetAttribute("value", "Stefan Ivan");
            webBrowser1.Document.GetElementById("order_email").SetAttribute("value", "stefan.ivan334@gmail.com");
            webBrowser1.Document.GetElementById("order_tel").SetAttribute("value", "+40720097065");
            webBrowser1.Document.GetElementById("bo").SetAttribute("value", "Soseaua Stefan Cel Mare nr 30 bl 26 scara 2 ap 43 etaj 5");
            webBrowser1.Document.GetElementById("order_billing_city").SetAttribute("value", "Bucharest");
            webBrowser1.Document.GetElementById("order_billing_zip").SetAttribute("value", "020144");
           // webBrowser1.Document.GetElementById("order_billing_country").



        }
    }
}
