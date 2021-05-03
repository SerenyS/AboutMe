using System;
using System.Collections.Generic;
using System.Text;

namespace AboutMe
{
    class FactsAboutMe
    {
        public FactsAboutMe() { }

        public static IEnumerable<FactsAboutMe> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }

        static FactsAboutMe()
        {
            List<FactsAboutMe> all = new List<FactsAboutMe>();
            all.Add(new FactsAboutMe() { TheFact = "I grew up in a small town in Jalisco Mexico", ShortFact = "Where I grew up" });
            all.Add(new FactsAboutMe() { TheFact = "Olive green!", ShortFact = "My favorite color" });
            all.Add(new FactsAboutMe() { TheFact = "23 years young", ShortFact = "My age" });
            all.Add(new FactsAboutMe() { TheFact = "Photography and digital art", ShortFact = "My hobbies" });
            all.Add(new FactsAboutMe() { TheFact = "Thai food and cheesecake", ShortFact = "My favorite food" });
            All = all;
        }
    }
}
