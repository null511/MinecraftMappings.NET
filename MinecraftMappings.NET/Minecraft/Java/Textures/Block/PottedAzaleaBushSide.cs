using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PottedAzaleaBushSide : JavaBlockTexture
    {
        public PottedAzaleaBushSide() : base("Potted Azalea Bush Side")
        {
            AddVersion("potted_azalea_bush_side");
                //.WithDefaultModel<Java.Models.Block.PottedAzaleaBush>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PottedAzaleaBushSide>();
        }
    }
}
