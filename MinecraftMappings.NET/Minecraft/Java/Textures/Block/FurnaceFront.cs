using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FurnaceFront : JavaBlockTexture
    {
        public FurnaceFront() : base("Furnace Front")
        {
            AddVersion("furnace_front")
                .WithDefaultModel<Java.Models.Block.Furnace>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FurnaceFrontOff>();
        }
    }
}
