using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DropperFront : JavaBlockTexture
    {
        public DropperFront() : base("Dropper Front")
        {
            AddVersion("dropper_front")
                .WithMinVersion("1.5")
                .WithDefaultModel<Java.Models.Block.Dropper>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DropperFrontHorizontal>();
        }
    }
}
