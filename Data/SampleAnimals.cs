using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models;


namespace ZooManagement.Data
{
    public static class SampleAnimals
    {
        public const int NumberOfAnimals = 100;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "1","Vulture","Bird", "Kania","Male","15/09/2000","25/09/2000"},
            new List<string> { "2","Elephant","Mammal", "Scotty","Male","11/11/1998","15/11/1998"},
            new List<string> { "3","Wolf","Mammal", "Colly","Male","19/05/2002","02/06/2002"},
            new List<string> { "4","Grizzly Bear","Mammal", "Barnie","Female","05/08/2002","20/08/2002"},
            new List<string> { "5","Wolf","Mammal", "Brandon","Male","19/04/2003","03/05/2003"},
            new List<string> { "6","Komodo Dragon","Reptile", "Carlos","Male","17/02/2003","01/03/2003"},
            new List<string> { "7","Giraffe","Mammal", "Zeke","Male","09/10/2003","15/10/2003"},
            new List<string> { "8","Tiger","Mammal", "Henrietta","Male","05/12/1998","07/12/1998"},
            new List<string> { "9","Grizzly Bear","Mammal", "Maxine","Female","03/05/2002","18/05/2002"},
            new List<string> { "10","Zebra","Mammal", "Adorne","Female","23/01/2003","03/02/2003"},
            new List<string> { "11","Polar Bear","Mammal", "Roslyn","Female","27/04/2001","04/05/2001"},
            new List<string> { "12","Zebra","Mammal", "Kalindi","Female","09/05/1999","20/05/1999"},
            new List<string> { "13","Eagle","Bird", "Silva","Female","04/02/1999","13/02/1999"},
            new List<string> { "14","Wolf","Mammal", "Gnni","Male","24/11/2002","08/12/2002"},
            new List<string> { "15","Honey Badger","Mammal", "Jobi","Male","19/03/1999","04/04/1999"},
            new List<string> { "16","Praying Mantis","Insect", "Laurice","Male","24/06/1999","12/07/1999"},
            new List<string> { "17","Zebra","Mammal", "Orsola","Female","03/11/1999","14/11/1999"},
            new List<string> { "18","Squirrel Monkey","Mammal", "Dante","Female","12/07/2000","13/07/2000"},
            new List<string> { "19","Zebra","Mammal", "Shantee","Female","11/10/2002","22/10/2002"},
            new List<string> { "20","Squirrel Monkey","Mammal", "Mendy","Female","08/01/2000","09/01/2000"},
            new List<string> { "21","Squirrel Monkey","Mammal", "Ralph","Female","07/11/1998","08/11/1998"},
            new List<string> { "22","Wolf","Mammal", "Zsa zsa","Male","08/06/2001","22/06/2001"},
            new List<string> { "23","Eagle","Bird", "Fleurette","Female","12/11/2001","21/11/2001"},
            new List<string> { "24","Honey Badger","Mammal", "Zelda","Male","08/06/2003","24/06/2003"},
            new List<string> { "25","Grizzly Bear","Mammal", "Kaitlyn","Female","23/09/2002","08/10/2002"},
            new List<string> { "26","Wolf","Mammal", "Aube","Male","26/02/2000","11/03/2000"},
            new List<string> { "27","Cobra","Invertibrate", "Natala","Male","06/11/1999","14/11/1999"},
            new List<string> { "28","Honey Badger","Mammal", "Ev","Male","07/03/2000","23/03/2000"},
            new List<string> { "29","Rhino","Mammal", "Aurora","Female","11/10/1999","16/10/1999"},
            new List<string> { "30","Wolf","Mammal", "Farly","Male","14/11/2001","28/11/2001"},
            new List<string> { "31","Wolf","Mammal", "Chico","Male","14/07/2002","28/07/2002"},
            new List<string> { "32","Squirrel Monkey","Mammal", "Julianna","Female","06/07/2003","07/07/2003"},
            new List<string> { "33","Great White Shark","Fish", "Bev","Female","18/12/2002","04/01/2003"},
            new List<string> { "34","Honey Badger","Mammal", "Shara","Male","26/04/1999","12/05/1999"},
            new List<string> { "35","Grizzly Bear","Mammal", "Legra","Female","14/08/2001","29/08/2001"},
            new List<string> { "36","Honey Badger","Mammal", "Katey","Male","19/12/2003","04/01/2004"},
            new List<string> { "37","Grizzly Bear","Mammal", "Val","Female","21/08/2001","05/09/2001"},
            new List<string> { "38","Gorilla","Mammal", "Shannan","Female","06/02/2002","19/02/2002"},
            new List<string> { "39","Zebra","Mammal", "Sterling","Female","18/08/2001","29/08/2001"},
            new List<string> { "40","Vulture","Bird", "Brina","Male","05/11/2000","15/11/2000"},
            new List<string> { "41","Great White Shark","Fish", "Boniface","Female","16/04/2002","03/05/2002"},
            new List<string> { "42","Eagle","Bird", "Vincenty","Female","09/04/2001","18/04/2001"},
            new List<string> { "43","Polar Bear","Mammal", "Kathye","Female","27/09/2003","04/10/2003"},
            new List<string> { "44","Squirrel Monkey","Mammal", "Chico","Female","02/07/2001","03/07/2001"},
            new List<string> { "45","Tiger","Mammal", "Enoch","Male","05/12/2001","07/12/2001"},
            new List<string> { "46","Polar Bear","Mammal", "Brandie","Female","27/05/2002","03/06/2002"},
            new List<string> { "47","Grizzly Bear","Mammal", "Bethanne","Female","22/12/1999","06/01/2000"},
            new List<string> { "48","Honey Badger","Mammal", "Margo","Male","26/03/1999","11/04/1999"},
            new List<string> { "49","Rhino","Mammal", "Allie","Female","11/05/2001","16/05/2001"},
            new List<string> { "50","Grizzly Bear","Mammal", "North","Female","31/01/2000","15/02/2000"},
            new List<string> { "51","Grizzly Bear","Mammal", "Ted","Female","06/09/1999","21/09/1999"},
            new List<string> { "52","Great White Shark","Fish", "Leone","Female","04/03/1999","21/03/1999"},
            new List<string> { "53","Zebra","Mammal", "Abbie","Female","23/10/2003","03/11/2003"},
            new List<string> { "54","Polar Bear","Mammal", "Marika","Female","01/01/2004","08/01/2004"},
            new List<string> { "55","Cobra","Invertibrate", "Edith","Male","28/08/1999","05/09/1999"},
            new List<string> { "56","Praying Mantis","Insect", "Ernest","Male","23/10/2000","10/11/2000"},
            new List<string> { "57","Eagle","Bird", "Rowen","Female","27/01/2001","05/02/2001"},
            new List<string> { "58","Vulture","Bird", "Pasquale","Male","24/01/2002","03/02/2002"},
            new List<string> { "59","Grizzly Bear","Mammal", "Tim","Female","18/10/2001","02/11/2001"},
            new List<string> { "60","Wolf","Mammal", "Tedd","Male","12/04/2000","26/04/2000"},
            new List<string> { "61","Tiger","Mammal", "Jacquetta","Male","29/08/2000","31/08/2000"},
            new List<string> { "62","Praying Mantis","Insect", "Nelli","Male","05/11/2002","23/11/2002"},
            new List<string> { "63","Giraffe","Mammal", "Morie","Male","01/01/2001","07/01/2001"},
            new List<string> { "64","Lion","Mammal", "Gabie","Female","12/08/1999","15/08/1999"},
            new List<string> { "65","Tiger","Mammal", "Menard","Male","03/08/2002","05/08/2002"},
            new List<string> { "66","Zebra","Mammal", "Mike","Female","04/07/2001","15/07/2001"},
            new List<string> { "67","Honey Badger","Mammal", "Eldin","Male","26/10/1998","11/11/1998"},
            new List<string> { "68","Praying Mantis","Insect", "Pris","Male","01/09/1998","19/09/1998"},
            new List<string> { "69","Zebra","Mammal", "Joey","Female","23/09/2000","04/10/2000"},
            new List<string> { "70","Wolf","Mammal", "Daisey","Male","24/08/2000","07/09/2000"},
            new List<string> { "71","Tiger","Mammal", "Melanie","Male","17/06/1999","19/06/1999"},
            new List<string> { "72","Wolf","Mammal", "Beatrix","Male","06/07/2003","20/07/2003"},
            new List<string> { "73","Polar Bear","Mammal", "Missy","Female","17/02/1999","24/02/1999"},
            new List<string> { "74","Tiger","Mammal", "Belinda","Male","01/10/1998","03/10/1998"},
            new List<string> { "75","Honey Badger","Mammal", "Raynor","Male","11/07/2001","27/07/2001"},
            new List<string> { "76","Polar Bear","Mammal", "Inigo","Female","26/02/2000","04/03/2000"},
            new List<string> { "77","Honey Badger","Mammal", "Ilaire","Male","16/11/2003","02/12/2003"},
            new List<string> { "78","Great White Shark","Fish", "Estel","Female","14/12/2001","31/12/2001"},
            new List<string> { "79","Squirrel Monkey","Mammal", "Lyell","Female","24/10/2003","25/10/2003"},
            new List<string> { "80","Zebra","Mammal", "Darren","Female","14/12/2001","25/12/2001"},
            new List<string> { "81","Rhino","Mammal", "Warden","Female","06/05/2003","11/05/2003"},
            new List<string> { "82","Komodo Dragon","Reptile", "Iris","Male","04/12/2002","16/12/2002"},
            new List<string> { "83","Elephant","Mammal", "Marten","Male","23/06/2002","27/06/2002"},
            new List<string> { "84","Rhino","Mammal", "Kerry","Female","08/10/2000","13/10/2000"},
            new List<string> { "85","Vulture","Bird", "Olivette","Male","01/02/2002","11/02/2002"},
            new List<string> { "86","Grizzly Bear","Mammal", "Rosalinde","Female","28/03/2000","12/04/2000"},
            new List<string> { "87","Zebra","Mammal", "Gaultiero","Female","09/07/2000","20/07/2000"},
            new List<string> { "88","Elephant","Mammal", "Zonnya","Male","16/12/1999","20/12/1999"},
            new List<string> { "89","Honey Badger","Mammal", "Ingelbert","Male","19/05/2002","04/06/2002"},
            new List<string> { "90","Lion","Mammal", "Nicol","Female","29/01/2001","01/02/2001"},
            new List<string> { "91","Great White Shark","Fish", "Jasun","Female","10/09/1998","27/09/1998"},
            new List<string> { "92","Cobra","Invertibrate", "Alison","Male","15/04/1999","23/04/1999"},
            new List<string> { "93","Polar Bear","Mammal", "Claudius","Female","05/05/2000","12/05/2000"},
            new List<string> { "94","Wolf","Mammal", "Jakie","Male","14/11/2000","28/11/2000"},
            new List<string> { "95","Polar Bear","Mammal", "Gilbertine","Female","08/11/2002","15/11/2002"},
            new List<string> { "96","Rhino","Mammal", "Syd","Female","24/04/2000","29/04/2000"},
            new List<string> { "97","Cobra","Invertibrate", "Stafford","Male","30/09/2001","08/10/2001"},
            new List<string> { "98","Vulture","Bird", "Zacharie","Male","29/04/2002","09/05/2002"},
            new List<string> { "99","Great White Shark","Fish", "Jane","Female","25/08/1998","11/09/1998"},
            new List<string> { "100","Gorilla","Mammal", "Marjy","Female","22/01/2003","04/02/2003"},
        };

        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }

        private static Animal CreateRandomAnimal(int index)
        {
            return new Animal
            {
                Id = int.Parse(Data[index][0]),
                Species = Data[index][1],
                Classification = Data[index][2],
                Name = Data[index][3],
                Sex = Data[index][4],
                DOB = DateTime.Parse((Data[index][5])),
                AcquisitionDate = DateTime.Parse((Data[index][6])),

            };
        }
    }
}

