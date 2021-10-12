using System;
using System.Linq;

namespace MinecraftMappings.Internal
{
    public class GameVersion
    {
        public int Major {get; set;}
        public int Minor {get; set;}
        public int Revision {get; set;}


        public GameVersion() {}

        public GameVersion(int major, int minor, int revision = 0)
        {
            Major = major;
            Minor = minor;
            Revision = revision;
        }


        public static GameVersion Parse(string version)
        {
            if (version == null) throw new ArgumentNullException(nameof(version));

            var numberParts = version.Split('.')
                .Select(int.Parse).ToArray();

            switch (numberParts.Length) {
                case 1:
                    return new GameVersion(numberParts[0], 0);
                case 2:
                    return new GameVersion(numberParts[0], numberParts[1]);
                case 3:
                    return new GameVersion(numberParts[0], numberParts[1], numberParts[2]);
                default:
                    throw new ApplicationException($"Unable to parse version '{version}'!");
            }
        }
    }
}
