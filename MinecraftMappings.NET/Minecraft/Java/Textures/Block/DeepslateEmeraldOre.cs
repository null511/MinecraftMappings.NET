using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateEmeraldOre : JavaBlockTexture
    {
        public DeepslateEmeraldOre() : base("Deepslate Emerald Ore")
        {
            AddVersion("deepslate_emerald_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateEmeraldOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateEmeraldOre>();
        }
    }
}
