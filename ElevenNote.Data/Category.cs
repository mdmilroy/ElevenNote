using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid OwnerId { get; set; }
    }
}

// Bearer j7BUhmciO0Jd0ywCVtx5_sbUX17h91hsEIVayzB57NU5ToZAKVII1Abv5r_yo5Ig195LnDqv67z3Z8hMfVWOHUQOASx_8FYimZJjtXCUHmRSWDN6uY79fVBUt7z-335zoiBVQHk3Ktq8S8sgSNFlrafNWJNAvCKsfSB9eq7KNl3mwIuWh0ooPHvg9uNjZd49FDIWApK13ptfAhxrgyQH-Wi-TGsSXBbRALIRERWSNEwigpOs_9ZPAG0dtISYgIiaLPSZK6TzhCcBqdRNR1CWR8cNymjn_oTSYYuOyneV1At72bru9Cnh12fkpmF2jJ10xiMP7my5r8beK5n5lfudZST7ZZE4S7tETPN0mrXJfSp-I5gWvkX4JDPHec_1a0XEidGkDiis5YgzOMPybWBDmwvb-0FI1p_dFMTIXfsAmvRmXf3j5mM5m1s5yOHANV_tnzgw9dj28Tm4P1k1DHsqehEhpQyhfnE5hgwfWeSBTRZ35NgnuohoxXc_GdTxjt4S