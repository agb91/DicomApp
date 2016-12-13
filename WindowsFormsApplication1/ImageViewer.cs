using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ImageViewer : Form
    {
        Image i;
        public ImageViewer(Image i)
        {
            InitializeComponent();
            this.i = i;
            image.Image = i;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
