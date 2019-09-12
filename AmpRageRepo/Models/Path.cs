﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmpRageRepo.Models
{
    public class Path
    {
        public Path()
        {
            WayPoints = new List<string>();
            step = new Step();
        }

        [Required(ErrorMessage = "Orgin is required.")]
        public string Origin { get; set; }
        [Required(ErrorMessage = "Destination is required.")]
        public string Destination { get; set; }
        [Display(Name = "License Plate")]
        [Required(ErrorMessage = "License Plate is required.")]
        [StringLength(6, ErrorMessage = "License Plate must be 6 chars")]
        public string LicensePlate { get; set; }
        public int Range { get; set; } //km
        public double EffectiveRange { get; set; } //km -> m -> x0.8
        public int LegCount { get; set; }
        public double totalDist;
        public Step step;

        public double MinRange { get; set; }
        public double MaxRange { get; set; }

        public List<string> WayPoints { get; set; }

        public void ChangeRange(int aRange)
        {
            this.Range = aRange;
        }
    }
}
