using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class GrassPathOverlay : JavaBlockModel
    {
        public GrassPathOverlay() : base("Grass Path, Overlay")
        {
            AddVersion("grass_path_overlay", "1.0.0", "1.17")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/grass_path_top")
                .AddTexture("dirt", "block/dirt")
                .AddTexture("overlay", "block/grass_path_side_overlay")
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
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceNorth = new ModelFace("#overlay", UVFull);
                    element.FaceSouth = new ModelFace("#overlay", UVFull);
                    element.FaceWest = new ModelFace("#overlay", UVFull);
                    element.FaceEast = new ModelFace("#overlay", UVFull);
                });
        }
    }
}
