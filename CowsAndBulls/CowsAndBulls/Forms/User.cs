using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_Tech.Forms
{
    public partial class User : Form
    {
        public ArrayList list = new ArrayList();
        public int count = 0;
        public int myNumber = 0;
        public int answer = 0;
        public string guessedNumber;
        public User()
        {
            InitializeComponent();
        }

        private void BtnGuess_Click(object sender, EventArgs e) // tahmin yapılırken sayının kurallara uygunluğu kontrol edilir...
        {
            guessedNumber = digit1.Value.ToString() +
                digit2.Value.ToString() +
                digit3.Value.ToString() +
                digit4.Value.ToString();
            if (!(digit1.Value.ToString() != digit2.Value.ToString() && digit1.Value.ToString() != digit3.Value.ToString() && digit1.Value.ToString() != digit4.Value.ToString() && digit2.Value.ToString() != digit3.Value.ToString() && digit2.Value.ToString() != digit4.Value.ToString() && digit3.Value.ToString() != digit4.Value.ToString()))
            {
                actionsLogUser.AppendText("Rakamlar birbirinden farklı olmalıdır!!! \n");
            }
            else if (digit1.Value.ToString() == "0")
            {
                actionsLogUser.AppendText("Sayı 0 ile başlayamaz!!! \n");
            }
            else
            {
                count++;
                myNumber = int.Parse(guessedNumber);
                list = GenerateList();
                if (answer == 0)
                {
                    answer = GenerateNumberFromList();
                }
                CheckList();
            }
        }
        public ArrayList GenerateList() // 4 basamaklı rakamları farklı tüm sayıların oluşturulması..
        {
            ArrayList list = new ArrayList();

            for (int i = 1023; i <= 9876; i++)
            {
                int d1 = i / 1000;
                int d2 = (i / 100) % 10;
                int d3 = (i / 10) % 10;
                int d4 = i % 10;

                if (d1 != d2 && d1 != d3 && d1 != d4 && d2 != d3 && d2 != d4 && d3 != d4)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public void CheckList() // sayının tahmine göre bulunup bulunmadığı kontrol edilir....
        {
            string ab = GetAB(myNumber, answer);
            var charList = ab.ToCharArray();
            char plusCount = charList[0];
            char minusCount = charList[2];
            actionsLogUser.AppendText(String.Format("Tahmin {0}: {1}. ------  ( {2} )  ( {3} )  \n", count, myNumber, ((plusCount.Equals('0')) ? "" : "+" + plusCount.ToString()), ((minusCount.Equals('0')) ? "" : "-" + minusCount.ToString())));
            if (ab == "4A0B")
            {
                actionsLogUser.AppendText(String.Format("Tahmin {0}: {1}. ------  Tamamlandı!!! \n", count, myNumber));

            }
        }
        public string GetAB(int guess, int ans) // tahmin ile girilen sayının rakamsal olarak eşleşip eşleşmediğinin kontrol edildiği yer...
        {
            int a = 0;
            int b = 0;
            int[] listArr = new int[4];
            int[] guessArr = new int[4];
            listArr[0] = ans / 1000;
            listArr[1] = (ans / 100) % 10;
            listArr[2] = (ans / 10) % 10;
            listArr[3] = ans % 10;

            guessArr[0] = guess / 1000;
            guessArr[1] = (guess / 100) % 10;
            guessArr[2] = (guess / 10) % 10;
            guessArr[3] = guess % 10;

            for (int i = 0; i < 4; i++)
            {
                if (guessArr[i] == listArr[i])
                {
                    a++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (guessArr[j] == listArr[i])
                        {
                            b++;
                        }
                    }
                }
            }

            return a + "A" + b + "B";
        }
        public int GenerateNumberFromList()
        {
            int number = 0;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int index = rnd.Next(1, list.Count);
            number = (int)list[index];
            return number;
        }
    }
}
