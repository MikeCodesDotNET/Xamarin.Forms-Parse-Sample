using System;
using Parse;

namespace ParseSample.Models
{
    [ParseClassName("Planet")]
    public class Planet : ParseObject
    {
        [ParseFieldName("name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }
        [ParseFieldName("distanceFromSun")]
        public int DistanceFromSun
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }
    }
}

