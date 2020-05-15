using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pahamdiri
{
    class HistoriResult
    {
        private string[] _saran = new string[] {
            "Anda dalam keadaan yang cukup baik. Pertahankan ini!",
            "Dalam keadaan ini, anda tidak merasa terlalu baik maupun terlalu buruk. Tidak apa apa, ini tidak buruk. Cobalah cari hiburan sesekali sebagai pencair suasana.",
            "Anda sepertinya mulai lelah. Sebaiknya carilah pengalih suasana dan rehat untuk beberapa waktu. Lakukanlah hal yang dapat membuat anda melupakan lelah itu sebentar, misalnya menghirup udara segar atau mengobrol ringan.",
            "Istirahatlah. Pinggirkanlah diri anda dari hal yang membuat anda lelah ini. Jika masih belum bisa, carilah pengalih suasana untuk mengurangi lelah ini. Yang pasti, rehatlah. Pelan pelan saja." };
        private string[] _diagnosa = new string[] { "Baik", "Biasa saja", "Sedikit Lelah", "Lelah" };

        public string[] Saran
        {
            get { return _saran; }
            set { _saran = value;  }
        }
        
        public string[] Diagnosa
        {
            get { return _diagnosa; }
            set { _diagnosa = value; }
        }
    }
}
