using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class ChainmailArmor_Layer1 : JavaEntityTexture
    {
        public ChainmailArmor_Layer1() : base("Chainmail Armor, Layer 1")
        {
            AddVersion("chainmail_layer_1")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer1>();
                //.MapsToBedrockEntity<BedrockEntities.ChainmailArmor_Layer1>();
        }
    }
}
