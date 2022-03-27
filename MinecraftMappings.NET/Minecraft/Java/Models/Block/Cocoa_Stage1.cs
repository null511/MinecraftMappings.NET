using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cocoa_Stage1 : JavaBlockModel
    {
        public Cocoa_Stage1() : base("Cocoa, Stage 1")
        {
            AddVersion("cocoa_stage1", "1.0.0")
                .WithPath("models/block")
                .AddTexture("cocoa", "block/cocoa_stage1")
                .AddElement(element => {
                    element.From = new Vector3(5f, 5f, 9f);
                    element.To = new Vector3(11f, 12f, 15f);
                    element.FaceDown = new ModelFace("#cocoa") {
                        UV = UVMap(0f, 0f, 6f, 6f),
                    };
                    element.FaceUp = new ModelFace("#cocoa") {
                        UV = UVMap(0f, 0f, 6f, 6f),
                    };
                    element.FaceNorth = new ModelFace("#cocoa") {
                        UV = UVMap(9f, 4f, 15f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#cocoa") {
                        UV = UVMap(9f, 4f, 15f, 11f),
                    };
                    element.FaceWest = new ModelFace("#cocoa") {
                        UV = UVMap(9f, 4f, 15f, 11f),
                    };
                    element.FaceEast = new ModelFace("#cocoa") {
                        UV = UVMap(9f, 4f, 15f, 11f),
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
