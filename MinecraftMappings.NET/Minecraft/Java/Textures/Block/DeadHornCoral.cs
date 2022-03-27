using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadHornCoral : JavaBlockTexture
    {
        public DeadHornCoral() : base("Dead Horn Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_horn_coral")
                .WithDefaultModel<Java.Models.Block.DeadHornCoral>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadHornCoral>();
        }
    }
}
