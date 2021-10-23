using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Crop : JavaBlockModel
    {
        public Crop() : base("Crop")
        {
            AddVersion("crop", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(4f, -1f, 0f);
                    element.To = new Vector3(4f, 15f, 16f);
                    element.FaceWest = new ModelFace("#crop") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#crop") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(12f, -1f, 0f);
                    element.To = new Vector3(12f, 15f, 16f);
                    element.FaceWest = new ModelFace("#crop") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                    element.FaceEast = new ModelFace("#crop") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, -1f, 4f);
                    element.To = new Vector3(16f, 15f, 4f);
                    element.FaceNorth = new ModelFace("#crop") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#crop") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, -1f, 12f);
                    element.To = new Vector3(16f, 15f, 12f);
                    element.FaceNorth = new ModelFace("#crop") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#crop") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                });
        }
    }
}
