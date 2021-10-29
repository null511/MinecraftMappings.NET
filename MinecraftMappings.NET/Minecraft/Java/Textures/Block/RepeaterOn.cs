using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RepeaterOn : JavaBlockTexture
    {
        public RepeaterOn() : base("Repeater, On")
        {
            AddVersion("repeater_on")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.Repeater_4TickOn>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RepeaterOn>();
        }
    }
}
