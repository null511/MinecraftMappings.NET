using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class NetheriteArmor_Layer2 : JavaEntityTexture
    {
        public NetheriteArmor_Layer2() : base("Netherite Armor, Layer 2")
        {
            AddVersion("netherite_layer_2")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer2>();
                //.MapsToBedrockEntity<BedrockEntities.NetheriteArmor_Layer2>();
        }
    }
}
