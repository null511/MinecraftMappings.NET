using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_HangingLantern : JavaBlockModel
    {
        public Template_HangingLantern() : base("Template, Hanging Lantern")
        {
            AddVersion("template_hanging_lantern", "1.14")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(5f, 1f, 5f);
                    element.To = new Vector3(11f, 8f, 11f);
                    element.FaceDown = new ModelFace("#lantern") {
                        UV = UVMap(0f, 9f, 6f, 15f),
                    };
                    element.FaceUp = new ModelFace("#lantern") {
                        UV = UVMap(0f, 9f, 6f, 15f),
                    };
                    element.FaceNorth = new ModelFace("#lantern") {
                        UV = UVMap(0f, 2f, 6f, 9f),
                    };
                    element.FaceSouth = new ModelFace("#lantern") {
                        UV = UVMap(0f, 2f, 6f, 9f),
                    };
                    element.FaceWest = new ModelFace("#lantern") {
                        UV = UVMap(0f, 2f, 6f, 9f),
                    };
                    element.FaceEast = new ModelFace("#lantern") {
                        UV = UVMap(0f, 2f, 6f, 9f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 8f, 6f);
                    element.To = new Vector3(10f, 10f, 10f);
                    element.FaceDown = new ModelFace("#lantern") {
                        UV = UVMap(1f, 10f, 5f, 14f),
                    };
                    element.FaceUp = new ModelFace("#lantern") {
                        UV = UVMap(1f, 10f, 5f, 14f),
                    };
                    element.FaceNorth = new ModelFace("#lantern") {
                        UV = UVMap(1f, 0f, 5f, 2f),
                    };
                    element.FaceSouth = new ModelFace("#lantern") {
                        UV = UVMap(1f, 0f, 5f, 2f),
                    };
                    element.FaceWest = new ModelFace("#lantern") {
                        UV = UVMap(1f, 0f, 5f, 2f),
                    };
                    element.FaceEast = new ModelFace("#lantern") {
                        UV = UVMap(1f, 0f, 5f, 2f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6.5f, 11f, 8f);
                    element.To = new Vector3(9.5f, 15f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                    };
                    element.FaceNorth = new ModelFace("#lantern") {
                        UV = UVMap(14f, 1f, 11f, 5f),
                    };
                    element.FaceSouth = new ModelFace("#lantern") {
                        UV = UVMap(11f, 1f, 14f, 5f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 10f, 6.5f);
                    element.To = new Vector3(8f, 16f, 9.5f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                    };
                    element.FaceWest = new ModelFace("#lantern") {
                        UV = UVMap(14f, 6f, 11f, 12f),
                    };
                    element.FaceEast = new ModelFace("#lantern") {
                        UV = UVMap(11f, 6f, 14f, 12f),
                    };
                });
        }
    }
}
