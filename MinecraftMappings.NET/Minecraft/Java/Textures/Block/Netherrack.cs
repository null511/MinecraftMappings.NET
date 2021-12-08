using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Netherrack : JavaBlockTexture
    {
        public Netherrack() : base("Netherrack")
        {
            AddVersion("netherrack");
                //.WithDefaultModel<Java.Models.Block.Netherrack>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Netherrack>();
        }
    }
}
