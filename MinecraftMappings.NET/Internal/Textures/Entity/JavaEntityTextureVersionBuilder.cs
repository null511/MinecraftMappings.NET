﻿using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Internal.Textures.Entity
{
    public class JavaEntityTextureVersionBuilder<TVersion> : EntityTextureVersionBuilder<TVersion>
        where TVersion : JavaEntityTextureVersion
    {
        public JavaEntityTextureVersionBuilder(TVersion entityVersion) : base(entityVersion) {}

        public new JavaEntityTextureVersionBuilder<TVersion> WithPath(string path)
        {
            base.WithPath(path);
            return this;
        }

        public new JavaEntityTextureVersionBuilder<TVersion> WithBaseLayer<TTexture>()
            where TTexture : JavaEntityTexture
        {
            base.WithBaseLayer<TTexture>();
            return this;
        }

        public new JavaEntityTextureVersionBuilder<TVersion> WithDefaultModel<TModel>()
            where TModel : JavaEntityModel
        {
            base.WithDefaultModel<TModel>();
            return this;
        }

        public new JavaEntityTextureVersionBuilder<TVersion> WithMinVersion(string version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public new JavaEntityTextureVersionBuilder<TVersion> WithMinVersion(GameVersion version)
        {
            base.WithMinVersion(version);
            return this;
        }

        public new JavaEntityTextureVersionBuilder<TVersion> WithMaxVersion(string version)
        {
            base.WithMaxVersion(version);
            return this;
        }

        public JavaEntityTextureVersionBuilder<TVersion> MapsToBedrockEntity<TEntity>()
            where TEntity : BedrockEntityModel
        {
            EntityVersion.MapsToBedrockEntity = typeof(TEntity);
            return this;
        }
    }
}
