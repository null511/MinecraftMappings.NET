using SharpDX;
using System;
using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Entity
{
    public abstract class EntityModelVersion : Versionable
    {
        public string? Id {get; set;}
        public Vector2 TextureSize;

        public string? Texture {get; set;}
        public List<EntityElement> Elements {get; set;}
        public Dictionary<string, Dictionary<ElementFaces, RectangleF>> UVMap {get; set;}

        
        protected EntityModelVersion()
        {
            Elements = new List<EntityElement>();
            UVMap = new Dictionary<string, Dictionary<ElementFaces, RectangleF>>(StringComparer.InvariantCultureIgnoreCase);
        }

        public bool TryReplacePart(EntityElement partModel)
        {
            var count = Elements.Count;
            for (var i = 0; i < count; i++) {
                if (!string.Equals(Elements[i].Part, partModel.Part, StringComparison.InvariantCultureIgnoreCase)) continue;

                if (partModel.Model != null) {
                    Elements[i].Boxes.Clear();
                    Elements[i].Submodels.Clear();
                    //Elements[i].Submodels.Add(partModel);

                    Elements[i].Attach = partModel.Attach;
                    Elements[i].Model = partModel.Model;
                    //Elements[i].Translate = partModel.Translate;
                    //Elements[i].RotationAngleX = partModel.RotationAngleX;
                    //Elements[i].RotationAngleY = partModel.RotationAngleY;
                    //Elements[i].RotationAngleZ = partModel.RotationAngleZ;
                }
                else {
                    Elements[i] = partModel;
                }

                return true;
            }

            return false;
        }
    }
}
