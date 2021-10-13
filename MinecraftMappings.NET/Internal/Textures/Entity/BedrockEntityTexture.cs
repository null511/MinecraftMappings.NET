namespace MinecraftMappings.Internal.Textures.Entity
{
    public abstract class BedrockEntityTexture : EntityTexture<BedrockEntityTextureVersion>
    {
        protected BedrockEntityTexture(string name) : base(name) {}

        protected BedrockEntityVersionBuilder<BedrockEntityTextureVersion> AddVersion(string id)
        {
            var version = new BedrockEntityTextureVersion {
                Id = id,
            };

            Versions.Add(version);
            return new BedrockEntityVersionBuilder<BedrockEntityTextureVersion>(version);
        }
    }
}
