using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureSubtitle { get; set; }
        public string FeatureImageUrl { get; set; }
        public string  FeatureVideoUrl { get; set; }

    }
}