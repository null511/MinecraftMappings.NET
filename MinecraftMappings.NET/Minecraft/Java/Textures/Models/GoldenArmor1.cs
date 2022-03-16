using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class GoldenArmor1 : JavaEntityModel
    {
        public GoldenArmor1() : base("Golden Armor [1]")
        {
            AddVersion("gold_layer_1", "1.0.0");
                //.WithPath("armor/gold_layer_1")
        }
    }
}
