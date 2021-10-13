using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Internal.Textures.Block
{
    public class BedrockBlockVersionBuilder<TVersion> : BlockTextureVersionBuilder<TVersion>
        where TVersion : BedrockBlockTextureVersion
    {
        public BedrockBlockVersionBuilder(TVersion blockVersion) : base(blockVersion) {}

        public new BedrockBlockVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : BedrockBlockModel
        {
            base.WithDefaultModel<TModel>();
            return this;
        }

        public new BedrockBlockVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public new BedrockBlockVersionBuilder<TVersion> WithFrameCount(int frameCount)
        {
            base.WithFrameCount(frameCount);
            return this;
        }

        public BedrockBlockVersionBuilder<TVersion> MapsToJavaBlock<TBlock>()
            where TBlock : JavaBlockTexture
        {
            BlockVersion.MapsToJavaBlock = typeof(TBlock);
            return this;
        }
    }
}
