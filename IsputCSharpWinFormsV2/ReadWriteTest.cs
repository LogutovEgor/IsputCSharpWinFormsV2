﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;

namespace IsputCSharpWinFormsV2
{
    class ReadWriteTest
    {
        private static ReadWriteTest Instance;
        public void ReadTest(string filePath)
        {
            ///через XML
            /*
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Test));
            //
            StreamReader streamReader = new StreamReader("myFile.tst");
            Manager.GetInstance().CurrentTest = (Test)formatter.Deserialize(streamReader);
            streamReader.Dispose();
            streamReader.Close();*/

            ///через бинарный форматер
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("myFile.tst", FileMode.OpenOrCreate))
            {
                Manager.GetInstance().CurrentTest = (Test)binaryFormatter.Deserialize(fs);
            }

        }
        public void WriteTest()
        {

            ///Через XML
            // передаем в конструктор тип класса
            /*
            XmlSerializer formatter = new XmlSerializer(typeof(Test));
            StreamWriter streamWriter = new StreamWriter("myFile.tst", false);
            formatter.Serialize(streamWriter, Manager.GetInstance().CurrentTest);
            streamWriter.Dispose();
            streamWriter.Close();
            */
            /// через бинарный форматер
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("myFile.tst", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Manager.GetInstance().CurrentTest);
            }
           
        }
        public static ReadWriteTest GetInstance()
        {
            if (Instance == null)
                Instance = new ReadWriteTest();
            return Instance;
        }
    }
}
