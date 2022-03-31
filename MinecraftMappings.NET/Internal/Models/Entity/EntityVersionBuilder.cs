using SharpDX;
using System;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class EntityVersionBuilder<TVersion>
        where TVersion : EntityModelVersion, new()
    {
        private readonly EntityModelVersion entityVersion;


        public EntityVersionBuilder(EntityModelVersion entityVersion)
        {
            this.entityVersion = entityVersion;
        }

        public EntityVersionBuilder<TVersion> WithTextureSize(int width, int height)
        {
            entityVersion.TextureSize = new Vector2(width, height);
            return this;
        }

        public EntityVersionBuilder<TVersion> AddElement(string id, Action<EntityElement> elementAction)
        {
            var element = new EntityElement(id);
            entityVersion.Elements.Add(element);
            elementAction(element);
            return this;
        }

        public EntityVersionBuilder<TVersion> AddUVMapping(string id, Action<UVMappingBuilder> action)
        {
            var builder = new UVMappingBuilder(entityVersion, id);
            action(builder);
            return this;
        }
    }
}
