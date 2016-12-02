using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InstagramTutorial
{
    [DataContract]
    class InstagramProfileData
    {
        [DataMember]
        public string username;

        [DataMember]
        public string bio;

        [DataMember]
        public string website;

        [DataMember]
        public string profile_picture;

        [DataMember]
        public string full_name;

        [DataMember]
        public string id;

        [DataMember(Name = "counts")]
        public InstagramProfileCounts counts { get; set; }

    }
}
