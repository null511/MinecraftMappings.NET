using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DispenserFrontVertical : JavaBlockTexture
    {
        public DispenserFrontVertical() : base("Dispenser Front, Vertical")
        {
            AddVersion("dispenser_front_vertical")
                .WithDefaultModel<Java.Models.Block.DispenserVertical>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DispenserFrontVertical>();
        }
    }
}
