using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CoalOre : JavaBlockTexture
    {
        public CoalOre() : base("Coal Ore")
        {
            AddVersion("coal_ore")
                .WithDefaultModel<Java.Models.Block.CoalOre>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CoalOre>();
        }
    }
}
