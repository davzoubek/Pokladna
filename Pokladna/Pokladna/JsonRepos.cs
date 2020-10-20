﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pokladna
{
    public class JsonRepos : IRepos
    {
        private string datovysoubor;

        public JsonRepos(string soubor)
        {
            datovysoubor = soubor;
        }
        public void VytvorTestData()
        {
            List<PokladniZaznam> data = new List<PokladniZaznam>();
            data.Add(new PokladniZaznam(1, 1, new DateTime(2020, 1, 3), "Příjem z banky", 20000, 20000, ""));
            data.Add(new PokladniZaznam(2, 2, new DateTime(2020, 1, 4), "Tenisové míče", -2356, data.Last().Zustatek-2356, "Dotace - MŠMT"));
            data.Add(new PokladniZaznam(3, 3, new DateTime(2020, 1, 8), "Občerstvení", -538, data.Last().Zustatek-538, ""));
            data.Add(new PokladniZaznam(4, 4, new DateTime(2020, 1, 12), "Pronájem kurtu", 350, data.Last().Zustatek + 350, ""));
            data.Add(new PokladniZaznam(5, 5, new DateTime(2020, 1, 13), "Registrace soutěží", 2500, data.Last().Zustatek - 2500, ""));
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(datovysoubor, json);
        }
        public List<PokladniZaznam> NactiVse()
        {
            List<PokladniZaznam> data;
            data = JsonConvert.DeserializeObject<List<PokladniZaznam>>(File.ReadAllText(datovysoubor));
            return data;
        }

        public PokladniZaznam NactiZaznam(int idPokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public List<PokladniZaznam> NactiMesic(int rok, int mesic)
        {
            List<PokladniZaznam> data = NactiVse();
            return data.FindAll(prvek => prvek.Datum.Year == rok && prvek.Datum.Month == mesic);

        }
    }
}
