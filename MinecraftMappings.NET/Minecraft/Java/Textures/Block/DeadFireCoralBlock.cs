using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadFireCoralBlock : JavaBlockTexture
    {
        public DeadFireCoralBlock() : base("Dead Fire Coral Block")
        {
            AddVersion("dead_fire_coral_block")
                .WithDefaultModel<Java.Models.Block.DeadFireCoralBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadFireCoralBlock>();
        }
    }
}
