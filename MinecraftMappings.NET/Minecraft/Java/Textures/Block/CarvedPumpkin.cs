using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CarvedPumpkin : JavaBlockTexture
    {
        public CarvedPumpkin() : base("Carved Pumpkin")
        {
            AddVersion("carved_pumpkin")
                .WithDefaultModel<Java.Models.Block.CarvedPumpkin>();
                //.MapsToBedrockBlock<BedrockBlocks.CarvedPumpkin>();
        }
    }
}
