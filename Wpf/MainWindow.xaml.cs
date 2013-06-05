using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using Microsoft.Win32;
using System.Windows.Controls.DataVisualization.Charting;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_16_Click(object sender, RoutedEventArgs e)
        {

            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = 0 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            ((ColumnSeries)mcChart.SeriesHost.Series[0]).ItemsSource =

            new KeyValuePair<string, int>[]
            {
            new KeyValuePair<string, int>("", ar1[0]),
            new KeyValuePair<string, int>("", ar1[1]),
            new KeyValuePair<string, int>("", ar1[2]),
            new KeyValuePair<string, int>("", ar1[3]),
            new KeyValuePair<string, int>("", ar1[4]),
            new KeyValuePair<string, int>("", ar1[5]),
            new KeyValuePair<string, int>("", ar1[6]),
            new KeyValuePair<string, int>("", ar1[7]),
            new KeyValuePair<string, int>("", ar1[8]),
            new KeyValuePair<string, int>("", ar1[9])
            };
        }










        private void tbN_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }

            int elem = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 1; index < itemCount - 1; index++)
            {
                if ((ar1[index] > ar1[index - 1]) && (ar1[index] > ar1[index + 1]))
                    elem++;
            }
            lbMain.Items.Add("Количество элементов больше своих «соседей»");
            lbMain.Items.Add(elem);
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(20);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }

            int elem = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            index = 0;
            while ((ar1[index] <= 25) && (index < itemCount - 1))
            {
                index++;
            }
            lbMain.Items.Add("Индекс первого элемента, большего 25");
            if (ar1[index] > 25)
                lbMain.Items.Add(index + 1);
            else
                lbMain.Items.Add("Не существует");
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }

            int sum = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 0; index < itemCount - 1; index++)
            {
                sum += ar1[index];
            }
            sum = sum / itemCount;
            if (sum > ar1[0])
                lbMain.Items.Add("Первый элемент меньше среднего значения");
            else
                lbMain.Items.Add("Первый элемент больше среднего значения");

        }


        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }

            int tum = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 0; index < itemCount - 1; index++)
            {
                if (ar1[index] * ar1[index + 1] < 0)
                    tum++;
            }
            lbMain.Items.Add("Знак меняется");
            lbMain.Items.Add(tum);
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 0; index < itemCount - 1; index++)
            {
                if ((ar1[index] < 21))
                    sum += ar1[index];
            }
            lbMain.Items.Add("Сумма элементов меньших 21");
            lbMain.Items.Add(sum);
        }

            int tum = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 0; index < itemCount; index++)
            {
                if ((ar1[index] > ar1[3]))
                    tum++;
            }
            lbMain.Items.Add("элементов больших, чем   4 элемент этого массива");
            lbMain.Items.Add(tum);
        }


        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }

            int sum = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 0; index < itemCount - 1; index++)
            {
                if ((ar1[index] < 21))
                    sum += ar1[index];
            }
            lbMain.Items.Add("Сумма элементов меньших 21");
            lbMain.Items.Add(sum);
        }

       


        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }


            lbMain.Items.Add("        ==        ");
            int sum = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 0; index < itemCount; index++)
            {
                if (ar1[index] % 5 == 0)
                    ar1[index] = ar1[index] + 1;
                lbMain.Items.Add(ar1[index]);
            }
        }


        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }

            int sum = 0;
            int[] ar1 = new Int32[itemCount];
            myAL.CopyTo(ar1);
            for (index = 0; index < itemCount; index++)
            {
                if (ar1[index] % 3 != 0)
                    sum += ar1[index];
            }
            lbMain.Items.Add("Сумма элементов, не кратных 3");
            lbMain.Items.Add(sum);
        }


        private void button_10_Click(object sender, RoutedEventArgs e)
        {
            {
                ArrayList myAL = new ArrayList();
                int index;
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }

                int sum = 0;
                int[] ar1 = new Int32[itemCount];
                myAL.CopyTo(ar1);
                for (index = 1; index < itemCount - 1; index++)
                {
                    if ((ar1[index] < ar1[0]) && (ar1[index] > ar1[itemCount - 1]))
                        sum++;
                }
                lbMain.Items.Add("элементов  <1 и >последнего");
                lbMain.Items.Add(sum);
            }
        }


        private void button_12_Click(object sender, RoutedEventArgs e)
        {
            {
                ArrayList myAL = new ArrayList();
                int index;
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }

                int min1 = 0, min2 = 0;
                int[] ar1 = new Int32[itemCount];
                myAL.CopyTo(ar1);
                min1 = Math.Abs(ar1[0] - ar1[1]);
                for (index = 2; index < itemCount; index++)
                {

                    if (Math.Abs(ar1[index] - ar1[1]) < min1)
                    {
                        min1 = Math.Abs(ar1[index] - ar1[1]);
                        min2 = index;
                    }
                }
                lbMain.Items.Add("Элемент, меньше всего отличающийся от второго");
                lbMain.Items.Add(min2 + 1);
            }
        }



        private void button_14_Click(object sender, RoutedEventArgs e)
        {
            {
                ArrayList myAL = new ArrayList();
                int index;
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                int[] ar1 = new Int32[itemCount];
                myAL.CopyTo(ar1);
                int tum = 0;
                for (index = 0; index < itemCount; index++)
                {

                    if (ar1[index] % 3 == 0)
                    {
                        tum++;
                    }
                }
                lbMain.Items.Add("Элементов, кратных 3, ");
                lbMain.Items.Add(tum);
            }
        }
    }
}
