using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public class Isciler
    {
      static  int id = 1;
        public Isciler(string name, string surname, string email, int gelmeVaxti, int getmeVaxti )
        {
            Name = name;
            Surname = surname;
            time = DateTime.Now;
            Email = email;
            GelmeVaxti = gelmeVaxti;
            GetmeVaxti = getmeVaxti;
            Maaw =(GetmeVaxti-gelmeVaxti)*100;
            Id = id;
            id++;
           
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int GelmeVaxti { get; set; }
        public int GetmeVaxti { get; set; }
        public int Maaw { get; set; }
        public DateTime time { get; set; }


    }
}
