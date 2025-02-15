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

namespace dem_to_stl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenSTL_Click(object sender, EventArgs e)
        {
            string inputBitmapPath = textBoxInput.Text;
            string outputStlPath = textBoxOutput.Text;

            if (!File.Exists(inputBitmapPath))
            {
                MessageBox.Show("file \"" + inputBitmapPath + "\"\n not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (outputStlPath == "")
            {
                MessageBox.Show("set output filename.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            ProcessBitmap(inputBitmapPath, outputStlPath);
            Cursor.Current = Cursors.Default;
            MessageBox.Show("finished.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ProcessBitmap(string inputPath, string outputPath)
        {
            using (Bitmap bitmap = new Bitmap(inputPath))
            {
                int width = bitmap.Width;
                int height = bitmap.Height;
                float color_coef = (float)numericUpDownCoeff.Value;
                // グレースケール変換とバイナリSTL生成
                ConvertToGrayscaleAndGenerateBinarySTL(bitmap, width, height, outputPath, color_coef);
            }
        }

        private static void ConvertToGrayscaleAndGenerateBinarySTL(Bitmap bitmap, int width, int height, string outputPath, float color_coef = 1.0f)
        {
            using (var stlWriter = new BinaryWriter(File.Open(outputPath, FileMode.Create)))
            {
                // STLバイナリヘッダー（80バイト）
                byte[] header = new byte[80];
                Encoding.ASCII.GetBytes("Binary STL Elevation Map with Radial Base", 0, 38, header, 0);
                stlWriter.Write(header);

                // トライアングルの総数
                uint triangleCount = (uint)((width - 1) * (height - 1) * 2 + (width + height - 2) * 2 + (width + height - 2) * 4);
                stlWriter.Write(triangleCount);

                // 地形のトライアングル
                for (int y = 0; y < height - 1; y++)
                {
                    for (int x = 0; x < width - 1; x++)
                    {
                        Color c1 = bitmap.GetPixel(x, height - 1 - y);
                        Color c2 = bitmap.GetPixel(x + 1, height - 1 - y);
                        Color c3 = bitmap.GetPixel(x, height - 1 - (y + 1));
                        Color c4 = bitmap.GetPixel(x + 1, height - 1 - (y + 1));

                        float z1 = (c1.R + c1.G + c1.B) / 3f * color_coef;
                        float z2 = (c2.R + c2.G + c2.B) / 3f * color_coef;
                        float z3 = (c3.R + c3.G + c3.B) / 3f * color_coef;
                        float z4 = (c4.R + c4.G + c4.B) / 3f * color_coef;

                        WriteTriangle(stlWriter, x, y, z1, x + 1, y, z2, x, y + 1, z3);
                        WriteTriangle(stlWriter, x + 1, y, z2, x + 1, y + 1, z4, x, y + 1, z3);
                    }
                }

                // 底面のトライアングルを中央から放射状に生成
                float centerX = (width - 1) / 2f;
                float centerY = (height - 1) / 2f;
                float baseZ = 0; // 底面の高さは0とする

                // Xループ：前壁と後壁へのトライアングル（法線ベクトルを下向きにするため頂点順序を変更）
                for (int x = 0; x < width - 1; x++)
                {
                    WriteTriangle(stlWriter, x + 1, 0, baseZ, x, 0, baseZ, centerX, centerY, baseZ); // 前壁
                    WriteTriangle(stlWriter, x + 1, height - 1, baseZ, centerX, centerY, baseZ, x, height - 1, baseZ); // 後壁
                }

                // Yループ：右壁と左壁へのトライアングル（法線ベクトルを下向きにするため頂点順序を変更）
                for (int y = 0; y < height - 1; y++)
                {
                    WriteTriangle(stlWriter, 0, y + 1, baseZ, centerX, centerY, baseZ, 0, y, baseZ); // 左壁
                    WriteTriangle(stlWriter, width - 1, y + 1, baseZ, width - 1, y, baseZ, centerX, centerY, baseZ); // 右壁
                }

                // 壁のトライアングル（地形の高さデータを利用）：前壁、後壁、左壁の修正
                for (int x = 0; x < width - 1; x++)
                {
                    Color cTop = bitmap.GetPixel(x, height - 1);
                    Color cBottom = bitmap.GetPixel(x, 0);
                    Color cTopNext = bitmap.GetPixel(x + 1, height - 1);
                    Color cBottomNext = bitmap.GetPixel(x + 1, 0);
                    float zTop = (cTop.R + cTop.G + cTop.B) / 3f * color_coef;
                    float zBottom = (cBottom.R + cBottom.G + cBottom.B) / 3f * color_coef;
                    float zTopNext = (cTopNext.R + cTopNext.G + cTopNext.B) / 3f * color_coef;
                    float zBottomNext = (cBottomNext.R + cBottomNext.G + cBottomNext.B) / 3f * color_coef;

                    WriteTriangle(stlWriter, x, 0, zTop, x, 0, baseZ, x + 1, 0, baseZ); // 前壁
                    WriteTriangle(stlWriter, x, 0, zTop, x + 1, 0, baseZ, x + 1, 0, zTopNext); // 前壁

                    WriteTriangle(stlWriter, x, height - 1, zBottom, x + 1, height - 1, baseZ, x, height - 1, baseZ); // 後壁
                    WriteTriangle(stlWriter, x, height - 1, zBottom, x + 1, height - 1, zBottomNext, x + 1, height - 1, baseZ); // 後壁
                }
                for (int y = 0; y < height - 1; y++)
                {
                    Color cLeft = bitmap.GetPixel(0, height - 1 - y);
                    Color cRight = bitmap.GetPixel(width - 1, height - 1 - y);
                    Color cLeftNext = bitmap.GetPixel(0, height - 1 - (y + 1));
                    Color cRightNext = bitmap.GetPixel(width - 1, height - 1 - (y + 1));
                    float zLeft = (cLeft.R + cLeft.G + cLeft.B) / 3f * color_coef;
                    float zRight = (cRight.R + cRight.G + cRight.B) / 3f * color_coef;
                    float zLeftNext = (cLeftNext.R + cLeftNext.G + cLeftNext.B) / 3f * color_coef;
                    float zRightNext = (cRightNext.R + cRightNext.G + cRightNext.B) / 3f * color_coef;

                    WriteTriangle(stlWriter, 0, y, zLeft, 0, y + 1, baseZ, 0, y, baseZ); // 左壁
                    WriteTriangle(stlWriter, 0, y, zLeft, 0, y + 1, zLeftNext, 0, y + 1, baseZ); // 左壁

                    WriteTriangle(stlWriter, width - 1, y, zRight, width - 1, y, baseZ, width - 1, y + 1, baseZ); // 右壁
                    WriteTriangle(stlWriter, width - 1, y, zRight, width - 1, y + 1, baseZ, width - 1, y + 1, zRightNext); // 右壁
                }
            }
        }

        private static void WriteTriangle(BinaryWriter writer, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3)
        {
            // 法線ベクトルを3つの頂点から計算
            float ux = x2 - x1;
            float uy = y2 - y1;
            float uz = z2 - z1;
            float vx = x3 - x1;
            float vy = y3 - y1;
            float vz = z3 - z1;

            // 法線ベクトルの計算
            float nx = uy * vz - uz * vy;
            float ny = uz * vx - ux * vz;
            float nz = ux * vy - uy * vx;

            // 法線の正規化（大きさを1にする）
            float length = (float)Math.Sqrt(nx * nx + ny * ny + nz * nz);
            if (length != 0)  // ゼロ除算を防ぐ
            {
                nx /= length;
                ny /= length;
                nz /= length;
            }

            writer.Write(nx);
            writer.Write(ny);
            writer.Write(nz);

            // 頂点1
            writer.Write(x1);
            writer.Write(y1);
            writer.Write(z1);

            // 頂点2
            writer.Write(x2);
            writer.Write(y2);
            writer.Write(z2);

            // 頂点3
            writer.Write(x3);
            writer.Write(y3);
            writer.Write(z3);

            // 属性バイトカウント（常に0）
            writer.Write((ushort)0);
        }

        private void buttonOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.Filter = "Image file(*.png;*.bmp)|*.png;*.bmp|All file(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "Select input image filename.";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxInput.Text = ofd.FileName;

                using (Bitmap bitmap = new Bitmap(ofd.FileName))
                {
                    int width = bitmap.Width;
                    int height = bitmap.Height;

                    textBoxImagesize.Text = width.ToString() + " x " + height.ToString();
                }
            }
        }

        private void buttonSavefile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "output.stl";
            sfd.Filter = "STL file(*.stl)|*.stl";
            sfd.FilterIndex = 1;
            sfd.Title = "Select output filename";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = sfd.FileName;
            }
        }

        private void buttonCalcCoeff_Click(object sender, EventArgs e)
        {
            double mppx = (double)numericUpDownMpPx.Value;
            double minH = (double)numericUpDownMinHeight.Value;
            double maxH = (double)numericUpDownMaxHeight.Value;

            if (minH >= maxH)
            {
                MessageBox.Show("max height must be greater than min height", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double coef = (maxH - minH) / 255.0 / mppx;
            numericUpDownCoeff.Value = (decimal)coef;

        }
    }
}
