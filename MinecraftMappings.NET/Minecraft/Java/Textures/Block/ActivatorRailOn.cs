using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ActivatorRailOn : JavaBlockTexture
    {
        public ActivatorRailOn() : base("Activator Rail, On")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("activator_rail_on")
                .WithDefaultModel<Java.Models.Block.ActivatorRailOn>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailActivatorPowered>();
        }
    }
}
