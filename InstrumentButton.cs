using System.Windows.Forms;

namespace KursovaRobota
{
    public class InstrumentButton : Button
    {
        private Instrument cur;
        public Instrument Current { get { return cur; } set { cur = value; } }

        public InstrumentButton(int x, int y, Instrument cur)
        {
            this.Current = cur;
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(30, 30);
        }
        public InstrumentButton(int x, int y)
        {
            this.Current = null;
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new System.Drawing.Size(30, 30);
        }
    }
}
