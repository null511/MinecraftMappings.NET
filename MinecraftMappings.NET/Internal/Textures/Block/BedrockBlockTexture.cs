namespace MinecraftMappings.Internal.Textures.Block
{
    public abstract class BedrockBlockTexture : BlockTexture<BedrockBlockTextureVersion>
    {
        public int FrameCount {get; set;} = 1;


        protected BedrockBlockTexture(string name) : base(name) {}

        protected BedrockBlockVersionBuilder<BedrockBlockTextureVersion> AddVersion(string id)
        {
            var version = new BedrockBlockTextureVersion {
                Id = id,
            };

            Versions.Add(version);
            return new BedrockBlockVersionBuilder<BedrockBlockTextureVersion>(version);
        }
    }
}
