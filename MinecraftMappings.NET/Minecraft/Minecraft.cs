using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Items;
using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using MinecraftMappings.Internal.Models.Entity;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft
{
    public static class Minecraft
    {
        public static MinecraftJava Java {get;} = new MinecraftJava();

        public static MinecraftBedrock Bedrock {get;} = new MinecraftBedrock();
    }

    public class MinecraftJava : MinecraftGameEdition<JavaBlockTexture, JavaItemData, JavaEntityModel, JavaBlockModel> {}

    public class MinecraftBedrock : MinecraftGameEdition<BedrockBlockTexture, BedrockItemData, BedrockEntityModel, BedrockBlockModel> {}
}
