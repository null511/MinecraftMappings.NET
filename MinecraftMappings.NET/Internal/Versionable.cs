using System;

namespace MinecraftMappings.Internal
{
    public abstract class Versionable
    {
        private readonly Lazy<Version> _parsedMinVersion;
        private readonly Lazy<Version> _parsedMaxVersion;

        public string MinVersion {get; set;}
        public string MaxVersion {get; set;}

        public Version ParsedMinVersion => _parsedMinVersion.Value;
        public Version ParsedMaxVersion => _parsedMaxVersion.Value;


        protected Versionable()
        {
            _parsedMinVersion = new Lazy<Version>(() => {
                if (MinVersion == null) return null;
                return Version.Parse(MinVersion);
            });

            _parsedMaxVersion = new Lazy<Version>(() => {
                if (MaxVersion == null) return null;
                return Version.Parse(MaxVersion);
            });
        }
    }
}
