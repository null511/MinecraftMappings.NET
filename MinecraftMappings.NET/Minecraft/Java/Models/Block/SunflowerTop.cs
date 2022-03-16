using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SunflowerTop : JavaBlockModel
    {
        public SunflowerTop() : base("Sunflower Top")
        {
            AddVersion("sunflower_top", "1.0.0")
                .WithPath("models/block")
                .AddTexture("cross", "block/sunflower_top")
                .AddTexture("back", "block/sunflower_back")
                .AddTexture("front", "block/sunflower_front")
                .AddElement(element => {
                    element.From = new Vector3(0.8f, 0f, 8f);
                    element.To = new Vector3(15.2f, 8f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#cross") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#cross") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 0f, 0.8f);
                    element.To = new Vector3(8f, 8f, 15.2f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace("#cross") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#cross") {
                        UV = UVMap(0f, 8f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(9.6f, -1f, 1f);
                    element.To = new Vector3(9.6f, 15f, 15f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
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
