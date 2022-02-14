using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralMarkers
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button_open_path.Enabled = false;
            resizePhotoButton.Enabled = false;
            ToolTip t = new ToolTip();
            t.SetToolTip(button_select_path, $"Выберете папку где сохранится результат\nПрограмма создаст новую папку result");
            t.SetToolTip(check_copy_file, $"Копировать начальные данные в папку \n" +
                $"Будет создана папка start со всеми файлами");
            t.SetToolTip(button_open_path, $"Выберете папку с данными которые нужно обработать");
            label1.Text = $"Файлов найдено: NAN";
            label2.Text = $"txt файлов: NAN";
            label3.Text = $"jpg файлов: NAN";
            label4.Text = $"Не валидных файлов: baNAN";

        }


        List<string> list_name_jpg = new List<string>();
        List<string> list_name_txt = new List<string>();
        List<string> all_files = new List<string>();
        Dictionary<string, string> result_d = new Dictionary<string, string>();

        string start_path = String.Empty;
        string save_path = String.Empty;

        private void button_open_path_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    start_path = fbd.SelectedPath;
                    all_files.AddRange(Directory.GetFiles(start_path));
                    resizePhotoButton.Enabled = true;

                }
            }
        }

        public void File_sort()
        {
            try
            {

                foreach (var item in all_files)
                {
                    if (item.EndsWith(".txt"))
                        list_name_txt.Add(item);
                    else if (item.EndsWith(".jpg"))
                        list_name_jpg.Add(item);
                }

                foreach (var item in list_name_jpg)
                {
                    for (int i = 0; i < list_name_txt.Count; i++)
                        if (item.Split('.')[0] == list_name_txt[i].Split('.')[0])
                            result_d.Add(item, list_name_txt[i]);
                }

                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string path_2 = save_path + $"\\result_{dateTime.ToString("HH-mm-ss")}";
                Directory.CreateDirectory(path_2);
                Directory.CreateDirectory(path_2 + "\\sort");
               
                if (check_copy_file.Checked)
                {
                    foreach (var item in all_files)
                    {
                        Directory.CreateDirectory(path_2 + "\\start");
                        var filename = Path.GetFileName(item);
                        File.Copy(item, path_2 + "\\start\\" + filename);

                    }
                }

                foreach (var item in result_d)
                {
                    var filename = Path.GetFileName(item.Value);
                    File.Copy(item.Value, path_2 + "\\sort\\" + filename);
                    filename = Path.GetFileName(item.Key);
                    File.Copy(item.Key, path_2 + "\\sort\\" + filename);
                }

                label1.Text = $"Файлов найдено: {all_files.Count()}";
                label2.Text = $"txt файлов: {list_name_txt.Count()}";
                label3.Text = $"jpg файлов: {list_name_jpg.Count()}";
                label4.Text = $"Не валидных файлов: {list_name_jpg.Count() - list_name_txt.Count()}";
            }
            catch(Exception ex)
            {
                MessageBox.Show("ОШИБКА!!!!!!!!!!!!!!!!\n" +
                    $"{ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    button_open_path.Enabled = true;
                    save_path = fbd.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Папка не выбрана");
                }
            }
        }

        private void resizePhotoButton_Click(object sender, EventArgs e)
        {
            File_sort();
        }
    }
}
