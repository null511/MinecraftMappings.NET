using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Internal.Blocks
{
    public class BedrockBlockVersionBuilder<TVersion> : BlockVersionBuilder<TVersion>
        where TVersion : BedrockBlockDataVersion
    {
        public BedrockBlockVersionBuilder(TVersion blockVersion) : base(blockVersion) {}

        public new BedrockBlockVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : BedrockModelData
        {
            base.WithDefaultModel<TModel>();
            return this;
        }

        public new BedrockBlockVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public BedrockBlockVersionBuilder<TVersion> MapsToJavaBlock<TBlock>()
            where TBlock : JavaBlockData
        {
            BlockVersion.MapsToJavaBlock = typeof(TBlock);
            return this;
        }
    }
}
