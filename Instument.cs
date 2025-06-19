using System.Drawing;
using System.Text.Json.Serialization;

namespace KursovaRobota
{
    public class Instrument
    {
        private string type;
        private string name;
        private string description;
        private double price;
        private Image img;
        private bool isAssigned;
        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { price = value; } }

        public bool IsAssigned
        {
            get { return isAssigned; }
            set { isAssigned = value; }
        }
        [JsonIgnore]
        public Image Img
        {
            get { return img; }
            set { img = value != null ? ResizeImage(value, 200, 400) : null; }
        }

        public string ImgBase64
        {
            get
            {
                if (Img == null) return null;
                using (var ms = new MemoryStream())
                {
                    Img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Img = null;
                }
                else
                {
                    byte[] bytes = Convert.FromBase64String(value);
                    using (var ms = new MemoryStream(bytes))
                    {
                        Img = Image.FromStream(ms);
                    }
                }
            }
        }

        public Instrument(string type, string name, string description, double price, Image img)
        {
            Type = type;
            Name = name;
            Description = description;
            Price = price;
            Img = img;
            isAssigned = false;
        }
        private static Image ResizeImage(Image source, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                float ratio = Math.Min((float)source.Width / width, (float)source.Height / height);
                int cropWidth = (int)(width * ratio);
                int cropHeight = (int)(height * ratio);
                int cropX = (source.Width - cropWidth) / 2;
                int cropY = (source.Height - cropHeight) / 2;
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(cropX, cropY, cropWidth, cropHeight), GraphicsUnit.Pixel);
            }
            return bmp;
        }
    }
}
