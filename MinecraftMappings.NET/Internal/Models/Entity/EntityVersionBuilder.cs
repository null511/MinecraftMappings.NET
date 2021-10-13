﻿using System;

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

        public EntityVersionBuilder<TVersion> WithPath(string path)
        {
            entityVersion.Path = path;
            return this;
        }

        public EntityVersionBuilder<TVersion> AddElement(Action<EntityElement> elementAction) => AddElement(null, elementAction);

        public EntityVersionBuilder<TVersion> AddElement(string name, Action<EntityElement> elementAction)
        {
            var element = new EntityElement {
                Name = name,
            };

            entityVersion.Elements.Add(element);

            //var elementBuilder = new ModelElementBuilder(element);
            elementAction(element);

            return this;
        }

        public EntityVersionBuilder<TVersion> AddUVMapping(Action<UVRegion> uvAction)
        {
            var region = new UVRegion();
            entityVersion.UVMappings.Add(region);

            //var elementBuilder = new ModelElementBuilder(element);
            uvAction(region);

            return this;
        }

        public EntityVersionBuilder<TVersion> WithUVMappings(params UVRegion[] mappings)
        {
            entityVersion.UVMappings.AddRange(mappings);
            return this;
        }
    }
}