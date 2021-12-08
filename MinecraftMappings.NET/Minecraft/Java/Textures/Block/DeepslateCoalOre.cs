using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateCoalOre : JavaBlockTexture
    {
        public DeepslateCoalOre() : base("Deepslate Coal Ore")
        {
            AddVersion("deepslate_coal_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateCoalOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateCoalOre>();
        }
    }
}
