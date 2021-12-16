using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CoralFan : JavaBlockModel
    {
        public CoralFan() : base("Coral Fan")
        {
            AddVersion("coral_fan", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(8f, 0f, 0f);
                    element.To = new Vector3(24f, 0f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 0f, 0f),
                        Axis = ModelAxis.Z,
                        Angle = 22.5m,
                        Rescale = false,
                    };
                    element.FaceUp = new ModelFace("fan", UVFull) {
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("fan") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                        Rotation = 270,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(-8f, 0f, 0f);
                    element.To = new Vector3(8f, 0f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 0f, 0f),
                        Axis = ModelAxis.Z,
                        Angle = -22.5m,
                        Rescale = false,
                    };
                    element.FaceUp = new ModelFace("fan", UVFull) {
                        Rotation = 270,
                    };
                    element.FaceDown = new ModelFace("fan") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                        Rotation = 90,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 8f);
                    element.To = new Vector3(16f, 0f, 24f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(0f, 0f, 8f),
                        Axis = ModelAxis.X,
                        Angle = -22.5m,
                        Rescale = false,
                    };
                    element.FaceUp = new ModelFace("fan", UVFull) {
                        Rotation = 270,
                    };
                    element.FaceDown = new ModelFace("fan") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                        Rotation = 90,
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
                        Texture = "#cross",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#cross",
                    };
                });
        }
    }
}
