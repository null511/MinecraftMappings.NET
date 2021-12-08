namespace MinecraftMappings.Internal.Textures.Block
{
    public abstract class JavaBlockTexture : BlockTexture<JavaBlockTextureVersion>
    {
        protected JavaBlockTexture(string name) : base(name) {}

        protected JavaBlockTextureVersionBuilder<JavaBlockTextureVersion> AddVersion(int? packVersion, string id)
        {
            var version = new JavaBlockTextureVersion {
                Id = id,
                PackVersion = packVersion,
            };

            Versions.Add(version);
            return new JavaBlockTextureVersionBuilder<JavaBlockTextureVersion>(version);
        }

        protected JavaBlockTextureVersionBuilder<JavaBlockTextureVersion> AddVersion(string id) => AddVersion(null, id);
    }
}
