using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Animals_vet
{
    public interface animalsI
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Breed { get; set; }

        public double Weight { get; set; }

        public string MedicalHistory { get; set; }

        public string Color { get; set; }

        public string Image { get; set; }

        public Status Status { get; set; }
    }    
}
