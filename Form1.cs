using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {

                Image.Image = Encode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Bitmap DrawMatrix(bool[] matrix, int rows, int columns)
        {
            var image = new Bitmap(Image.Width, Image.Height);
            float scale = (float)image.Width / columns;
            using (var graphics = Graphics.FromImage(image))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (var j = 0; j < columns; j++)
                    {
                        var color = Color.White;
                        if (matrix[i * columns + j])
                        {
                            color = Color.Black;
                        }

                        graphics.FillRectangle(
                            new SolidBrush(color),
                            new RectangleF(
                            j * scale,
                            i * scale,
                            scale,
                            scale));
                    }
                }
            }
            return image;

        }
        private Bitmap Encode()
        {
      
            var encoder = new Encoder();
            bool[] matrix = encoder.Encode(Input.Text);
            var columns = encoder.GetColumns();
            var rows = encoder.GetRows();
            var image = DrawMatrix(matrix, rows, columns);
            return image;
        }

    }
}
