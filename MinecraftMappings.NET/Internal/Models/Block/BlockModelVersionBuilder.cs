using System;

namespace MinecraftMappings.Internal.Models.Block
{
    public class BlockModelVersionBuilder
    {
        private readonly BlockModelVersion modelVersion;


        public BlockModelVersionBuilder(BlockModelVersion modelVersion)
        {
            this.modelVersion = modelVersion;
        }

        public BlockModelVersionBuilder WithPath(string path)
        {
            modelVersion.Path = path;
            return this;
        }

        public BlockModelVersionBuilder WithParent(string parent)
        {
            modelVersion.Parent = parent;
            return this;
        }

        public BlockModelVersionBuilder AddTexture(string name, string value)
        {
            modelVersion.Textures[name] = value;
            return this;
        }

        public BlockModelVersionBuilder AddElement(Action<ModelElement> elementAction)
        {
            return AddElement(null, elementAction);
        }

        public BlockModelVersionBuilder AddElement(string? name, Action<ModelElement> elementAction)
        {
            var element = new ModelElement {
                Name = name,
            };

            modelVersion.Elements.Add(element);
            elementAction(element);

            return this;
        }
    }
}
