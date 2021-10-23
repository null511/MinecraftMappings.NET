using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrindstoneSide : JavaBlockTexture
    {
        public GrindstoneSide() : base("Grindstone Side")
        {
            AddVersion("grindstone_side")
                .WithDefaultModel<Java.Models.Block.Grindstone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrindstoneSide>();
        }
    }
}
