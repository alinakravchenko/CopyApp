using System.Text;

namespace CopyApp
{
    public partial class Form1 : Form
    {
        byte[] data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tb_originPath.Text = Directory.GetCurrentDirectory();
            //tb_targetPath.Text = Directory.GetCurrentDirectory();
            tb_originPath.Text = @"D:\text.txt";
            tb_targetPath.Text = @"D:\textcopy.txt";
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            ofd_originPath.FileName= Directory.GetCurrentDirectory();
            if(ofd_originPath.ShowDialog() == DialogResult.OK)
            {
                tb_originPath.Text = ofd_originPath.FileName;
                tb_targetPath.Text = ofd_originPath.FileName; 
            }
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(tb_originPath.Text, FileMode.Open);
            //byte[] data = new byte[5];
            //fs.Read(data, 0, 5); //offset - смещение от начала файла
            //fs.Close();
            //FileStream fsclose = new FileStream(tb_targetPath.Text, FileMode.OpenOrCreate);
            //fsclose.Write(data, 0, 5);
            //fsclose.Close();


            //копирует всю информацию в файле
            FileStream fsopen = new FileStream(tb_originPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read, 100, FileOptions.Asynchronous);
            FileStream fsclose = new FileStream(tb_targetPath.Text, FileMode.OpenOrCreate);
           
            long lengthfile = fsopen.Length;
            //  Устанавливаем начальные значения прогресс бара       
            pb_CopyProgress.Maximum = 1000;
            pb_CopyProgress.Minimum = 0;
            //long test = 50;
            int countOperation = 1000;
            long[] partfilelength = new long[countOperation];
            for (int i = 0; i < countOperation; i++)
            {
                partfilelength[i] = lengthfile /*test*/ / countOperation;
                if (i == countOperation - 1)
                    partfilelength[i] += lengthfile /*test*/ % countOperation;
            }

            //foreach(int i in partfilelength)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            //чтение по byte
            //while ((b = fsopen.ReadByte()) != -1)
            //{
            //    fsclose.WriteByte((byte)b);
            //}

            //устанавливаем значение прогресс бара
            long pbvalue = 1;
            if (lengthfile > 1000)
                pbvalue = lengthfile / 1000;
            for (int i = 0; i < 3; i++)
            {
            data = new byte[partfilelength[i]];
            fsopen.BeginRead(data, 0, data.Length, MessageBoxPrint, fsopen);

            }

            //примеры не эффективной обработки Async запросов
            //IAsyncResult result;
            //result = fsopen.BeginRead(b, 0, b.Length, null, null);
            /*fsopen.EndRead(result);*/ //ждём окончание потока и получаем Result. останаваливает поток, пока Async не вернёт результат

            /*while (!result.IsCompleted) // проверка выполнения fsopen.BeginRead. 
           // Асинхронная операция не возвращает готовый результат, пока не выполнит все операции.
           // А запрос к результатам мы можем попробовать сделать раньше выполнения и это вызовет ошибку.
          {
              richTextBox1.Text = "Еще не готово";
          }*/

            //foreach (long i in partfilelength)
            //{
            //    b = new byte[i];
            //    fsopen.Read(b, 0, b.Length);
            //    fsclose.Write(b, 0, b.Length);
            //    pb_CopyProgress.Value = (int)(lengthfile / pbvalue);
            //}
            fsopen.Close();
            fsclose.Close();
        }
        void MessageBoxPrint (IAsyncResult asyncResult)
        {
            FileStream fileStream = (FileStream)asyncResult.AsyncState;
          fileStream.EndRead(asyncResult);
            //Array.Resize(ref data, result);
            string res =Encoding.UTF8.GetString(data);
           
            MessageBox.Show(res);
            
        }
    }
}