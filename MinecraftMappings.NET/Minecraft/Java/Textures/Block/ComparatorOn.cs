using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ComparatorOn : JavaBlockTexture
    {
        public ComparatorOn() : base("Comparator, On")
        {
            AddVersion("comparator_on")
                .WithDefaultModel<Java.Models.Block.Comparator_On>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ComparatorOn>();
        }
    }
}
