using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TelephoneInterface;
namespace TelephoneDll_SQL
{
    public class TelephoneContext : DbContext, IPhoneDictionary
    {
        public DbSet<Telephone> Telephones { get; set; }
        public TelephoneContext() : base("TelephoneContext") { }
        public List<Telephone> Select()
        {
            var telephones = this.Telephones;
            return telephones.OrderBy(t => t.Surname).ToList();
        }

        public void Insert(string surname, int number)
        {
            var telephones = this.Telephones;
            int id = 0;
            foreach (Telephone telephone in telephones)
            {
                if (telephone.Id > id)
                {
                    id = telephone.Id;
                }
            }
            this.Telephones.Add(new Telephone { Id = id + 1, Surname = surname, Number = number });
            this.SaveChanges();
        }

        public void Update(int id, string surname, int number)
        {
            var telephones = this.Telephones.ToList();
            int index = telephones.IndexOf(telephones.Find(x => x.Id == id));
            if (index != -1)
            {
                telephones[index].Surname = surname;
                telephones[index].Number = number;
                this.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var telephones = this.Telephones.ToList();
            Telephone removed = telephones.Find(x => x.Id == id);
            if (removed != null)
            {
                this.Telephones.Remove(removed);
                this.SaveChanges();
            }
        }
    }
}
