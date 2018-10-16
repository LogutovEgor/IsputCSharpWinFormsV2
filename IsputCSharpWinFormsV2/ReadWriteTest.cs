using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters;

namespace IsputCSharpWinFormsV2
{
    class ReadWriteTest
    {
        private static ReadWriteTest Instance;
        public void ReadTest(string filePath)
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Test));
            //
            StreamReader streamReader = new StreamReader("myFile.tst");
            Manager.GetInstance().CurrentTest = (Test)formatter.Deserialize(streamReader);
            streamReader.Dispose();
            streamReader.Close();
        }
        public void WriteTest()
        {   


            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Test));
            
            
            /*// получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, bla1);

            }

            // десериализация
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                bla bla2 = (bla)formatter.Deserialize(fs);

            }*/
            StreamWriter streamWriter = new StreamWriter("myFile.tst", false);
            
            formatter.Serialize(streamWriter, Manager.GetInstance().CurrentTest);
            streamWriter.Dispose();
            streamWriter.Close();


        }
        public static ReadWriteTest GetInstance()
        {
            if (Instance == null)
                Instance = new ReadWriteTest();
            return Instance;
        }
    }
}
