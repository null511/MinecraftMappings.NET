using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Internal.Textures.Block
{
    public class JavaBlockTextureVersionBuilder<TVersion> : BlockTextureVersionBuilder<TVersion>
        where TVersion : JavaBlockTextureVersion
    {
        public JavaBlockTextureVersionBuilder(TVersion blockVersion) : base(blockVersion) {}

        public new JavaBlockTextureVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : JavaBlockModel
        {
            base.WithDefaultModel<TModel>();
            return this;
        }

        public new JavaBlockTextureVersionBuilder<TVersion> WithMinVersion(string version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public new JavaBlockTextureVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public new JavaBlockTextureVersionBuilder<TVersion> WithFrameCount(int frameCount)
        {
            BlockVersion.FrameCount = frameCount;
            return this;
        }

        public JavaBlockTextureVersionBuilder<TVersion> MapsToBedrockBlock<TBlock>()
            where TBlock : BedrockBlockTexture
        {
            BlockVersion.MapsToBedrockBlock = typeof(TBlock);
            return this;
        }
    }
}
