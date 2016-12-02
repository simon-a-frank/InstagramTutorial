using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InstagramTutorial
{
    [DataContract]
    class InstagramProfileCounts
    {
        [DataMember]
        public int media;

        [DataMember]
        public int followed_by;

        [DataMember]
        public int follows;
    }
}
