using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Antroji_programavimo_praktika
{
    public class Vidurkis 
    {
        public string findSum(String str)
        {
            int atsakymas = Regex.Matches(str, @"\d+").Cast<Match>().Select(x => int.Parse(x.Value)).Sum();
            int atsakymass = Regex.Matches(str, @"\d+").Count;
            atsakymas = atsakymas / atsakymass;
            string ats = atsakymas.ToString();
            return ats;
        }
    }
}
