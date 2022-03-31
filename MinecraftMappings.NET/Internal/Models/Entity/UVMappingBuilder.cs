using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class UVMappingBuilder
    {
        private readonly EntityModelVersion entityVersion;
        private readonly string id;


        public UVMappingBuilder(EntityModelVersion entityVersion, string id)
        {
            this.entityVersion = entityVersion;
            this.id = id;
        }

        public UVMappingBuilder AddFace(ElementFaces face, in float left, in float top, in float right, in float bottom)
        {
            if (!entityVersion.UVMap.TryGetValue(id, out var part))
                part = entityVersion.UVMap[id] = new Dictionary<ElementFaces, RectangleF>();

            part[face] = UVHelper.UVMap(in left, in top, in right, in bottom);
            return this;
        }
    }
}
