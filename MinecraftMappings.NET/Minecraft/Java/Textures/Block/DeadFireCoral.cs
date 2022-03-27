using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadFireCoral : JavaBlockTexture
    {
        public DeadFireCoral() : base("Dead Fire Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_fire_coral")
                .WithDefaultModel<Java.Models.Block.DeadFireCoral>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadFireCoral>();
        }
    }
}
