using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonFungus : JavaBlockTexture
    {
        public CrimsonFungus() : base("Crimson Fungus")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("crimson_fungus");
                //.WithDefaultModel<Java.Models.Block.CrimsonFungus>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CrimsonFungus>();
        }
    }
}
