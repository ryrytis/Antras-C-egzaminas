using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Egzas1117
{
    public class OrderInfo
    {
        public List<Staliukai> StaliukaiList { get; set; } = new List<Staliukai>();
        public List<Food> Foods { get; set; } = new List<Food>();
        public List<Drinks>DrinksChosen { get; set; } = new List<Drinks>(); 
    }


 
    //message.Subject = "Kvitas";



}
