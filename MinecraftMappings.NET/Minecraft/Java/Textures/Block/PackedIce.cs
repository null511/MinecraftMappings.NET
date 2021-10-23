using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PackedIce : JavaBlockTexture
    {
        public PackedIce() : base("Packed Ice")
        {
            AddVersion("packed_ice")
                .WithDefaultModel<Java.Models.Block.PackedIce>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.IcePacked>();
        }
    }
}
