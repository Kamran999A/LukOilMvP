using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using LukOilMVP.Presenters;
using LukOilMVP;

namespace LukOilMVP
{
    public static class JsonFileHelper
    {
        public static void JSONSerialization<T>(List<T> petrolPaymentOperations, string fileName)
        {
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                var serializer = new JsonSerializer();

                using (var sw = new StreamWriter($"{fileName}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;
                        serializer.Serialize(jw, petrolPaymentOperations);
                    }
                }
            }
        }
        public static List<T> JSONDeSerialization<T>(string fileName)
        {
            List<T> list = null;

            if (File.Exists($"{fileName}.json"))
            {
                var serializer = new JsonSerializer();

                using (var sr = new StreamReader($"{fileName}.json"))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        list = serializer.Deserialize<List<T>>(jr);
                    }
                }
            }

            return list;

        }

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mainView = new Form1();
            MainViewPresenter mainViewPresenter = new MainViewPresenter(mainView);

            Application.Run(mainView);
        }
    }
}
