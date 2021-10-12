using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BambooSmallLeaves : JavaModelData
    {
        public BambooSmallLeaves() : base("Bamboo, Small Leaves")
        {
            AddVersion("bamboo_small_leaves", "1.14")
                .WithPath("models/block")
                .AddTexture("texture", "block/bamboo_small_leaves")
                .AddElement(element => {
                    element.From = new Vector3(0.8f, 0f, 8f);
                    element.To = new Vector3(15.2f, 16f, 8f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#texture",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 0f, 0.8f);
                    element.To = new Vector3(8f, 16f, 15.2f);
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#texture",
                    };
                });
        }
    }
}
