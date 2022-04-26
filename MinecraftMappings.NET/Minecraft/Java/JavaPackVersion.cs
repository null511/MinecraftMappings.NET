using MinecraftMappings.Internal;

namespace MinecraftMappings.Minecraft.Java
{
    public class JavaPackVersion
    {
        public int Index {get;}
        public GameVersion MinGameVersion {get; set;}
        public GameVersion MaxGameVersion {get; set;}


        public JavaPackVersion(int index, GameVersion minVersion = null, GameVersion maxVersion = null)
        {
            Index = index;
            MinGameVersion = minVersion;
            MaxGameVersion = maxVersion;
        }


        public static readonly JavaPackVersion Version1 = new JavaPackVersion(1, "1.6.1", "1.8.9");
        public static readonly JavaPackVersion Version2 = new JavaPackVersion(2, "1.9", "1.10.2");
        public static readonly JavaPackVersion Version3 = new JavaPackVersion(3, "1.11", "1.12.2");
        public static readonly JavaPackVersion Version4 = new JavaPackVersion(4, "1.13", "1.14.4");
        public static readonly JavaPackVersion Version5 = new JavaPackVersion(5, "1.15", "1.16.1");
        public static readonly JavaPackVersion Version6 = new JavaPackVersion(6, "1.16.2", "1.16.5");
        public static readonly JavaPackVersion Version7 = new JavaPackVersion(7, "1.17", "1.17.1");
        public static readonly JavaPackVersion Version8 = new JavaPackVersion(8, "1.18", "1.18.2");
        public static readonly JavaPackVersion Version9 = new JavaPackVersion(9, "1.19");
        public static readonly JavaPackVersion Latest = Version9;
    }
}
