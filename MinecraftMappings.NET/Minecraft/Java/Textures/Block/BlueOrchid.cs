using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueOrchid : JavaBlockTexture
    {
        public BlueOrchid() : base("Blue Orchid")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "blue_orchid")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.BlueOrchid>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerBlueOrchid>();
        }
    }
}
