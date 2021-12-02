using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrozenFile
{
    class Program
    {
        class LetItGo
        {
            string name;
            string gift;
            public LetItGo(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }
            public string Name
            {
                get { return name; }

            }
            public string Gift
            {
                get { return gift; }

            }


        }
        static void Main(string[] args)
        {
            List<string> GiftPrice = getFrozenFromFile().ToList();
            List<LetItGo> listOfGifts = new List<LetItGo>();
            foreach (string giftRecord in GiftPrice)
            {
                string[] tempArray = giftRecord.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                LetItGo newLetItGo = new LetItGo(tempArray[0], tempArray[1]);
                listOfGifts.Add(newLetItGo);
            }
            foreach (LetItGo letItGo in listOfGifts)
            {
                Console.WriteLine($"{letItGo.Name} Wants {letItGo.Gift} for Christmas");
            }
        }
        public static string[] getFrozenFromFile()
        {
            string filepath = @"C:\Users\opilane\samples\Frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);
            return dataFromFile;
        }
        public static void ShowDataFromArray(string[] someArray)
        {
            foreach (string line in someArray)
            {
                Console.WriteLine(line);
            }
        }

    }
}
