using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleSapling : JavaBlockTexture
    {
        public JungleSapling() : base("Jungle Sapling")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("jungle_sapling");
                //.WithDefaultModel<Java.Models.Block.JungleSapling>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.JungleSapling>();
        }
    }
}
