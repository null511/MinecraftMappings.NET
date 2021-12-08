using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cornflower : JavaBlockTexture
    {
        public Cornflower() : base("Cornflower")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(4, "cornflower")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Cornflower>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerCornflower>();
        }
    }
}
