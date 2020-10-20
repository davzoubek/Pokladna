using System;
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
            List<PokladniZaznam> data = NactiVse();
            if(data.Find(doklad => doklad.Datum > pokladniZaznam.Datum) == null)
            {
                data.Sort((a, b) => a.IdPokladniZaznam.CompareTo(b.IdPokladniZaznam));
                pokladniZaznam.IdPokladniZaznam = data.Last().IdPokladniZaznam + 1;
                data.Sort((a, b) => a.Datum.CompareTo(b.Datum));
                if (data.Last().Datum.Month == pokladniZaznam.Datum.Month)
                {
                    pokladniZaznam.Cislo = data.Last().Cislo + 1;
                }
                else
                {
                    pokladniZaznam.Cislo = 1;
                }
                pokladniZaznam.Zustatek = data.Last().Zustatek + pokladniZaznam.Castka;
                
            }

            else
            {
                data.Sort((a, b) => a.IdPokladniZaznam.CompareTo(b.IdPokladniZaznam));
                pokladniZaznam.IdPokladniZaznam = data.Last().IdPokladniZaznam + 1;
                List<PokladniZaznam> dataMesice = data.FindAll(doklad => doklad.Datum.Year == pokladniZaznam.Datum.Year && doklad.Datum.Month == pokladniZaznam.Datum.Month);
                dataMesice.Sort((a, b) => a.Cislo.CompareTo(b.Cislo));
                if(dataMesice.Count > 0)
                {
                    if(dataMesice.Find(doklad => doklad.Datum > pokladniZaznam.Datum) == null)
                    {
                        pokladniZaznam.Cislo = dataMesice.Last().Cislo + 1;
                    }
                    else
                    {
                        int index = dataMesice.FindIndex(doklad => doklad.Datum > pokladniZaznam.Datum);
                        pokladniZaznam.Cislo = dataMesice[index].Cislo;
                        for(int i = index; i < dataMesice.Count; i++)
                        {
                            dataMesice[i].Cislo += 1;
                        }
                    }
                }
                else
                {
                    pokladniZaznam.Cislo = 1;
                }
            }
            data.Add(pokladniZaznam);
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(datovysoubor, json);
            return pokladniZaznam;

        }

        public List<PokladniZaznam> NactiMesic(int rok, int mesic)
        {
            List<PokladniZaznam> data = NactiVse();
            data = NactiVse().FindAll(prvek => prvek.Datum.Year == rok && prvek.Datum.Month == mesic);
            data.Sort((a, b) => a.Datum.CompareTo(b.Datum));
            return data;

        }
    }
}
