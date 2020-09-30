using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneInterface;
namespace TelephoneDll_Json
{
        public class TelephoneContext : IPhoneDictionary
        {
            private List<Telephone> telephones = new List<Telephone>();

            private List<Telephone> Telephones { get => telephones; set => telephones = value; }

            public TelephoneContext()
            {

            }

            public List<Telephone> Select()
            {
                string jsonString = File.ReadAllText("D:\\studing_6sem\\6 sem\\ASP\\Labs\\labs\\Lab_6 JSON\\Lab_3\\test.json");
                this.telephones = JsonConvert.DeserializeObject<List<Telephone>>(jsonString).ToList();
                return telephones.OrderBy(u => u.Surname).ToList();
            }

            public void Insert(string surname, int number)
            {
                this.telephones = Select();
                int id = 0;
                foreach (Telephone telephone in telephones)
                {
                    if (telephone.Id > id)
                    {
                        id = telephone.Id;
                    }
                }
                this.telephones.Add(new Telephone { Id = id + 1, Surname = surname, Number = number });
                saveChange(telephones);
            }

            public void Update(int id, string surname, int number)
            {
                this.telephones = Select();
                int index = this.telephones.IndexOf(this.telephones.Find(x => x.Id == id));
                if (index != -1)
                {
                    telephones[index].Surname = surname;
                    telephones[index].Number = number;
                    saveChange(telephones);
                }
            }

            public void Delete(int id)
            {
                this.telephones = Select();
                Telephone removed = this.telephones.Find(x => x.Id == id);
                if (removed != null)
                {
                    this.telephones.Remove(removed);
                    saveChange(telephones);
                }
            }

            public void saveChange(List<Telephone> telephones)
            {
                string jsonString = JsonConvert.SerializeObject(telephones);
                File.WriteAllText("D:\\studing_6sem\\6 sem\\ASP\\Labs\\labs\\Lab_6 JSON\\Lab_3\\test.json", jsonString);
            }
        }
}
