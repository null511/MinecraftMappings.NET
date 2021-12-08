using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateIronOre : JavaBlockTexture
    {
        public DeepslateIronOre() : base("Deepslate Iron Ore")
        {
            AddVersion("deepslate_iron_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateIronOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateIronOre>();
        }
    }
}
