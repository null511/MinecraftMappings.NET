using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EmeraldOre : JavaBlockTexture
    {
        public EmeraldOre() : base("Emerald Ore")
        {
            AddVersion("emerald_ore");
                //.WithDefaultModel<Java.Models.Block.EmeraldOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EmeraldOre>();
        }
    }
}
