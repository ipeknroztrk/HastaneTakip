using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class sqlBaglantisi

    {
        public SqlConnection baglanti()
        {
            var baglan = new SqlConnection("Data Source=DESKTOP-P6KNO1I;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
