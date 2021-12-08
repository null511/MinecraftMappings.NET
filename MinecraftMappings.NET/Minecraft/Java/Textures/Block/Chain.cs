using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Chain : JavaBlockTexture
    {
        public Chain() : base("Chain")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("chain")
                .WithDefaultModel<Java.Models.Block.Chain>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Chain>();
        }
    }
}
