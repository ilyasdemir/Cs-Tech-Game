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
    public partial class Computer : Form
    {
        public ArrayList list = new ArrayList();
        public ArrayList listNew = new ArrayList();
        public List<AbListObject> listofAb = new List<AbListObject>();
        public int count = 0;
        public bool IsFirstRequest = true;
        public int myNumber = 0;
        public string guessedNumber;
        public int lastGuess = 0;

        public Computer()
        {
            InitializeComponent();
            list = GenerateList();
        }
        // Tahmin et butonuna basılarak ilk tahmin alınır...
        private void BtnGuess_Click(object sender, EventArgs e)
        {
            if ((int.Parse(digit1.Value.ToString()) + int.Parse(digit2.Value.ToString())) > 4)
            {
                actionsLogComputer.AppendText(String.Format(" + ve - lerin toplamı 4 den büyük olamaz!!\n"));
            }
            else
            {
                count++;
                if (IsFirstRequest)
                {
                    lastGuess = GenerateNumberFromList();
                    actionsLogComputer.AppendText(String.Format("Tahmin {0}: {1} \n", count, lastGuess));
                    IsFirstRequest = false;
                }
                else
                {
                    Game();
                }
            }
    
        }
        public bool Game()
        {
            return CheckList();
        }
        
        public bool CheckList() // Gelen tahmin doğrultusunda sayı havuzundan tahmin edilen yer...
        {

            string ab = digit1.Value.ToString() + "A" + digit2.Value.ToString() + "B";
            AddList(lastGuess, ab);
            if (list.Count == 1)
            {
                actionsLogComputer.AppendText(String.Format("Son Tahmin {0}: {1} \n", count, list[0]));
            }
            else if (list.Count == 0)
            {
                actionsLogComputer.AppendText(String.Format("Yanlış bilgilendirmede bulundunuz!!!\n"));
            }
            else
            {
                lastGuess = (int)list[0];
                actionsLogComputer.AppendText(String.Format("Tahmin {0}: {1} \n", count, lastGuess));
                if (ab == "4A0B")
                {
                    actionsLogComputer.AppendText("-------------------------------------------------------- \n");
                    count = 0;
                    list = new ArrayList();
                    listNew = new ArrayList();
                    listofAb = new List<AbListObject>();
                    myNumber = 0;
                    return true;
                }
            }
            return false;
        }
        
        public ArrayList GenerateList() // Tahmin için sayı havuzu oluşturulan yer...
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
        public string GetAB(int guess, int ans) // sayıların tahmin edilen sayılar ile kıyaslandığı yer...
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
        public int GenerateNumberFromList() // Tahminden gelen değere göre yeni listenin oluşturulduğu yer..
        {
            int number = 0;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int index = rnd.Next(1, list.Count);
            number = (int)list[index];
            return number;
        }
        public void AddList(int number, string ab)
        {
            listofAb.Add(new AbListObject
            {
                ab = ab,
                number = number
            });
            GenerateNewList(listofAb);
        }
        public void GenerateNewList(List<AbListObject> abListObjects)
        {
            listNew = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                bool filtered = false;
                for (int j = 0; j < abListObjects.Count; j++)
                {
                    var f = abListObjects[j];
                    if (GetAB((int)list[i], f.number) != f.ab)
                    {
                        filtered = true;
                        break;
                    }
                }
                if (!filtered)
                {
                    listNew.Add((int)list[i]);
                }
            }
            list = listNew;
        }
    }
    public class AbListObject
    {
        public int number { get; set; }
        public string ab { get; set; }
    }
}
