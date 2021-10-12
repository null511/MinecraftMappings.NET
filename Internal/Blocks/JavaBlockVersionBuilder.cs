using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Internal.Blocks
{
    public class JavaBlockVersionBuilder<TVersion> : BlockVersionBuilder<TVersion>
        where TVersion : JavaBlockDataVersion
    {
        public JavaBlockVersionBuilder(TVersion blockVersion) : base(blockVersion) {}

        public new JavaBlockVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : JavaModelData
        {
            base.WithDefaultModel<TModel>();
            return this;
        }

        public new JavaBlockVersionBuilder<TVersion> WithMinVersion(string version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public new JavaBlockVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public JavaBlockVersionBuilder<TVersion> MapsToBedrockBlock<TBlock>()
            where TBlock : BedrockBlockData
        {
            BlockVersion.MapsToBedrockBlock = typeof(TBlock);
            return this;
        }
    }
}
