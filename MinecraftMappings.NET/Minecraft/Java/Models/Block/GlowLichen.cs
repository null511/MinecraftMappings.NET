using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class GlowLichen : JavaBlockModel
    {
        public GlowLichen() : base("Glow Lichen")
        {
            AddVersion("glow_lichen", "1.0.0")
                .WithPath("models/block")
                .AddTexture("glow_lichen", "block/glow_lichen")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0.1f);
                    element.To = new Vector3(16f, 16f, 0.1f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(16f, 0f, 0f, 16f),
                        Texture = "#glow_lichen",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#glow_lichen",
                    };
                });
        }
    }
}
