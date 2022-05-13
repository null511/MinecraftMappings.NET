using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_Campfire : JavaBlockModel
    {
        public Template_Campfire() : base("Template Campfire")
        {
            AddVersion("template_campfire", "1.14")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("log", "block/campfire_log")
                .AddElement(element => {
                    element.From = new Vector3(1f, 0f, 0f);
                    element.To = new Vector3(5f, 4f, 16f);
                    element.FaceUp = new ModelFace("#log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("#log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceNorth = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                    element.FaceSouth = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                    element.FaceWest = new ModelFace("#log") {
                        UV = UVMap(16f, 0f, 0f, 4f),
                    };
                    element.FaceEast = new ModelFace("#lit_log") {
                        UV = UVMap(0f, 1f, 16f, 5f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 3f, 11f);
                    element.To = new Vector3(16f, 7f, 15f);
                    element.FaceUp = new ModelFace("#log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 180,
                    };
                    element.FaceDown = new ModelFace("#lit_log") {
                        UV = UVMap(0f, 4f, 16f, 8f),
                    };
                    element.FaceNorth = new ModelFace("#lit_log") {
                        UV = UVMap(16f, 0f, 0f, 4f),
                    };
                    element.FaceSouth = new ModelFace("#lit_log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                    };
                    element.FaceWest = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                    element.FaceEast = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(11f, 0f, 0f);
                    element.To = new Vector3(15f, 4f, 16f);
                    element.FaceUp = new ModelFace("#log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("#log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceNorth = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                    element.FaceSouth = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                    element.FaceWest = new ModelFace("#lit_log") {
                        UV = UVMap(16f, 1f, 0f, 5f),
                    };
                    element.FaceEast = new ModelFace("#log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 3f, 1f);
                    element.To = new Vector3(16f, 7f, 5f);
                    element.FaceUp = new ModelFace("#log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 180,
                    };
                    element.FaceDown = new ModelFace("#lit_log") {
                        UV = UVMap(0f, 4f, 16f, 8f),
                    };
                    element.FaceNorth = new ModelFace("#lit_log") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                    };
                    element.FaceSouth = new ModelFace("#lit_log") {
                        UV = UVMap(16f, 0f, 0f, 4f),
                    };
                    element.FaceWest = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                    element.FaceEast = new ModelFace("#log") {
                        UV = UVMap(0f, 4f, 4f, 8f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 0f);
                    element.To = new Vector3(11f, 1f, 16f);
                    element.FaceUp = new ModelFace("#lit_log") {
                        UV = UVMap(0f, 8f, 16f, 14f),
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("#log") {
                        UV = UVMap(0f, 8f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceNorth = new ModelFace("#log") {
                        UV = UVMap(0f, 15f, 6f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#log") {
                        UV = UVMap(10f, 15f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0.8f, 1f, 8f);
                    element.To = new Vector3(15.2f, 17f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#fire", UVFull);
                    element.FaceSouth = new ModelFace("#fire", UVFull);
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 1f, 0.8f);
                    element.To = new Vector3(8f, 17f, 15.2f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace("#fire", UVFull);
                    element.FaceEast = new ModelFace("#fire", UVFull);
                });
        }
    }
}
