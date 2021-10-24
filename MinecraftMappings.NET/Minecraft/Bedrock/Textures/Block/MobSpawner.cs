using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MobSpawner : BedrockBlockTexture
    {
        public MobSpawner() : base("Mob Spawner")
        {
            AddVersion("mob_spawner")
                .MapsToJavaBlock<Java.Textures.Block.Spawner>();
        }
    }
}
