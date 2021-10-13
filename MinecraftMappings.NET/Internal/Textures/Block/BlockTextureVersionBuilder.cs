using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Internal.Textures.Block
{
    public abstract class BlockTextureVersionBuilder<TVersion>
        where TVersion : BlockTextureVersion
    {
        protected readonly TVersion BlockVersion;


        protected BlockTextureVersionBuilder(TVersion blockVersion)
        {
            BlockVersion = blockVersion;
        }

        protected BlockTextureVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : IBlockModel
        {
            BlockVersion.DefaultModel = typeof(TModel);
            return this;
        }

        protected BlockTextureVersionBuilder<TVersion> WithMinVersion(string version)
        {
            BlockVersion.MinVersion = GameVersion.Parse(version);
            return this;
        }

        public new BlockTextureVersionBuilder<TVersion> WithFrameCount(int frameCount)
        {
            BlockVersion.FrameCount = frameCount;
            return this;
        }

        protected BlockTextureVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            BlockVersion.MinVersion = version;
            return this;
        }
    }
}
