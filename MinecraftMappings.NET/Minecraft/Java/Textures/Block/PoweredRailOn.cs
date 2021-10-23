using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PoweredRailOn : JavaBlockTexture
    {
        public PoweredRailOn() : base("Powered Rail, On")
        {
            AddVersion("powered_rail_on")
                .WithDefaultModel<Java.Models.Block.PoweredRailOn>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailGoldenPowered>();
        }
    }
}
