using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Lever : JavaBlockModel
    {
        public Lever() : base("Lever")
        {
            AddVersion("lever", "1.0.1")
                .WithPath("models/block")
                .AddTexture("base", "block/cobblestone")
                .AddTexture("lever", "block/lever")
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 4f);
                    element.To = new Vector3(11f, 3f, 12f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(5f, 4f, 11f, 12f),
                        Texture = "#base",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(5f, 4f, 11f, 12f),
                        Texture = "#base",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(5f, 0f, 11f, 3f),
                        Texture = "#base",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(5f, 0f, 11f, 3f),
                        Texture = "#base",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(4f, 0f, 12f, 3f),
                        Texture = "#base",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(4f, 0f, 12f, 3f),
                        Texture = "#base",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 1f, 7f);
                    element.To = new Vector3(9f, 11f, 9f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 1f, 8f),
                        Axis = ModelAxis.X,
                        Angle = -45,
                    };
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#lever",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 16f),
                        Texture = "#lever",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 16f),
                        Texture = "#lever",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 16f),
                        Texture = "#lever",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 16f),
                        Texture = "#lever",
                    };
                });
        }
    }
}
