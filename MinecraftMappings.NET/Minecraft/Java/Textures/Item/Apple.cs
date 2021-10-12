using MinecraftMappings.Internal.Items;

namespace MinecraftMappings.Minecraft.Java.Textures.Item
{
    public class Apple : JavaItemData
    {
        public const string BlockId = "apple";
        public const string BlockName = "Apple";


        public Apple() : base(BlockName)
        {
            AddVersion(BlockId);
        }
    }
}
