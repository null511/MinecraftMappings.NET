using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Items;
using MinecraftMappings.Internal.Models.Block;
using MinecraftMappings.Internal.Models.Entity;
using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft
{
    public static class Minecraft
    {
        public static MinecraftJava Java {get;} = new MinecraftJava();

        public static MinecraftBedrock Bedrock {get;} = new MinecraftBedrock();
    }

    public class MinecraftJava : MinecraftGameEdition<JavaBlockTexture, JavaBlockModel, JavaEntityTexture, JavaEntityModel, JavaItemData> {}

    public class MinecraftBedrock : MinecraftGameEdition<BedrockBlockTexture, BedrockBlockModel, BedrockEntityTexture, BedrockEntityModel, BedrockItemData> {}
}
