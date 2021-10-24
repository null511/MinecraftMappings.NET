using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DispenserFront : JavaBlockTexture
    {
        public DispenserFront() : base("Dispenser Front")
        {
            AddVersion("dispenser_front")
                .WithDefaultModel<Java.Models.Block.Dispenser>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DispenserFrontHorizontal>();
        }
    }
}
