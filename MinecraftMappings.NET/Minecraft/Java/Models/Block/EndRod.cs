using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class EndRod : JavaBlockModel
    {
        public EndRod() : base("End Rod")
        {
            AddVersion("end_rod", "1.9")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(6f, 0f, 6f);
                    element.To = new Vector3(10f, 1f, 10f);
                    element.FaceUp = new ModelFace("#end_rod") {
                        UV = UVMap(2f, 2f, 6f, 6f),
                    };
                    element.FaceDown = new ModelFace("#end_rod") {
                        UV = UVMap(6f, 6f, 2f, 2f),
                    };
                    element.FaceNorth = new ModelFace("#end_rod") {
                        UV = UVMap(2f, 6f, 6f, 7f),
                    };
                    element.FaceSouth = new ModelFace("#end_rod") {
                        UV = UVMap(2f, 6f, 6f, 7f),
                    };
                    element.FaceWest = new ModelFace("#end_rod") {
                        UV = UVMap(2f, 6f, 6f, 7f),
                    };
                    element.FaceEast = new ModelFace("#end_rod") {
                        UV = UVMap(2f, 6f, 6f, 7f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 1f, 7f);
                    element.To = new Vector3(9f, 16f, 9f);
                    element.FaceUp = new ModelFace("#end_rod") {
                        UV = UVMap(2f, 0f, 4f, 2f),
                    };
                    element.FaceNorth = new ModelFace("#end_rod") {
                        UV = UVMap(0f, 0f, 2f, 15f),
                    };
                    element.FaceSouth = new ModelFace("#end_rod") {
                        UV = UVMap(0f, 0f, 2f, 15f),
                    };
                    element.FaceWest = new ModelFace("#end_rod") {
                        UV = UVMap(0f, 0f, 2f, 15f),
                    };
                    element.FaceEast = new ModelFace("#end_rod") {
                        UV = UVMap(0f, 0f, 2f, 15f),
                    };
                });
        }
    }
}
