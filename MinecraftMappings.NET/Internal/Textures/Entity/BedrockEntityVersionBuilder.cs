using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Internal.Textures.Entity
{
    public class BedrockEntityVersionBuilder<TVersion> : EntityTextureVersionBuilder<TVersion>
        where TVersion : BedrockEntityTextureVersion
    {
        public BedrockEntityVersionBuilder(TVersion blockVersion) : base(blockVersion) {}

        public new BedrockEntityVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : BedrockEntityModel
        {
            base.WithDefaultModel<TModel>();
            return this;
        }

        public new BedrockEntityVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public BedrockEntityVersionBuilder<TVersion> MapsToJavaEntity<TEntity>()
            where TEntity : JavaEntityTexture
        {
            EntityVersion.MapsToJavaEntity = typeof(TEntity);
            return this;
        }
    }
}
