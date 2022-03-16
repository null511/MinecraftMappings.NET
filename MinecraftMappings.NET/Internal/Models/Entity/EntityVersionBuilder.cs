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

            //var elementBuilder = new ModelElementBuilder(element);
            elementAction(element);

            return this;
        }

        //public EntityVersionBuilder<TVersion> AddElement(Action<EntityElement> elementAction) => AddElement(null, elementAction);

        //public EntityVersionBuilder<TVersion> WithUVMappings(params UVRegion[] mappings)
        //{
        //    entityVersion.UVMappings.AddRange(mappings);
        //    return this;
        //}
    }
}
