using System;

namespace Groups.Model
{
    public class MusicGroup
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class BandMember
    {
        public string Name { get; set; }

        public BandMember(string name)
        {
            this.Name = name;
        }
    }
}
