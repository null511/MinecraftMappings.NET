using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateLantern : JavaBlockModel
    {
        public TemplateLantern() : base("Template Lantern")
        {
            AddVersion("template_lantern", "1.14")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 5f);
                    element.To = new Vector3(11f, 7f, 11f);
                    element.FaceUp = new ModelFace("#lantern") {
                        UV = UVMap(0f, 9f, 6f, 15f),
                    };
                    element.FaceDown = new ModelFace("#lantern") {
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
                    element.From = new Vector3(6f, 7f, 6f);
                    element.To = new Vector3(10f, 9f, 10f);
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
                    element.From = new Vector3(6.5f, 9f, 8f);
                    element.To = new Vector3(9.5f, 11f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                    };
                    element.FaceNorth = new ModelFace("#lantern") {
                        UV = UVMap(14f, 1f, 11f, 3f),
                    };
                    element.FaceSouth = new ModelFace("#lantern") {
                        UV = UVMap(11f, 1f, 14f, 3f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 9f, 6.5f);
                    element.To = new Vector3(8f, 11f, 9.5f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                    };
                    element.FaceWest = new ModelFace("#lantern") {
                        UV = UVMap(14f, 10f, 11f, 12f),
                    };
                    element.FaceEast = new ModelFace("#lantern") {
                        UV = UVMap(11f, 10f, 14f, 12f),
                    };
                });
        }
    }
}
