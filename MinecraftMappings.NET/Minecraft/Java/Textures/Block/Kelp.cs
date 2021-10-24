using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Kelp : JavaBlockTexture
    {
        public Kelp() : base("Kelp")
        {
            AddVersion("kelp")
                .WithDefaultModel<Java.Models.Block.Kelp>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.KelpTop>();
        }
    }
}
