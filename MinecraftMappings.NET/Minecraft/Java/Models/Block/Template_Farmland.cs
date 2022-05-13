using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_Farmland : JavaBlockModel
    {
        public Template_Farmland() : base("Template Farmland")
        {
            AddVersion("template_farmland", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 15f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#dirt", UVFull);
                    element.FaceNorth = new ModelFace("#dirt") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#dirt") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                    element.FaceWest = new ModelFace("#dirt") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#dirt") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                });
        }
    }
}
