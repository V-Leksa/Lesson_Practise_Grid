using CsvHelper;
using Lesson_Practise_Grid.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Lesson_Practise_Grid.Services
{
    public class CsvFileReader
    {
        public static ObservableCollection<Good> ReadCSVFile()
        {
            List<Good> products;
            using (StreamReader reader = new StreamReader("ClothProducts.csv"))
            {
                CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);

                products = csvReader.GetRecords<Good>().ToList();
            }
            ObservableCollection<Good> listOfGoods = new ObservableCollection<Good>();
            foreach (Good product in products)
            {
                listOfGoods.Add(product);
            }

            return listOfGoods;
        }
    }
}
