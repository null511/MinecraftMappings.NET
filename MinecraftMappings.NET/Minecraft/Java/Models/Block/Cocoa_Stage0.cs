using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cocoa_Stage0 : JavaBlockModel
    {
        public Cocoa_Stage0() : base("Cocoa, Stage 0")
        {
            AddVersion("cocoa_stage0", "1.0.0")
                .WithPath("models/block")
                .AddTexture("cocoa", "block/cocoa_stage0")
                .AddElement(element => {
                    element.From = new Vector3(6f, 7f, 11f);
                    element.To = new Vector3(10f, 12f, 15f);
                    element.FaceDown = new ModelFace("#cocoa") {
                        UV = UVMap(0f, 0f, 4f, 4f),
                    };
                    element.FaceUp = new ModelFace("#cocoa") {
                        UV = UVMap(0f, 0f, 4f, 4f),
                    };
                    element.FaceNorth = new ModelFace("#cocoa") {
                        UV = UVMap(11f, 4f, 15f, 9f),
                    };
                    element.FaceSouth = new ModelFace("#cocoa") {
                        UV = UVMap(11f, 4f, 15f, 9f),
                    };
                    element.FaceWest = new ModelFace("#cocoa") {
                        UV = UVMap(11f, 4f, 15f, 9f),
                    };
                    element.FaceEast = new ModelFace("#cocoa") {
                        UV = UVMap(11f, 4f, 15f, 9f),
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
