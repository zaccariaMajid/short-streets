using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PCTO
{
    public class MarkersImg
    {
        public MarkersImg()
        {
            Images = new Bitmap[]
            {
                new Bitmap("markers/Home.bmp"),
                new Bitmap("markers/1.bmp"),
                new Bitmap("markers/2.bmp"),
                new Bitmap("markers/3.bmp"),
                new Bitmap("markers/4.bmp"),
                new Bitmap("markers/5.bmp"),
                new Bitmap("markers/6.bmp"),
                new Bitmap("markers/7.bmp"),
                new Bitmap("markers/8.bmp"),
                new Bitmap("markers/9.bmp"),
                new Bitmap("markers/10.bmp"),
                new Bitmap("markers/11.bmp"),
                new Bitmap("markers/12.bmp"),
                new Bitmap("markers/13.bmp"),
                new Bitmap("markers/14.bmp"),
                new Bitmap("markers/15.bmp")
            };
        }
        public Bitmap[] Images { get; }

    }
}
