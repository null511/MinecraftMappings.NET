using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TallCross : JavaBlockModel
    {
        public TallCross() : base("Tall Cross")
        {
            AddVersion("tall_cross", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0.8f, 16f, 8f);
                    element.To = new Vector3(15.2f, 32f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 16f, 0.8f);
                    element.To = new Vector3(8f, 32f, 15.2f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#cross_top") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0.8f, 0f, 8f);
                    element.To = new Vector3(15.2f, 16f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#cross_bottom") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#cross_bottom") {
                        UV = UVMap(0f, 0f, 16f, 16f),
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
                    element.FaceWest = new ModelFace("#cross_bottom") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#cross_bottom") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                });
        }
    }
}
