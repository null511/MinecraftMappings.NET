using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DropperFrontVertical : JavaBlockTexture
    {
        public DropperFrontVertical() : base("Dropper Front, Vertical")
        {
            AddVersion("dropper_front_vertical")
                .WithMinVersion("1.5")
                .WithDefaultModel<Java.Models.Block.DropperVertical>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DropperFrontVertical>();
        }
    }
}
