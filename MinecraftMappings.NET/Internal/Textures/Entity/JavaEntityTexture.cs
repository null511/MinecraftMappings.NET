namespace MinecraftMappings.Internal.Textures.Entity
{
    public abstract class JavaEntityTexture : EntityTexture<JavaEntityTextureVersion>
    {
        protected JavaEntityTexture(string name) : base(name) {}

        protected JavaEntityTextureVersionBuilder<JavaEntityTextureVersion> AddVersion(string id)
        {
            var version = new JavaEntityTextureVersion {
                Id = id,
            };

            Versions.Add(version);
            return new JavaEntityTextureVersionBuilder<JavaEntityTextureVersion>(version);
        }
    }
}
