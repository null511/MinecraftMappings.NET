using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LapisOre : JavaBlockTexture
    {
        public LapisOre() : base("Lapis Ore")
        {
            AddVersion("lapis_ore");
                //.WithDefaultModel<Java.Models.Block.LapisOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LapisOre>();
        }
    }
}
