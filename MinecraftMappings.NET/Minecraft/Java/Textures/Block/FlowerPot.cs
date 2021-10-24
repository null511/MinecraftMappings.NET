using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FlowerPot : JavaBlockTexture
    {
        public FlowerPot() : base("Flower Pot")
        {
            AddVersion("flower_pot")
                .WithMinVersion("1.4.2")
                .WithDefaultModel<Java.Models.Block.FlowerPot>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerPot>();
        }
    }
}
