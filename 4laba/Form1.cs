using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _4laba
{
    //Создаём ссылку на функцию
    public delegate void ChangeUI(string data);

    public partial class Form1 : Form
    {
        private ChangeUI myUI;
        private Threads _myThreads;
        
        public void Changed(string data)
        {
            this.text_log.AppendText(data + Environment.NewLine);
            //this.text_log.Text = data+ this.text_log.Text;
        }
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            //Метод отображения информации в текстовом поле
            myUI = new ChangeUI(Changed);
            //Передаём ссылку на делегат
            _myThreads = new Threads(myUI);
            _myThreads.Run(Convert.ToInt32(number_of_documentsn_ud.Value));
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            _myThreads.Abort();
        }
    }
}
