using System;
using System.Collections.Generic;
using System.Linq;
using Katas.Models;

namespace KatasProject
{
    public class TDDBase
    {
        public bool CheckHeight(Person person)
        {
            return person != null && person.HeightCM > 155;
        }

        public string ConvertToSassCase(string input)
        {
            var sassStringArr = new List<string>();

            for (var i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sassStringArr.Add(input[i].ToString().ToUpper());
                }
                else
                {
                    sassStringArr.Add(input[i].ToString().ToLower());
                }
            }

            return string.Join("", sassStringArr);
        }

        public List<Artwork> TriageArtworks(IEnumerable<Artwork> artworks, DateTime cutOffDate)
        {
            var beforeCutOff = artworks.Where(x => x.submissionTimestamp < cutOffDate);

            return beforeCutOff.OrderBy(x => x.submissionTimestamp).Take(3).ToList();
        }
    }
}
