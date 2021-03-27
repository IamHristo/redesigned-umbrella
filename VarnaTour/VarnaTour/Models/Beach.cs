using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VarnaTour.Enums;

namespace VarnaTour.Models
{
    public class Beach
    {

        public int ID { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string MiniContent { get; set; }

        public string Content { get; set; }

        public bool HasRestourant { get; set; }
        public bool HasLifeguard { get; set; }
        public bool HasMedicalStaff { get; set; }
        public bool IsSuitableForChildren { get; set; }
        public bool HasDressingRoom { get; set; }
        public bool HasShower { get; set; }
        public bool HasParking { get; set; }
        public bool HasCarAccess { get; set; }
        public bool HasUmbrellaAndSunbed { get; set; }
        public bool IsDisabilitiesFriendly { get; set; }

        [EnumDataType(typeof(BeachType))]
        public BeachType BeachType { get; set; }

    }
}
