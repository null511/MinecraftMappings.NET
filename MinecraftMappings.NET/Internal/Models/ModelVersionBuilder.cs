using System;

namespace MinecraftMappings.Internal.Models
{
    public class ModelVersionBuilder
    {
        private readonly ModelVersion modelVersion;


        public ModelVersionBuilder(ModelVersion modelVersion)
        {
            this.modelVersion = modelVersion;
        }

        public ModelVersionBuilder WithPath(string path)
        {
            modelVersion.Path = path;
            return this;
        }

        public ModelVersionBuilder WithParent(string parent)
        {
            modelVersion.Parent = parent;
            return this;
        }

        public ModelVersionBuilder AddTexture(string name, string value)
        {
            modelVersion.Textures[name] = value;
            return this;
        }

        public ModelVersionBuilder AddElement(Action<ModelElement> elementAction)
        {
            return AddElement(null, elementAction);
        }

        public ModelVersionBuilder AddElement(string name, Action<ModelElement> elementAction)
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
