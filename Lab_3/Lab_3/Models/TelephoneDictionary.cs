using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab_3.Models
{
    public class TelephoneDictionary
    {
        private List<Telephone> telephones = new List<Telephone>();

        private List<Telephone> Telephones { get => telephones; set => telephones = value; }

        public TelephoneDictionary()
        {
            
        }
        public string path = "D:\\studing_6sem\\6 sem\\ASP\\Labs_All\\lab_3_1\\test.json";
        public List<Telephone> getAll()
        {
            string jsonString = File.ReadAllText(path);
            this.telephones = JsonConvert.DeserializeObject<List<Telephone>>(jsonString).ToList();
            return telephones.OrderBy(u => u.surname).ToList();
        }

        public void insert(string surname, int number)
        {
            this.telephones = getAll();
            int id = 0;
            foreach (Telephone telephone in telephones)
            {
                if (telephone.id > id)
                {
                    id = telephone.id;
                }
            }
            this.telephones.Add(new Telephone { id = id + 1, surname = surname, number = number });
            string jsonString = JsonConvert.SerializeObject(telephones);
            File.WriteAllText(path, jsonString);
        }

        public void update(int id, string surname, int number)
        {
            this.telephones = getAll();
            int index = this.telephones.IndexOf(this.telephones.Find(x => x.id == id));
            telephones[index].surname = surname;
            telephones[index].number = number;
            string jsonString = JsonConvert.SerializeObject(telephones);
            File.WriteAllText(path, jsonString);
        }

        public void delete(int id)
        {
            this.telephones = getAll();
            Telephone removed = this.telephones.Find(x => x.id == id);
            this.telephones.Remove(removed);
            string jsonString = JsonConvert.SerializeObject(telephones);
            File.WriteAllText(path, jsonString);
        }
    }
}