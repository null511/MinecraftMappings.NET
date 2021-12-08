using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PoweredRail : JavaBlockTexture
    {
        public PoweredRail() : base("Powered Rail")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("powered_rail")
                .WithDefaultModel<Java.Models.Block.PoweredRail>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailGolden>();
        }
    }
}
