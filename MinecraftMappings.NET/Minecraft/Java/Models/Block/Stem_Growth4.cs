using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Stem_Growth4 : JavaBlockModel
    {
        public Stem_Growth4() : base("Stem, Growth 4")
        {
            AddVersion("stem_growth4", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, -1f, 8f);
                    element.To = new Vector3(16f, 9f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 10f),
                        Texture = "#stem",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(16f, 0f, 0f, 10f),
                        Texture = "#stem",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, -1f, 0f);
                    element.To = new Vector3(8f, 9f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 10f),
                        Texture = "#stem",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(16f, 0f, 0f, 10f),
                        Texture = "#stem",
                    };
                });
        }
    }
}
