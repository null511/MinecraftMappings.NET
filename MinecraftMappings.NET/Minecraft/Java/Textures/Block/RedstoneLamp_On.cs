using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneLamp_On : JavaBlockTexture
    {
        public RedstoneLamp_On() : base("Redstone Lamp, On")
        {
            AddVersion("redstone_lamp_on");
                //.WithDefaultModel<Java.Models.Block.RedstoneLamp>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneLamp_On>();
        }
    }
}
