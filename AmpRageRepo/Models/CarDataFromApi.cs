﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmpRageRepo.Models
{
    public class Attributes
    {
        public string regno { get; set; }
        public string vin { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string uri { get; set; }
    }

    public class Data2
    {
        public string make { get; set; }
        public string model { get; set; }
        public object status { get; set; }
        public string color { get; set; }
        public string type { get; set; }
        public string type_class { get; set; }
        public object vehicle_year { get; set; }
        public object model_year { get; set; }
        public bool reused_regno { get; set; }
    }

    public class Basic
    {
        public Data2 data { get; set; }
    }

    public class Data3
    {
        public object power_hp_1 { get; set; }
        public object power_hp_2 { get; set; }
        public object power_hp_3 { get; set; }
        public object power_kw_1 { get; set; }
        public object power_kw_2 { get; set; }
        public object power_kw_3 { get; set; }
        public object cylinder_volume { get; set; }
        public object top_speed { get; set; }
        public object fuel_1 { get; set; }
        public object fuel_2 { get; set; }
        public object fuel_3 { get; set; }
        public object fuel_combination { get; set; }
        public object consumption_1 { get; set; }
        public object consumption_2 { get; set; }
        public object consumption_3 { get; set; }
        public object co2_1 { get; set; }
        public object co2_2 { get; set; }
        public object co2_3 { get; set; }
        public object transmission { get; set; }
        public bool four_wheel_drive { get; set; }
        public object sound_level_1 { get; set; }
        public object sound_level_2 { get; set; }
        public object sound_level_3 { get; set; }
        public object number_of_passengers { get; set; }
        public bool passenger_airbag { get; set; }
        public object hitch { get; set; }
        public object hitch_2 { get; set; }
        public object chassi_code_1 { get; set; }
        public object chassi_code_2 { get; set; }
        public string chassi { get; set; }
        public string color { get; set; }
        public object length { get; set; }
        public object width { get; set; }
        public object height { get; set; }
        public object kerb_weight { get; set; }
        public object total_weight { get; set; }
        public object load_weight { get; set; }
        public object trailer_weight { get; set; }
        public object unbraked_trailer_weight { get; set; }
        public object trailer_weight_b { get; set; }
        public object trailer_weight_be { get; set; }
        public object carriage_weight { get; set; }
        public string tire_front { get; set; }
        public string tire_back { get; set; }
        public string rim_front { get; set; }
        public string rim_back { get; set; }
        public object axel_width { get; set; }
        public string category { get; set; }
        public string eeg { get; set; }
        public object nox_1 { get; set; }
        public object nox_2 { get; set; }
        public object nox_3 { get; set; }
        public object thc_nox_1 { get; set; }
        public object thc_nox_2 { get; set; }
        public object thc_nox_3 { get; set; }
        public object eco_class { get; set; }
        public object emission_class { get; set; }
        public object euro_ncap { get; set; }
    }

    public class Technical
    {
        public Data3 data { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public Attributes attributes { get; set; }
        public List<Link> links { get; set; }
        public Basic basic { get; set; }
        public Technical technical { get; set; }
    }

    public class RootObject
    {
        public Data data { get; set; }
    }
}
