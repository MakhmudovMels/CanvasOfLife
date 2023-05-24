using System.Collections.Generic;
using System.Drawing;

namespace CanvasOfLife
{
    /// <summary>
    /// Класс для генерации изображения
    /// </summary>
    public static class Canvas
    {
        /// <summary>
        /// Генерирует изображение
        /// </summary>
        /// <param name="backgroundPath">Путь к фоновому изображению</param>
        /// <param name="paths">Пути к пиктограммам</param>
        /// <returns>Возвращает сгенерированное изображение</returns>
        public static Bitmap CanvasGeneration(string backgroundPath, List<List<string>> paths)
        {
            Bitmap bitmap = new Bitmap(backgroundPath);

            #region Попиксельно устанавливаем пиктограммы на фоновое изображение

            // 1 вопрос
            var icon1 = new Bitmap(new Bitmap(paths[0][0]), 40, 40);
            for (int i = 0; i < icon1.Width; i++)
                for (int j = 0; j < icon1.Height; j++)
                {
                    bitmap.SetPixel(i + 770, j + bitmap.Height - 45, icon1.GetPixel(i, j));
                    bitmap.SetPixel(860 - i, j + bitmap.Height - 45, icon1.GetPixel(i, j));
                }
                          

            // 2 вопрос
            var icon2 = new Bitmap(new Bitmap(paths[1][0]), 20, 20);
            for (int i = 0; i < icon2.Width; i++)
                for (int j = 0; j < icon2.Height; j++)
                {
                    bitmap.SetPixel(i + bitmap.Width - 58, j + bitmap.Height - 28, icon2.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 28, j + bitmap.Height - 58, icon2.GetPixel(i, j));
                }
            icon2 = new Bitmap(icon2, 40, 40);
            for (int i = 0; i < icon2.Width; i++)
                for (int j = 0; j < icon2.Height; j++)
                {
                    bitmap.SetPixel(i + 700, j + bitmap.Height - 50, icon2.GetPixel(i, j));
                    bitmap.SetPixel(i + 895, j + bitmap.Height - 50, icon2.GetPixel(i, j));
                    bitmap.SetPixel(i + 750, j + bitmap.Height - 107, icon2.GetPixel(i, j));
                    bitmap.SetPixel(i + 850, j + bitmap.Height - 107, icon2.GetPixel(i, j));                   
                }

            // 3 и 4 вопросы
            var icon3 = new Bitmap(new Bitmap(paths[2][0]), 22, 22);
            var icon4 = new Bitmap(new Bitmap(paths[3][0]), 22, 22);
            for (int i = 0; i < icon3.Width; i++)
                for (int j = 0; j < icon3.Height; j++)
                {
                    bitmap.SetPixel(i + bitmap.Width - 92, j + bitmap.Height - 29, icon3.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 80, j + bitmap.Height - 57, icon4.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 58, j + bitmap.Height - 80, icon4.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 29, j + bitmap.Height - 92, icon3.GetPixel(i, j));
                }
            icon3 = new Bitmap(icon3, 40, 40);
            icon4 = new Bitmap(icon4, 40, 40);
            for (int i = 0; i < icon3.Width; i++)
                for (int j = 0; j < icon3.Height; j++)
                {
                    bitmap.SetPixel(i + 635, j + bitmap.Height - 50, icon3.GetPixel(i, j));
                    bitmap.SetPixel(i + 955, j + bitmap.Height - 50, icon3.GetPixel(i, j));
                    bitmap.SetPixel(i + 655, j + bitmap.Height - 105, icon4.GetPixel(i, j));
                    bitmap.SetPixel(i + 935, j + bitmap.Height - 105, icon4.GetPixel(i, j));
                    bitmap.SetPixel(i + 700, j + bitmap.Height - 150, icon4.GetPixel(i, j));
                    bitmap.SetPixel(i + 890, j + bitmap.Height - 150, icon4.GetPixel(i, j));
                    bitmap.SetPixel(i + 760, j + bitmap.Height - 180, icon3.GetPixel(i, j));
                    bitmap.SetPixel(i + 830, j + bitmap.Height - 180, icon3.GetPixel(i, j));         
                }

            // 5 и 6 вопросы
            var icon5 = new Bitmap(new Bitmap(paths[4][0]), 22, 22);
            var icon6 = new Bitmap(new Bitmap(paths[5][0]), 22, 22);
            for (int i = 0; i < icon5.Width; i++)
                for (int j = 0; j < icon5.Height; j++)
                {
                    bitmap.SetPixel(i + bitmap.Width - 125, j + bitmap.Height - 29, icon5.GetPixel(i, j));                 
                    bitmap.SetPixel(i + bitmap.Width - 29, j + bitmap.Height - 125, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 113, j + bitmap.Height - 64, icon6.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 64, j + bitmap.Height - 113, icon6.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 92, j + bitmap.Height - 92, icon5.GetPixel(i, j));
                }
            icon5 = new Bitmap(icon5, 40, 40);
            icon6 = new Bitmap(icon6, 40, 40);
            for (int i = 0; i < icon3.Width; i++)
                for (int j = 0; j < icon3.Height; j++)
                {
                    bitmap.SetPixel(i + 575, j + bitmap.Height - 50, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + 1015, j + bitmap.Height - 50, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + 587, j + bitmap.Height - 110, icon6.GetPixel(i, j));
                    bitmap.SetPixel(i + 1003, j + bitmap.Height - 110, icon6.GetPixel(i, j));
                    bitmap.SetPixel(i + 620, j + bitmap.Height - 160, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + 970, j + bitmap.Height - 160, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + 660, j + bitmap.Height - 200, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + 930, j + bitmap.Height - 200, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + 710, j + bitmap.Height - 230, icon6.GetPixel(i, j));
                    bitmap.SetPixel(i + 880, j + bitmap.Height - 230, icon6.GetPixel(i, j));
                    bitmap.SetPixel(i + 765, j + bitmap.Height - 245, icon5.GetPixel(i, j));
                    bitmap.SetPixel(i + 825, j + bitmap.Height - 245, icon5.GetPixel(i, j));
                }

            // 7 вопрос
            var icon7 = new List<Bitmap>();
            for (int c = 0; c < paths[6].Count; c++)
                icon7.Add(new Bitmap(new Bitmap(paths[6][c]), 35, 35));
            for (int i = 0; i < icon7[0].Width; i++)
                for (int j = 0; j < icon7[0].Height; j++)
                {
                    bitmap.SetPixel(i + bitmap.Width - 200, j + bitmap.Height - 40, icon7[0].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 230, j + bitmap.Height - 80, icon7[1 % icon7.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 195, j + bitmap.Height - 100, icon7[2 % icon7.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 155, j + bitmap.Height - 115, icon7[3 % icon7.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 152, j + bitmap.Height - 160, icon7[4 % icon7.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 152, j + bitmap.Height - 203, icon7[5 % icon7.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 110, j + bitmap.Height - 188, icon7[6 % icon7.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 70, j + bitmap.Height - 178, icon7[7 % icon7.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 40, j + bitmap.Height - 215, icon7[8 % icon7.Count].GetPixel(i, j));
                }

            // 8 вопрос
            var icon8 = new List<Bitmap>();
            for (int c = 0; c < paths[7].Count; c++)
                icon8.Add(new Bitmap(new Bitmap(paths[7][c]), 35, 35));
            for (int i = 0; i < icon8[0].Width; i++)
                for (int j = 0; j < icon8[0].Height; j++)
                {
                    bitmap.SetPixel(i + bitmap.Width - 262, j + bitmap.Height - 40, icon8[0].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 292, j + bitmap.Height - 78, icon8[1 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 315, j + bitmap.Height - 110, icon8[2 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 280, j + bitmap.Height - 130, icon8[3 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 240, j + bitmap.Height - 142, icon8[4 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 203, j + bitmap.Height - 160, icon8[5 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 205, j + bitmap.Height - 200, icon8[6 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 208, j + bitmap.Height - 240, icon8[7 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 205, j + bitmap.Height - 280, icon8[8 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 160, j + bitmap.Height - 265, icon8[9 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 120, j + bitmap.Height - 250, icon8[10 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 80, j + bitmap.Height - 240, icon8[11 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 58, j + bitmap.Height - 280, icon8[12 % icon8.Count].GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 40, j + bitmap.Height - 315, icon8[13 % icon8.Count].GetPixel(i, j));
                }

            // 9 вопрос
            var icon9 = new Bitmap(new Bitmap(paths[8][0]), 32, 32);
            for (int i = 0; i < icon9.Width; i++)
                for (int j = 0; j < icon9.Height; j++)
                {
                    bitmap.SetPixel(i + bitmap.Width - 325, j + bitmap.Height - 40, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 357, j + bitmap.Height - 80, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 350, j + bitmap.Height - 160, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 310, j + bitmap.Height - 170, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 255, j + bitmap.Height - 245, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 260, j + bitmap.Height - 285, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 200, j + bitmap.Height - 333, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 157, j + bitmap.Height - 315, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 70, j + bitmap.Height - 350, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 40, j + bitmap.Height - 395, icon9.GetPixel(i, j));                    
                }
            icon9 = new Bitmap(icon9, 47, 47);
            for (int i = 0; i < icon9.Width; i++)
                for (int j = 0; j < icon9.Height; j++)
                {
                    bitmap.SetPixel(i + bitmap.Width - 398, j + bitmap.Height - 145, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 268, j + bitmap.Height - 200, icon9.GetPixel(i, j));
                    bitmap.SetPixel(i + bitmap.Width - 258, j + bitmap.Height - 346, icon9.GetPixel(i, j));                    
                    bitmap.SetPixel(i + bitmap.Width - 115, j + bitmap.Height - 310, icon9.GetPixel(i, j));                    
                }

            // 10 вопрос
            var icon10 = new List<Bitmap>();
            for (int c = 0; c < paths[9].Count; c++)
                icon10.Add(new Bitmap(new Bitmap(paths[9][c]), 50, 50));
            for (int i = 0; i < icon10[0].Width; i++)
                for (int j = 0; j < icon10[0].Height; j++)
                {
                    int p = 0;
                    for (int k = 350; k < bitmap.Height; k += 67)
                    {
                        bitmap.SetPixel(i + 360, j + k, icon10[p % paths[9].Count].GetPixel(i, j));
                        p++;
                    }
                    p = 0;
                    for (int k = 420; k < bitmap.Width - 50; k += 68)
                    {
                        bitmap.SetPixel(i + k, j + 343, icon10[p % paths[9].Count].GetPixel(i, j));
                        p++;
                    }
                }

            // 11 вопрос
            var icon11 = new Bitmap(new Bitmap(paths[10][0]), 50, 50);
            for (int i = 0; i < icon11.Width; i++)
                for (int j = 0; j < icon11.Height; j++)
                {
                    for(int k = 278; k < bitmap.Height; k+=67)
                        bitmap.SetPixel(i + 288, j + k, icon11.GetPixel(i, j));
                    for (int k = 286; k < bitmap.Width - 45; k += 68)
                        bitmap.SetPixel(i + k, j + 273, icon11.GetPixel(i, j));
                }

            // 12 вопрос
            var icon12 = new List<Bitmap>();
            for (int c = 0; c < paths[11].Count; c++)
                icon12.Add(new Bitmap(new Bitmap(paths[11][c]), 50, 50));
            for (int i = 0; i < icon12[0].Width; i++)
                for (int j = 0; j < icon12[0].Height; j++)
                {
                    int p = 0;
                    for (int k = 203; k < bitmap.Height - 60; k += 68)
                    {
                        bitmap.SetPixel(i + 211, j + k, icon12[p % paths[11].Count].GetPixel(i, j));
                        p++;
                    }
                    p = 0;
                    for (int k = 278; k < bitmap.Width - 45; k += 68)
                    {
                        bitmap.SetPixel(i + k, j + 196, icon12[p % paths[11].Count].GetPixel(i, j));
                        p++;
                    }
                }

            // 13 вопрос            
            var icon13 = new List<Bitmap>();
            for (int c = 0; c < paths[12].Count; c++)
                icon13.Add(new Bitmap(new Bitmap(paths[12][c]), 50, 50));
            for (int i = 0; i < icon13[0].Width; i++)
                for (int j = 0; j < icon13[0].Height; j++)
                {
                    int p = 0;
                    for (int k = 134; k < bitmap.Height - 60; k += 68)
                    {
                        bitmap.SetPixel(i + 135, j + k, icon13[p % paths[12].Count].GetPixel(i, j));
                        p++;
                    }
                    p = 0;
                    for (int k = 212; k < bitmap.Width - 45; k += 68)
                    {
                        bitmap.SetPixel(i + k, j + 131, icon13[p % paths[12].Count].GetPixel(i, j));
                        p++;
                    }
                }

            // 14 вопрос
            var icon14 = new List<Bitmap>();
            for (int c = 0; c < paths[13].Count; c++)
                icon14.Add(new Bitmap(new Bitmap(paths[13][c]), 50, 50));
            for (int i = 0; i < icon14[0].Width; i++)
                for (int j = 0; j < icon14[0].Height; j++)
                {
                    int p = 0;
                    for (int k = 64; k < bitmap.Height - 60; k += 68)
                    {
                        bitmap.SetPixel(i + 58, j + k, icon14[p % paths[13].Count].GetPixel(i, j));
                        p++;
                    }
                    p = 0;
                    for (int k = 138; k < bitmap.Width - 45; k += 68)
                    {
                        bitmap.SetPixel(i + k, j + 55, icon14[p % paths[13].Count].GetPixel(i, j));
                        p++;
                    }
                }

            //Отражаем сформированную четверть по вертикали и по горизонтали
            var newBitmap = new Bitmap(bitmap.Width * 2, bitmap.Height * 2);
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color clr = bitmap.GetPixel(i, j);
                    newBitmap.SetPixel(i, j, clr);
                    newBitmap.SetPixel(2 * bitmap.Width - 1 - i, j, clr);
                    newBitmap.SetPixel(i, 2 * bitmap.Height - 1 - j, clr);
                    newBitmap.SetPixel(2 * bitmap.Width - 1 - i, 2 * bitmap.Height - 1 - j, clr);
                }

            // 1 вопрос
            icon1 = new Bitmap(new Bitmap(paths[0][0]), 50, 50);
            for (int i = 0; i < icon1.Width; i++)
                for (int j = 0; j < icon1.Height; j++)
                    newBitmap.SetPixel(i + bitmap.Width - 25, j + bitmap.Height - 25, icon1.GetPixel(i, j));

            #endregion

            return newBitmap;               
        }
    }
}
