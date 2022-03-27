using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FireCoralBlock : JavaBlockTexture
    {
        public FireCoralBlock() : base("Fire Coral Block")
        {
            AddVersion("fire_coral_block")
                .WithDefaultModel<Java.Models.Block.FireCoralBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FireCoralBlock>();
        }
    }
}
