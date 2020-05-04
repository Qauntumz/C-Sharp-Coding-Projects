using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    public class Favorite
    {
        [Key]
        public int FavID { get; set; }

        public int FavNum { get; set; }

        public string FavWord { get; set; }

        public ICollection<User> Users { get; set; }

    }
}
