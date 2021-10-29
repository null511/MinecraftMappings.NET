using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DirtPath : JavaBlockModel
    {
        public DirtPath() : base("Dirt Path")
        {
            AddVersion("dirt_block", "1.17")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/dirt_path_top")
                .AddTexture("side", "block/dirt_path_side")
                .AddTexture("bottom", "block/dirt")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 15f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#bottom", UVFull);
                    element.FaceNorth = new ModelFace("#side") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#side") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                    element.FaceWest = new ModelFace("#side") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = UVMap(0f, 1f, 16f, 16f),
                    };
                });
        }
    }
}
