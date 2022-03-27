using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FireCoral : JavaBlockTexture
    {
        public FireCoral() : base("Fire Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("fire_coral")
                .WithDefaultModel<Java.Models.Block.FireCoral>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FireCoral>();
        }
    }
}
