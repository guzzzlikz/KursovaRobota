using System.Drawing;
using System.IO;

namespace KursovaRobota
{
    public class Database
    {
        public static List<Instrument> instruments = new List<Instrument>();
        public static List<Instrument> toBasket = new List<Instrument>();
        static Database()
        {
            instruments.Add(new Instrument(
                "Електрогітара",
                "Woodstock Standard Tele MN Shell Pink",
                "Електрогітара для початківців",
                800,
                Properties.Resources.woodstock1
            ));
            instruments.Add(new Instrument(
                "Гітара",
                "Yamaha FS100C (Natural)",
                "Звичайна класична гітара",
                300,
                Properties.Resources.yamaha
            ));
            instruments.Add(new Instrument(
                "Барабани",
                "Mapex BM628SBNNL",
                "Набір томів (бочка, верхні, нижній, робочий)",
                550,
                Properties.Resources.bmDrums
            ));
            instruments.Add(new Instrument(
                "Підсилювач",
                "VOX VX15 GT",
                "Підсилювач для електрогітари з AUX портом",
                100,
                Properties.Resources.voxVx15
            ));
            instruments.Add(new Instrument(
                "Бас-гітара",
                "IBANEZ GSR180 BSB",
                "Бас-гітара з 4 струнами для початківців",
                250,
                Properties.Resources.ibanezGSR
            ));
            instruments.Add(new Instrument(
                "Бас-гітара",
                "IBANEZ EHB1500 CTF",
                "Бас-гітара з 4 струнами для професіоналів",
                2000,
                Properties.Resources.ibanezEHB
            ));
            instruments.Add(new Instrument(
                "Скрипка",
                "CREMONA Cervini HV-100",
                "Звичайна скрипка для початківців",
                150,
                Properties.Resources.CerviniHV
            ));
            instruments.Add(new Instrument(
                "Тюнер",
                "FENDER ORIGINAL TUNERS DAPHNE BLUE",
                "Тюнер для електрогітари",
                60,
                Properties.Resources.fenderOriginal
            ));
            instruments.Add(new Instrument(
                "Педаль",
                "Orange AMP-DETONATOR",
                "Педаль ефектів до електрогітари",
                150,
                Properties.Resources.ampDetonator
            ));
            instruments.Add(new Instrument(
                "Електрогітара",
                "JACKSON PRO SERIES MODERN DINKY MDK",
                "Електрогітара з вбудованими ефектами",
                1400,
                Properties.Resources.JacksonPro
            ));
        }
    }
}
