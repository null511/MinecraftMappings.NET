using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Grindstone : JavaBlockModel
    {
        public Grindstone() : base("Grindstone")
        {
            AddVersion("grindstone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("pivot", "block/grindstone_pivot")
                .AddTexture("round", "block/grindstone_round")
                .AddTexture("side", "block/grindstone_side")
                .AddTexture("leg", "block/dark_oak_log")
                .AddElement(element => {
                    element.From = new Vector3(12f, 0f, 6f);
                    element.To = new Vector3(14f, 7f, 10f);
                    element.FaceDown = new ModelFace("#leg") {
                        UV = new RectangleF(12f, 6f, 14f, 10f),
                    };
                    element.FaceNorth = new ModelFace("#leg") {
                        UV = new RectangleF(2f, 9f, 4f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#leg") {
                        UV = new RectangleF(12f, 9f, 14f, 16f),
                    };
                    element.FaceWest = new ModelFace("#leg") {
                        UV = new RectangleF(6f, 9f, 10f, 16f),
                    };
                    element.FaceEast = new ModelFace("#leg") {
                        UV = new RectangleF(10f, 16f, 6f, 9f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 6f);
                    element.To = new Vector3(4f, 7f, 10f);
                    element.FaceDown = new ModelFace("#leg") {
                        UV = new RectangleF(2f, 6f, 4f, 10f),
                    };
                    element.FaceNorth = new ModelFace("#leg") {
                        UV = new RectangleF(12f, 9f, 14f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#leg") {
                        UV = new RectangleF(2f, 9f, 4f, 16f),
                    };
                    element.FaceWest = new ModelFace("#leg") {
                        UV = new RectangleF(6f, 9f, 10f, 16f),
                    };
                    element.FaceEast = new ModelFace("#leg") {
                        UV = new RectangleF(10f, 16f, 6f, 9f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(12f, 7f, 5f);
                    element.To = new Vector3(14f, 13f, 11f);
                    element.FaceUp = new ModelFace("#pivot") {
                        UV = new RectangleF(8f, 0f, 10f, 6f),
                    };
                    element.FaceDown = new ModelFace("#pivot") {
                        UV = new RectangleF(8f, 0f, 10f, 6f),
                    };
                    element.FaceNorth = new ModelFace("#pivot") {
                        UV = new RectangleF(6f, 0f, 8f, 6f),
                    };
                    element.FaceSouth = new ModelFace("#pivot") {
                        UV = new RectangleF(6f, 0f, 8f, 6f),
                    };
                    element.FaceEast = new ModelFace("#pivot") {
                        UV = new RectangleF(0f, 0f, 6f, 6f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 7f, 5f);
                    element.To = new Vector3(4f, 13f, 11f);
                    element.FaceUp = new ModelFace("#pivot") {
                        UV = new RectangleF(8f, 0f, 10f, 6f),
                    };
                    element.FaceDown = new ModelFace("#pivot") {
                        UV = new RectangleF(8f, 0f, 10f, 6f),
                    };
                    element.FaceNorth = new ModelFace("#pivot") {
                        UV = new RectangleF(6f, 0f, 8f, 6f),
                    };
                    element.FaceSouth = new ModelFace("#pivot") {
                        UV = new RectangleF(6f, 0f, 8f, 6f),
                    };
                    element.FaceWest = new ModelFace("#pivot") {
                        UV = new RectangleF(0f, 0f, 6f, 6f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(4f, 4f, 2f);
                    element.To = new Vector3(12f, 16f, 14f);
                    element.FaceUp = new ModelFace("#round") {
                        UV = new RectangleF(0f, 0f, 8f, 12f),
                    };
                    element.FaceDown = new ModelFace("#round") {
                        UV = new RectangleF(0f, 0f, 8f, 12f),
                    };
                    element.FaceNorth = new ModelFace("#round") {
                        UV = new RectangleF(0f, 0f, 8f, 12f),
                    };
                    element.FaceSouth = new ModelFace("#round") {
                        UV = new RectangleF(0f, 0f, 8f, 12f),
                    };
                    element.FaceWest = new ModelFace("#side") {
                        UV = new RectangleF(0f, 0f, 12f, 12f),
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = new RectangleF(0f, 0f, 12f, 12f),
                    };
                });
        }
    }
}
