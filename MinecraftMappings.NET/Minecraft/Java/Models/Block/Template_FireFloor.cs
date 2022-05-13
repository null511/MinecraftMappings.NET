using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_FireFloor : JavaBlockModel
    {
        public Template_FireFloor() : base("Template Fire, Floor")
        {
            AddVersion("template_fire_floor", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 8.8f);
                    element.To = new Vector3(16f, 22.4f, 8.8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.X,
                        Angle = -22.5m,
                        Rescale = true,
                    };
                    element.FaceSouth = new ModelFace("#fire", UVFull);
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 7.2f);
                    element.To = new Vector3(16f, 22.4f, 7.2f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.X,
                        Angle = 22.5m,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#fire", UVFull);
                })
                .AddElement(element => {
                    element.From = new Vector3(8.8f, 0f, 0f);
                    element.To = new Vector3(8.8f, 22.4f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = -22.5m,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace("#fire", UVFull);
                })
                .AddElement(element => {
                    element.From = new Vector3(7.2f, 0f, 0f);
                    element.To = new Vector3(7.2f, 22.4f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = 22.5m,
                        Rescale = true,
                    };
                    element.FaceEast = new ModelFace("#fire", UVFull);
                });
        }
    }
}
