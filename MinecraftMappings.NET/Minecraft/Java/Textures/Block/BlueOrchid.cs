using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueOrchid : JavaBlockTexture
    {
        public BlueOrchid() : base("Blue Orchid")
        {
            AddVersion("blue_orchid")
                .WithDefaultModel<Java.Models.Block.BlueOrchid>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerBlueOrchid>();
        }
    }
}
