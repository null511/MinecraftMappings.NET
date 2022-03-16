using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Sunflower : JavaBlockModel
    {
        public Sunflower() : base("Sunflower")
        {
            AddVersion("sunflower", "1.7.2")
                .WithPath("models/block")
                .AddTexture("cross_bottom", "block/sunflower_bottom")
                .AddTexture("cross_top", "block/sunflower_top")
                .AddTexture("back", "block/sunflower_back")
                .AddTexture("front", "block/sunflower_front")
                .AddElement(element => {
                    element.From = new Vector3(0.8f, 0f, 8f);
                    element.To = new Vector3(15.2f, 16f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#cross_bottom",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#cross_bottom",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 0f, 0.8f);
                    element.To = new Vector3(8f, 16f, 15.2f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#cross_bottom",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#cross_bottom",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0.8f, 16f, 8f);
                    element.To = new Vector3(15.2f, 24f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 24f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 16f, 0.8f);
                    element.To = new Vector3(8f, 24f, 15.2f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 24f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(9.6f, 15f, 1f);
                    element.To = new Vector3(9.6f, 31f, 15f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 24f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = 22.5m,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace("#back") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#front") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                });
        }
    }
}
