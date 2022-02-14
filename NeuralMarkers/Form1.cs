
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralMarkers
{
    public partial class NeuralMarkers : Form
    {
        public NeuralMarkers()
        {
            InitializeComponent();
        }

        private void NeuralMarkers_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button_LoadForm_2, "Поиск jpg файлов без пары txt \n" +
                "fksf.txt == fksf.jpg\n" +
                "gfrd.txt == gfrd.jpg");

        }

        public string WorkingDirectory = ""; //рабочая папка
        public string[] WorkingFiles = null; //рабочие файлы

        public string SourceFolder = "images"; // необработанные фото
        public string DestrinitionFolder = "dataset"; // папка с результатом

        public int CountCompletedFiles = 0;

        ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
        EncoderParameters myEncoderParameters = new EncoderParameters(1);

        static System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
        EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);

        //выбор рабочей директории
        private void chooseDirectoryButton_Click(object sender, EventArgs e)
        {
            folderDialog.ShowNewFolderButton = true; 
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                WorkingDirectory = folderDialog.SelectedPath;
                if (!checkFolderExists("images"))
                {
                    MessageBox.Show("Директории images несуществует");
                    return;
                }

                if (!checkFilesExists("images"))
                {
                    MessageBox.Show("Не найдено ниодного файла в директории images");
                    return;
                }

                infoFiles.Text = "Всего файлов: " + WorkingFiles.Count();
                resizePhotoButton.Enabled = true;
            }
        }

        //существует ли директория
        private bool checkFolderExists(string folderName)
        {
            return Directory.Exists(WorkingDirectory + "/" + folderName);
        }

        //есть ли файлы в директории
        private bool checkFilesExists(string folderName)
        {
            WorkingFiles = Directory.GetFiles(WorkingDirectory + "/" + folderName);
            if (WorkingFiles.Length == 0)
            {
                return false;
            }
            return true;
        }

        //меняем размер фото
        public static async Task<Bitmap> ResizeImage(Image image, int width, int height)
        {

                var destRect = new Rectangle(0, 0, width, height);
                var destImage = new Bitmap(width, height);

            await Task.Run(() =>
            {
                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

            });
                return destImage;

        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        //обрабатываем фото
        public async void resizePhotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                CountCompletedFiles = 0;
                if (!Directory.Exists(WorkingDirectory + "/" + DestrinitionFolder))
                    Directory.CreateDirectory(WorkingDirectory + "/" + DestrinitionFolder);

                clearFolder(WorkingDirectory + "/" + DestrinitionFolder);

                resizePhotoButton.Enabled = false;
                Cursor = Cursors.WaitCursor;
                for (int i = 0; i < WorkingFiles.Length; i++)
                {
                    //Only JPG files
                    if (WorkingFiles[i].EndsWith(".jpg"))
                    {
                        Image photo = Image.FromFile(WorkingFiles[i]);
                        Image newPhoto = await ResizeImage(photo, 640, 480);

                        myEncoderParameters.Param[0] = myEncoderParameter;
                        newPhoto.Save(WorkingDirectory + "/" + DestrinitionFolder + "/" +$"{CountCompletedFiles}_" + $"{WorkingFiles.Count()}_"+ generateUniqFileName(8) , jpgEncoder, myEncoderParameters);
                        CountCompletedFiles++;
                        completedFilesInfo.Text = "Обработано файлов: " + CountCompletedFiles + " / " + WorkingFiles.Count();
                    }
                }

                MessageBox.Show("Было обработано " + CountCompletedFiles + " изображений", "Все успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resizePhotoButton.Enabled = true;
                Cursor = Cursors.Default;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обработке фото", $"Ошибка! \n{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //очищаем папку
        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }

        //генерируем случайное название
        public String generateUniqFileName(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString() + ".jpg";
        }


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_LoadForm_2_Click(object sender, EventArgs e)
        {
            var load_form = new Form2();
            load_form.Show();
        }
    }
}
