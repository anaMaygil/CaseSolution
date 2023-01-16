using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace caseSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region case1


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            long uxdt = ((DateTimeOffset)dt).ToUnixTimeMilliseconds();



            textBox1.Text = ConvertToBase23(uxdt);
        }

        /// <summary>
        /// 23 karakter olduðu için 23 tabanýna sayýlarý çevirmede kullanýlýr
        /// </summary>
        /// <param name="uxdt"></param>
        /// <returns></returns>
        private string ConvertToBase23(long uxdt)
        {
            string code = "";

            //long bolum = 0;
            int kalan = 0;
            do
            {
                kalan = Convert.ToInt16(uxdt % 23);
                uxdt = uxdt / 23;
                code += return23BaseChar(kalan);
            }
            while (uxdt > 23);
            {
                return code;

            }


        }


        /// <summary>
        /// listemizde olmayan karakterleri tamamlamak için dönüþümleri yapmada kullanýlýr
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string return23BaseChar(int input)
        {
            string returnstr;
            switch (input)
            {
                case 0:
                    returnstr = "Z";
                    break;
                case 1:
                    returnstr = "A";
                    break;
                case 6:
                    returnstr = "C";
                    break;
                case 8:
                    returnstr = "D";
                    break;
                case 10:
                    returnstr = "E";
                    break;
                case 11:
                    returnstr = "F";
                    break;
                case 12:
                    returnstr = "G";
                    break;
                case 13:
                    returnstr = "H";
                    break;
                case 14:
                    returnstr = "K";
                    break;
                case 15:
                    returnstr = "L";
                    break;
                case 16:
                    returnstr = "M";
                    break;
                case 17:
                    returnstr = "N";
                    break;
                case 18:
                    returnstr = "P";
                    break;
                case 19:
                    returnstr = "R";
                    break;
                case 20:
                    returnstr = "T";
                    break;
                case 21:
                    returnstr = "X";
                    break;
                case 22:
                    returnstr = "Y";
                    break;
                default:
                    returnstr = input.ToString();
                    break;


            }
            return returnstr;
        }

        #endregion


        #region case2

        private void JsonConverter_Click(object sender, EventArgs e)
        {
            JArray jArrayInput = JArray.Parse(richTextBox1.Text);
            //List<BillClass> billClass = new List<BillClass>();

            foreach (var item in jArrayInput)
            {
                BillClass bill = new BillClass();
                bill=JsonConvert.DeserializeObject<BillClass>(item.ToString());
                


                if(!String.IsNullOrEmpty(bill.locale))
                {
                    richTextBox2.Text = bill.description;
                    return;
                }

            }


      



        }
        #endregion
    }


    

}
