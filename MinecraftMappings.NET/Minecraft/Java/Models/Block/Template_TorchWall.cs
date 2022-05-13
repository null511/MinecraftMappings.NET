using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_TorchWall : JavaBlockModel
    {
        public Template_TorchWall() : base("Template Torch, Wall")
        {
            AddVersion("template_torch_wall", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(-1f, 3.5f, 7f);
                    element.To = new Vector3(1f, 13.5f, 9f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(0f, 3.5f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = -22.5m,
                    };
                    element.FaceUp = new ModelFace("#torch") {
                        UV = UVMap(7f, 6f, 9f, 8f),
                    };
                    element.FaceDown = new ModelFace("#torch") {
                        UV = UVMap(7f, 13f, 9f, 15f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(-1f, 3.5f, 0f);
                    element.To = new Vector3(1f, 19.5f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(0f, 3.5f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = -22.5m,
                    };
                    element.FaceWest = new ModelFace("#torch", UVFull);
                    element.FaceEast = new ModelFace("#torch", UVFull);
                })
                .AddElement(element => {
                    element.From = new Vector3(-8f, 3.5f, 7f);
                    element.To = new Vector3(8f, 19.5f, 9f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(0f, 3.5f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = -22.5m,
                    };
                    element.FaceNorth = new ModelFace("#torch", UVFull);
                    element.FaceSouth = new ModelFace("#torch", UVFull);
                });
        }
    }
}
