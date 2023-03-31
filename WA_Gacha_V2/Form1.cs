using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WA_Gacha_V2
{
    public partial class Form1 : Form
    {
        public const int Price = 50;//商品售價
        public const string Pattern = @"^[0-9]*$";
        private int _total = 0;
        private int _input;
        FormViewModel _model;
        public Form1()
        {
            //_total = total;
            InitializeComponent();
            DisableButton();
        }

        private int Input
        {
            get
            {
                Int32.TryParse(textBoxInput.Text, out _input);
                if (Regex.IsMatch(_input.ToString(), Pattern))
                {
                    return _input;
                }
                else
                {
                    return 0;
                }
                //   if (isInput)
       
                //return 0;
            }
            set { textBoxInput.Text = value.ToString(); }
        }

        //public object input { get; private set; }

        private void buttonInput_Click(object sender, EventArgs e)
        {
         //   FormViewModel model;//=new FormViewModel();
            try
            {
                _model = new FormViewModel(this.Input);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            _total += _model.Money;
            GenerateStatus();
            //return model;
        }

        private void GenerateStatus()
        {
            string message;
            DisableButton();
            if (_total > 0)
            {
                if (_total < Price)
                {
                    buttonRefund.Enabled = true;
                    message = _model.State;
                }
                else
                {
                    EnabledButton();
                    message = _model.State;
                }
            }
            else
            {
                message = _model.State;
            }
            SetMessage(message);
        }

        private void SetMessage(string message)
        {
            textBoxState.Text = message;
        }

        private void EnabledButton()
        {
            buttonRefund.Enabled = true;
            buttonShipped.Enabled = true;
        }

        private void DisableButton()
        {
            buttonRefund.Enabled = false;
            buttonShipped.Enabled = false;
        }

        private void buttonRefund_Click(object sender, EventArgs e)
        {
          //  FormViewModel model;
            textBoxInput.Text = "";
            _total = 0;
            GenerateReturnStatus();
        }

        private void GenerateReturnStatus()
        {
           // FormViewModel model = null;
            MessageBox.Show(@"已完成退幣作業");
            DisableButton();
            string message = _model.State;
            SetMessage(message);
        }

        private void buttonShipped_Click(object sender, EventArgs e)
        {
            _total -= Price;
            GenerateStatus();
        }
    }

    public class FormViewModel
    {
        //private string state;
        //private int money;

        public string State { get; set; }
        public int Money { get; set; }

        public FormViewModel(int money)
        {
            if (money <= 0)
            {
                var text = string.Format(@"State:StandbyState 機器沒在工作,等待下一個客人操作\r\nMoney:{0}", money);
                State =text.Replace("\\r\\n",Environment.NewLine);
                //State = string.Format(@"State:StandbyState 機器沒在工作,等待下一個客人操作"+Environment.NewLine+@"Money:{0}", money);
                //State = string.Format(@"State:StandbyState 機器沒在工作,等待下一個客人操作</br>Money:{0}", money).Replace("\\r\\n",Environment.NewLine);
                Money = money;
               // throw new ArgumentOutOfRangeException(money.ToString());
            }
            if (money < Form1.Price)
            {
                State = string.Format(@"State:InsufficientAmountState 有投幣,但金額還不足夠\r\nMoney:{0}", money);
                //State = state;
                Money = money;
            }
            else
            {
                State = string.Format(@"State:ReadyToShip 投入足夠金額,等待客人指令就出貨\r\nMoney:{0}", money);
                //State = state;
                Money = money;
            }
        }

        //public decimal Price { get; private set; }

        //public decimal Price
        //{
        //    get { return Price; }
        //}
    }
}
