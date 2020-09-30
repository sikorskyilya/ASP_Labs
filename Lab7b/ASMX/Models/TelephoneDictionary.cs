﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ASMX.Models
{
    public class TelephoneDictionary
    {
        private List<Telephone> telephones = new List<Telephone>();

        private List<Telephone> Telephones { get => telephones; set => telephones = value; }

        public TelephoneDictionary()
        {

        }

        public string getAll()
        {
            string jsonString = File.ReadAllText("D:\\studing_6sem\\6 sem\\ASP\\ASP_Labs\\Lab7b\\ASMX\\App_Data\\numbers.json");
            return jsonString;
        }

        public List<Telephone> selectAll()
        {
            string jsonString = File.ReadAllText("D:\\studing_6sem\\6 sem\\ASP\\ASP_Labs\\Lab7b\\ASMX\\App_Data\\numbers.json");
            this.telephones = JsonConvert.DeserializeObject<List<Telephone>>(jsonString).ToList();
            return telephones.OrderBy(u => u.surname).ToList();
        }

        public void insert(string surname, int number)
        {
            this.telephones = selectAll();
            int id = 0;
            foreach (Telephone telephone in telephones)
            {
                if (telephone.id > id)
                {
                    id = telephone.id;
                }
            }
            this.telephones.Add(new Telephone { id = id + 1, surname = surname, number = number });
            saveChange(telephones);
        }

        public void update(int id, string surname, int number)
        {
            this.telephones = selectAll();
            int index = this.telephones.IndexOf(this.telephones.Find(x => x.id == id));
            if (index != -1)
            {
                telephones[index].surname = surname;
                telephones[index].number = number;
                saveChange(telephones);
            }
        }

        public void delete(int id)
        {
            this.telephones = selectAll();
            Telephone removed = this.telephones.Find(x => x.id == id);
            if (removed != null)
            {
                this.telephones.Remove(removed);
                saveChange(telephones);
            }
        }

        public void saveChange(List<Telephone> telephones)
        {
            string jsonString = JsonConvert.SerializeObject(telephones);
            File.WriteAllText("D:\\studing_6sem\\6 sem\\ASP\\ASP_Labs\\Lab7b\\ASMX\\App_Data\\numbers.json", jsonString);
        }
    }
}