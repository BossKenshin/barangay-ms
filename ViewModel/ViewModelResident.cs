using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plths.ViewModel
{
    class ViewModelResident
    {
        public int resid { get; set; }
        public string fn { get; set; }
        public string mn { get; set; }
        public string ln { get; set; }
        public string fullname { get; set; }

        public byte[] picture { get; set; }
        public DateTime bod { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string cstat { get; set; }
        public string lstat { get; set; }
        public string address { get; set; }
        public int prkid { get; set; }
        public string purokname { get; set; }
        public string citizenship { get; set; }
        public string religion { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string voterid { get; set; }
        public string precinct { get; set; }
        public string education { get; set; }
        public string profession { get; set; }
        public string dialect { get; set; }
       
    }
}
