using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class NetheriteArmor_Layer1 : JavaEntityTexture
    {
        public NetheriteArmor_Layer1() : base("Netherite Armor, Layer 1")
        {
            AddVersion("netherite_layer_1")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer1>();
                //.MapsToBedrockEntity<BedrockEntities.NetheriteArmor_Layer1>();
        }
    }
}
