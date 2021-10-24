using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LilyPad : JavaBlockTexture
    {
        public LilyPad() : base("Lily Pad")
        {
            AddVersion("lily_pad")
                .WithDefaultModel<Java.Models.Block.LilyPad>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Waterlily>();
        }
    }
}
