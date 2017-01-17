using Gx.Common;
using Gx.Links;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Gx.Conclusion
{
    public class FamilyView : HypermediaEnabledData
    {
        private ResourceReference _parent1;

        [JsonProperty("parent1")]
        public ResourceReference Parent1
        {
            get { return _parent1; }
            set { _parent1 = value; }
        }

        private ResourceReference _parent2;

        [JsonProperty("parent2")]
        public ResourceReference Parent2
        {
            get { return _parent2; }
            set { _parent2 = value; }
        }

        private List<ResourceReference> _children;

        [JsonProperty("children")]
        public List<ResourceReference> Children
        {
            get { return _children; }
            set { _children = value; }
        }


    }
}