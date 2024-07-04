using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AlexProject
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }


        public void collectDate2D()
        {
            if (!int.TryParse(rad2d.Text, out AlexDetal.rad2d))
            {
                MessageBox.Show("Некорректно введено значение радиуса окружности. Пожалуйста, введите целое число.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.rad2d = Convert.ToInt32(rad2d.Text);
            }


            if (!int.TryParse(diag2d.Text, out AlexDetal.diag2d))
            {
                MessageBox.Show("Некорректно введено значение диагонали ромба. Пожалуйста, введите целое число.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.diag2d = Convert.ToInt32(diag2d.Text);
            }

            if (string.IsNullOrEmpty(fileName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя файла.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.name2d = Convert.ToString(fileName.Text);
            }
        }

        public void collectDate3D()
        {

            if (!int.TryParse(cube3d.Text, out AlexDetal.cube3d))
            {
                MessageBox.Show("Некорректно введено значение длины. Пожалуйста, введите число.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.cube3d = Convert.ToInt32(cube3d.Text);
            }

            if (!int.TryParse(rad3d.Text, out AlexDetal.circleRad3d))
            {
                MessageBox.Show("Некорректно введено значение толщины. Пожалуйста, введите число.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.circleRad3d = Convert.ToInt32(rad3d.Text);
            }

            if (string.IsNullOrEmpty(fileName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя файла.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.name3d = Convert.ToString(fileName.Text);
            }
        }

        private void save2d_Click(object sender, EventArgs e)
        {
            collectDate2D();
            // Создаем объект pointData
            var pointData = new
            {
                rad = AlexDetal.rad2d,
                diag = AlexDetal.diag2d
            };

            // Сохранение в электронную таблицу (CSV)
            SaveToCsv2D(pointData);
            Class1.My_detal2d();
        }

        private void SaveToCsv2D(object data)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, AlexDetal.name2d + "2d.csv");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("radius,diagonal");
                writer.WriteLine($"{AlexDetal.rad2d},{AlexDetal.diag2d}");
            }
        }

        private void load2d_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя файла.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.name2d = Convert.ToString(fileName.Text);
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, AlexDetal.name2d + "2d.csv");

            if (System.IO.File.Exists(filePath)) // Проверяем, существует ли файл
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadLine(); // Пропускаем первую строку (заголовок)
                    string line = reader.ReadLine(); // Читаем строку с данными
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] values = line.Split(','); // Разделяем строку по запятым
                        if (values.Length == 2)
                        {
                            AlexDetal.rad2d = Convert.ToInt32(values[0]);
                            AlexDetal.diag2d = Convert.ToInt32(values[1]);

                            //запись сохранённых данных
                            rad2d.Text = AlexDetal.rad2d.ToString();
                            diag2d.Text = AlexDetal.diag2d.ToString();
                            fileName.Text = AlexDetal.name2d.ToString();

                            Class1.My_detal2d();
                        }
                        else
                        {
                            MessageBox.Show("Неверный формат файла CSV.", "Ошибка");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Файл " + AlexDetal.name2d + " CSV пустой.", "Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл CSV не найден.", "Ошибка");
            }
        }


        private void save3d_Click(object sender, EventArgs e)
        {
            collectDate3D();
            // Создаем объект pointData
            var pointData = new
            {
                cube = AlexDetal.cube3d,
                circleRad = AlexDetal.circleRad3d
            };

            // Сохранение в электронную таблицу (CSV)
            SaveToCsv3D(pointData);
            Class1.My_detal3d();
        }

        private void SaveToCsv3D(object data)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, AlexDetal.name3d + "3d.csv");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("cube,holeRad");
                writer.WriteLine($"{AlexDetal.cube3d},{AlexDetal.circleRad3d}");
            }
        }

        private void load3d_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя файла.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                AlexDetal.name3d = Convert.ToString(fileName.Text);
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, AlexDetal.name3d + "3d.csv");

            if (System.IO.File.Exists(filePath)) // Проверяем, существует ли файл
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadLine(); // Пропускаем первую строку (заголовок)
                    string line = reader.ReadLine(); // Читаем строку с данными
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] values = line.Split(','); // Разделяем строку по запятым
                        if (values.Length == 2)
                        {
                            AlexDetal.cube3d = Convert.ToInt32(values[0]);
                            AlexDetal.circleRad3d = Convert.ToInt32(values[1]);

                            //запись сохранённых данных
                            cube3d.Text = AlexDetal.cube3d.ToString();
                            rad3d.Text = AlexDetal.circleRad3d.ToString();
                            fileName.Text = AlexDetal.name3d.ToString();

                            Class1.My_detal3d();
                        }
                        else
                        {
                            MessageBox.Show("Неверный формат файла CSV.", "Ошибка");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Файл " + AlexDetal.name3d + " CSV пустой.", "Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл CSV не найден.", "Ошибка");
            }
        }
    }
}
