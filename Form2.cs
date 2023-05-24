using System;
using System.Drawing;
using System.Windows.Forms;

namespace CanvasOfLife
{
    /// <summary>
    /// Форма для отображения сгенерированного изображения
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Сгенерированное изображение
        /// </summary>
        private Bitmap bitmap;
        public Form2(Bitmap _bitmap)
        {
            InitializeComponent();
            bitmap = _bitmap;
            // отображаем сгенерированное изображение в форме
            pictureBox1.Image = bitmap;
            saveFileDialog1.Filter = "Image files (*.jpg)|*.jpg";
        }

        /// <summary>
        /// Сохраняет сгенерированное изображение по выбранному пути
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;            
            string filename = saveFileDialog1.FileName;
            // сохраняем изображение в файл
            bitmap.Save(filename);
            MessageBox.Show("Файл успешно сохранён", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
