using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Allium : JavaBlockTexture
    {
        public Allium() : base("Allium")
        {
            AddVersion("allium")
                .WithDefaultModel<Java.Models.Block.Allium>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerAllium>();
        }
    }
}
