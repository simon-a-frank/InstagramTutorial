using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InstagramTutorial
{
    [DataContract]
    class InstagramProfile
    {
        [DataMember(Name ="data")]
        public InstagramProfileData data { get; set; }
    }
}
