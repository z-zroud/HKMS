using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKMS.DBModels
{
    public class Epoch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EpochNum { get;set; }

        public int WinNum { get; set; }

        public bool IsLatest { get; set; }
    }
}
