using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Spawner : JavaBlockTexture
    {
        public Spawner() : base("Spawner")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("spawner")
                .WithDefaultModel<Java.Models.Block.Spawner>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MobSpawner>();
        }
    }
}
