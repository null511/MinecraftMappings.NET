using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SeaPickle : JavaBlockModel
    {
        public SeaPickle() : base("Sea Pickle")
        {
            AddVersion("sea_pickle", "1.13")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("all", "block/sea_pickle")
                .AddElement(element => {
                    element.From = new Vector3(6f, 0f, 6f);
                    element.To = new Vector3(10f, 6f, 10f);
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(8f, 1f, 12f, 5f),
                    };
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(4f, 1f, 8f, 5f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(4f, 5f, 8f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(0f, 5f, 4f, 11f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(8f, 5f, 12f, 11f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(12f, 5f, 16f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 5.95f, 6f);
                    element.To = new Vector3(10f, 5.95f, 10f);
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(8f, 1f, 12f, 5f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.5f, 5.2f, 8f);
                    element.To = new Vector3(8.5f, 8.7f, 8f);
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(1f, 0f, 3f, 5f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(3f, 0f, 1f, 5f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 5.2f, 7.5f);
                    element.To = new Vector3(8f, 8.7f, 8.5f);
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(13f, 0f, 15f, 5f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(15f, 0f, 13f, 5f),
                    };
                });
        }
    }
}
