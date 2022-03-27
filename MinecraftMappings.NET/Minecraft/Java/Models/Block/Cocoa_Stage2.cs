using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cocoa_Stage2 : JavaBlockModel
    {
        public Cocoa_Stage2() : base("Cocoa, Stage 2")
        {
            AddVersion("cocoa_stage2", "1.0.0")
                .WithPath("models/block")
                .AddTexture("cocoa", "block/cocoa_stage2")
                .AddElement(element => {
                    element.From = new Vector3(4f, 3f, 7f);
                    element.To = new Vector3(12f, 12f, 15f);
                    element.FaceDown = new ModelFace("#cocoa") {
                        UV = UVMap(0f, 0f, 7f, 7f),
                    };
                    element.FaceUp = new ModelFace("#cocoa") {
                        UV = UVMap(0f, 0f, 7f, 7f),
                    };
                    element.FaceNorth = new ModelFace("#cocoa") {
                        UV = UVMap(7f, 4f, 15f, 13f),
                    };
                    element.FaceSouth = new ModelFace("#cocoa") {
                        UV = UVMap(7f, 4f, 15f, 13f),
                    };
                    element.FaceWest = new ModelFace("#cocoa") {
                        UV = UVMap(7f, 4f, 15f, 13f),
                    };
                    element.FaceEast = new ModelFace("#cocoa") {
                        UV = UVMap(7f, 4f, 15f, 13f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 12f, 12f);
                    element.To = new Vector3(8f, 16f, 16f);
                    element.FaceWest = new ModelFace("#cocoa") {
                        UV = UVMap(12f, 0f, 16f, 4f),
                    };
                    element.FaceEast = new ModelFace("#cocoa") {
                        UV = UVMap(16f, 0f, 12f, 4f),
                    };
                });
        }
    }
}
