namespace MinecraftMappings.Internal.Textures.Block
{
    public abstract class JavaBlockTexture : BlockTexture<JavaBlockTextureVersion>
    {
        protected JavaBlockTexture(string name) : base(name) {}

        protected JavaBlockTextureVersionBuilder<JavaBlockTextureVersion> AddVersion(string id)
        {
            var version = new JavaBlockTextureVersion {
                Id = id,
            };

            Versions.Add(version);
            return new JavaBlockTextureVersionBuilder<JavaBlockTextureVersion>(version);
        }
    }
}
