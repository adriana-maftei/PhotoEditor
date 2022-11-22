using System.Drawing.Imaging;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image file;
        private Boolean opened = false;

        #region Interface

        private void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        private void btn_open_Click(object sender, EventArgs e) => openImage();

        private void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog(); // create a new save file dialog object
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png; // store it in by default format
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;

                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else { MessageBox.Show("No image loaded, first upload image "); }
        }

        private void btn_save_Click(object sender, EventArgs e) => saveImage();

        private void resetImage()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                if (opened) //remove filter changes
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    opened = true;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            redBar.Value = 0;
            greenBar.Value = 0;
            blueBar.Value = 0;
            resetImage();
        }

        private void redBar_ValueChanged(object sender, EventArgs e) => HUE();

        private void greenBar_ValueChanged(object sender, EventArgs e) => HUE();

        private void blueBar_ValueChanged(object sender, EventArgs e) => HUE();

        #endregion Interface

        #region Filter Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            resetImage(); //reset first so we don't apply one filter on top of the other
            winterFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetImage();
            vulcanoFilter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetImage();
            ancientFilter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetImage();
            plumFilter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resetImage();
            fogFilter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resetImage();
            flashFilter();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resetImage();
            frozenFilter();
        }

        #endregion 

        /*-------------------------------------- Color Matrix Combinations

                     R G B A W            R G B A W             R   G   B   A   W
                 R  [1 0 0 0 0]       R  [c 0 0 0 0]       R  [sr+s sr  sr  0   0]
                 G  [0 1 0 0 0]       G  [0 c 0 0 0]       G  [ sg sg+s sg  0   0]
                 B  [0 0 1 0 0]    X  B  [0 0 c 0 0]    X  B  [ sb  sb sb+s 0   0]
                 A  [0 0 0 1 0]       A  [0 0 0 1 0]       A  [ 0   0   0   1   0]
                 W  [b b b 0 1]       W  [t t t 0 1]       W  [ 0   0   0   0   1]

                Brightness Matrix     Contrast Matrix          Saturation Matrix
                                        R      G      B      A      W
                                 R  [c(sr+s) c(sr)  c(sr)    0      0   ]
                                 G  [ c(sg) c(sg+s) c(sg)    0      0   ]
                         ===>    B  [ c(sb)  c(sb) c(sb+s)   0      0   ]
                                 A  [   0      0      0      1      0   ]
                                 W  [  t+b    t+b    t+b     0      1   ]

        --------------------------------------- Transformation Matrix */

        private void HUE()
        {
            float changeRed = redBar.Value * 0.1f;
            float changeGreen = greenBar.Value * 0.1f;
            float changeBlue = blueBar.Value * 0.1f;

            resetImage();

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picture box which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of image attribute "ia" to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1 + changeRed, 0, 0, 0, 0}, //red line
                    new float[]{0, 1 + changeGreen, 0, 0, 0}, // green line
                    new float[]{0, 0, 1 + changeBlue, 0, 0}, //blue line
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);   //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */

                g.Dispose(); //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;
            }
        }

        #region Gray Scale Filters

        private void grayScale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void fogFilter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0.7f, 0, 0, 0},
                    new float[]{0, 0, 1+1.3f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void flashFilter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
                    new float[]{0, 1+1.5f, 0, 0, 0},
                    new float[]{0, 0, 1+1.3f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void frozenFilter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0f, 0, 0, 0},
                    new float[]{0, 0, 1+5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        #endregion Gray Scale Filters

        #region Red Filters

        private void redScale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                   new float[]{.393f, .349f, .272f, 0, 0},
                   new float[]{.769f, .686f, .534f, 0, 0},
                   new float[]{.189f, .168f, .131f, 0, 0},
                   new float[]{0, 0, 0, 1, 0},
                   new float[]{0, 0, 0, 0, 1}
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void vulcanoFilter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
                    new float[]{.769f, .686f+0.5f, .534f, 0, 0},
                    new float[]{.189f+2.3f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void ancientFilter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
                    new float[]{.769f+0.3f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void plumFilter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f+0.2f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.9f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        #endregion Red Filters

        #region Blue Filters

        private void winterFilter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        #endregion Blue Filters
    }
}