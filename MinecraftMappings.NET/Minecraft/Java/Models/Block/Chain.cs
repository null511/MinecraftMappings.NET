using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Chain : JavaModelData
    {
        public Chain() : base("Chain")
        {
            AddVersion("chain", "1.16")
                .WithPath("models/block")
                .AddTexture("all", "block/chain")
                .AddElement(element => {
                    element.From = new Vector3(6.5f, 0f, 8f);
                    element.To = new Vector3(9.5f, 16f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = new RectangleF(3f, 0f, -3f, 13f),
                        Texture = "#all",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = new RectangleF(0f, 0f, 3f, 16f),
                        Texture = "#all",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 0f, 6.5f);
                    element.To = new Vector3(8f, 16f, 9.5f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                    };
                    element.FaceWest = new ModelFace {
                        UV = new RectangleF(6f, 0f, -3f, 16f),
                        Texture = "#all",
                    };
                    element.FaceEast = new ModelFace {
                        UV = new RectangleF(3f, 0f, 3f, 16f),
                        Texture = "#all",
                    };
                });
        }
    }
}
