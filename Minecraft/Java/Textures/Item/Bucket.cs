using MinecraftMappings.Internal.Items;

namespace MinecraftMappings.Minecraft.Java.Textures.Item
{
    public class Bucket : JavaItemData
    {
        public const string BlockId = "bucket";
        public const string BlockName = "Bucket";


        public Bucket() : base(BlockName)
        {
            AddVersion(BlockId);
        }
    }
}
