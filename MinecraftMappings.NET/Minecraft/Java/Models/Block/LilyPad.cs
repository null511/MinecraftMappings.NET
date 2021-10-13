using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class LilyPad : JavaBlockModel
    {
        public LilyPad() : base("Lily Pad")
        {
            AddVersion("lily_pad", "1.0.0")
                .WithPath("models/block")
                .AddTexture("texture", "block/lily_pad")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0.25f, 0f);
                    element.To = new Vector3(16f, 0.25f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(16f, 0f, 0f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(16f, 16f, 0f, 0f),
                        Texture = "#texture",
                    };
                });
        }
    }
}
